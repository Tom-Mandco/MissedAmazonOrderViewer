namespace MandCo.AmazonOrders.Classes
{
    using Interfaces;
    using System;
    using System.Configuration;
    using System.IO;

    public class ExcelHandler : IExcelHandler
    {
        #region Initialization
        private readonly ILog logger;
        private IDataHandler dataHandler;
        private IExcelCreater excelCreater;
        private IExcelWriter excelWriter;
        private IExcelReader excelReader;

        public ExcelHandler(ILog logger, IDataHandler dataHandler, IExcelCreater excelCreater, IExcelWriter excelWriter, IExcelReader excelReader)
        {
            this.logger = logger;
            this.dataHandler = dataHandler;
            this.excelCreater = excelCreater;
            this.excelWriter = excelWriter;
            this.excelReader = excelReader;
        }
        #endregion

        #region Main Functions
        public void writeToExcel(string orderNumber)
        {
            logger.Info("Excel Hander - Write to Excel: Started");
            if (!DoesExcelFileExist())
            {
                excelCreater.CreateNewSpreadsheet();
            }

            excelWriter.WriteToExcel(orderNumber);
        }
        #endregion

        #region Utilities
        bool DoesExcelFileExist()
        {
            return File.Exists(String.Format("{0}{1} - [{2}]{3}",
                    ConfigurationManager.AppSettings["ExcelFilePath"],
                    ConfigurationManager.AppSettings["ExcelFileName"],
                    ConfigurationManager.AppSettings["RunLevel"],
                    ConfigurationManager.AppSettings["FileExtension"]));
        }
        #endregion
    }
}
