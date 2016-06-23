namespace MandCo.AmazonOrders
{
    using System;
    using System.Windows.Forms;

    static class AmazonOrders
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            CompositionRoot.Wire(new ApplicationModule());

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(CompositionRoot.Resolve<AppForm>());
        }
    }
}
