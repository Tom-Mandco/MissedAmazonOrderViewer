namespace MandCo.AmazonOrders.Classes
{
    using System.Diagnostics;
    using Interfaces;
    using System.Configuration;
    using System;
    using NLog;

    public class ProcessHandler : IProcessHandler
    {
        private readonly IExcelHandler excelHandler;
        private readonly IEmailHandler emailHandler;
        private readonly ILog Logger;

        public ProcessHandler(ILog Logger, IExcelHandler excelHandler, IEmailHandler emailHandler)
        {
            this.Logger = Logger;
            this.excelHandler = excelHandler;
            this.emailHandler = emailHandler;
        }

        public void ProcessNewOrder(string orderNumber)
        {
            Process p = new Process();
            p.StartInfo.FileName = @"F:\runPHPLive.bat";
            p.StartInfo.Arguments = orderNumber + "2";
            p.Start();
            try
            {
                p.WaitForExit();
            }
            catch (Exception ex)
            {
                Logger.Error(ex.Message);
                Logger.Error(ex.StackTrace);
            }
        }

        public void writeToExcelFile(string orderNumber)
        {
            excelHandler.writeToExcel(orderNumber);
        }

        public void writeToEmail(string orderNumber)
        {

        }
    }
}
