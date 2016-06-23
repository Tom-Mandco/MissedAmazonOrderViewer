namespace MandCo.AmazonOrders
{
    using Interfaces;
    using System;
    using System.Drawing;
    using System.Threading;
    using System.Windows.Forms;

    public partial class AppForm : Form
    {
        #region Initialization
        private readonly IRepository repository;
        private readonly IDataHandler dataHandler;
        private readonly IProcessHandler processHandler;
        private readonly IExcelHandler excelHandler;
        private readonly IEmailHandler emailHandler;
        private readonly ILog Logger;


        public AppForm(IRepository repository, IDataHandler dataHandler, IProcessHandler processHandler, IExcelHandler excelHandler, IEmailHandler emailHandler, ILog Logger)
        {
            this.processHandler = processHandler;
            this.dataHandler = dataHandler;
            this.repository = repository;
            this.excelHandler = excelHandler;
            this.emailHandler = emailHandler;
            this.Logger = Logger;
            InitializeComponent();
        }
        #endregion

        #region On-Event Classes
        private void AppForm_Load(object sender, EventArgs e)
        {
            Run();
        }

        private void btnGetData_Click(object sender, EventArgs e)
        {
            Run();
        }

        private void dgOrdersView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgOrdersView.Columns[e.ColumnIndex].HeaderText == "Fix")
            {
                int orderNumberColumnIndex = 0;
                for (int i = 0; i < dgOrdersView.Columns.Count; i++)
                {
                    if (dgOrdersView.Columns[i].HeaderText == "Order Number")
                    {
                        orderNumberColumnIndex = i;
                    }
                }
                MessageBox.Show((dgOrdersView.Rows[e.RowIndex].Cells[orderNumberColumnIndex].Value.ToString()));

                string orderNumber = (dgOrdersView.Rows[e.RowIndex].Cells[orderNumberColumnIndex].Value.ToString());

                try
                {
                    processHandler.ProcessNewOrder(orderNumber);
                    processHandler.writeToExcelFile(orderNumber);
                }
                catch (Exception ex)
                {
                    Logger.Error(ex.Source);
                    Logger.Error(ex.StackTrace);
                }

                Thread.Sleep(500);
                Run();
            }
        }
        #endregion

        #region Main Classes
        public void Run()
        {
            try
            {
                dgOrdersView.DataSource = dataHandler.BindOrderData();
                dataHandler.SetOrderDataGrid(dgOrdersView);
                SetLabels();
                SetFormSizes();
            }
            catch (Exception ex)
            {

            }
        }
        #endregion

        #region Utility Classes
        public void SetLabels()
        {
            lblLastRefreshed.Text = String.Format("Last Refreshed on {0} at {1}", DateTime.Now.ToShortDateString(), DateTime.Now.ToLongTimeString());
        }

        private void SetFormSizes()
        {
            btnGetData.Size = new Size(dgOrdersView.Width, 20);
            lblLastRefreshed.Size = new Size(dgOrdersView.Width, 13);
            this.Size = new Size(dgOrdersView.Width + 44, (dgOrdersView.Location.Y + dgOrdersView.Size.Height + 53));
        }
        #endregion

        private void AppForm_Resize(object sender, EventArgs e)
        {
            //NotifyIcon notifyIcon = new NotifyIcon();

            //if (FormWindowState.Minimized == this.WindowState)
            //{
            //    notifyIcon.Visible = true;
            //    notifyIcon.BalloonTipText = "My application still working...";
            //    notifyIcon.BalloonTipTitle = "My Sample Application";
            //    notifyIcon.BalloonTipIcon = ToolTipIcon.Info;
            //    notifyIcon.ShowBalloonTip(500);

            //    this.Hide();
            //}
            //else if (FormWindowState.Normal == this.WindowState)
            //{
            //    notifyIcon.Visible = false;
            //}
        }
    }
}