namespace MandCo.AmazonOrders
{
    partial class AppForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppForm));
            this.btnGetData = new System.Windows.Forms.Button();
            this.dgOrdersView = new System.Windows.Forms.DataGridView();
            this.lblLastRefreshed = new System.Windows.Forms.Label();
            this.tmrRefresh = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgOrdersView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGetData
            // 
            this.btnGetData.Location = new System.Drawing.Point(12, 25);
            this.btnGetData.Name = "btnGetData";
            this.btnGetData.Size = new System.Drawing.Size(350, 20);
            this.btnGetData.TabIndex = 0;
            this.btnGetData.Text = "Refresh Data";
            this.btnGetData.UseVisualStyleBackColor = true;
            this.btnGetData.Click += new System.EventHandler(this.btnGetData_Click);
            // 
            // dgOrdersView
            // 
            this.dgOrdersView.AllowUserToAddRows = false;
            this.dgOrdersView.AllowUserToDeleteRows = false;
            this.dgOrdersView.AllowUserToResizeColumns = false;
            this.dgOrdersView.AllowUserToResizeRows = false;
            this.dgOrdersView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgOrdersView.Location = new System.Drawing.Point(12, 51);
            this.dgOrdersView.Name = "dgOrdersView";
            this.dgOrdersView.Size = new System.Drawing.Size(350, 147);
            this.dgOrdersView.TabIndex = 1;
            this.dgOrdersView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgOrdersView_CellClick);
            // 
            // lblLastRefreshed
            // 
            this.lblLastRefreshed.AutoSize = true;
            this.lblLastRefreshed.Location = new System.Drawing.Point(12, 9);
            this.lblLastRefreshed.Name = "lblLastRefreshed";
            this.lblLastRefreshed.Size = new System.Drawing.Size(85, 13);
            this.lblLastRefreshed.TabIndex = 2;
            this.lblLastRefreshed.Text = "[Last Refreshed]";
            // 
            // AppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 257);
            this.Controls.Add(this.lblLastRefreshed);
            this.Controls.Add(this.dgOrdersView);
            this.Controls.Add(this.btnGetData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AppForm";
            this.Text = "Missed Amazon Orders";
            this.Load += new System.EventHandler(this.AppForm_Load);
            this.Resize += new System.EventHandler(this.AppForm_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dgOrdersView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetData;
        private System.Windows.Forms.DataGridView dgOrdersView;
        private System.Windows.Forms.Label lblLastRefreshed;
        private System.Windows.Forms.Timer tmrRefresh;
    }
}