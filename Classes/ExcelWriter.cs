namespace MandCo.AmazonOrders.Classes
{
    using Interfaces;
    using ClosedXML.Excel;
    using System.Data;
    using System.Configuration;
    using System.Collections;
    using System;

    public class ExcelWriter : IExcelWriter
    {
        #region Initialization
        private IRepository repository;
        private IDataHandler dataHandler;
        private DataTable orderDetail;

        public ExcelWriter(IRepository repository, IDataHandler dataHandler, DataTable orderDetail)
        {
            this.repository = repository;
            this.dataHandler = dataHandler;
            this.orderDetail = orderDetail;
        }
        #endregion

        #region Main
        public void WriteToExcel(string orderNumber)
        {
            XLWorkbook workbook = new XLWorkbook(String.Format("{0}{1} - [{2}]{3}", 
                    ConfigurationManager.AppSettings["ExcelFilePath"], 
                    ConfigurationManager.AppSettings["ExcelFileName"], 
                    ConfigurationManager.AppSettings["RunLevel"], 
                    ConfigurationManager.AppSettings["FileExtension"]));

            var worksheet = workbook.Worksheet("Missed Orders");

            int numberOfLastRow = worksheet.LastRowUsed().RowNumber();
            IXLCell cellForNewData = worksheet.Cell(numberOfLastRow + 1, 1);

            orderDetail = dataHandler.BindExpandedOrderData(orderNumber);

            cellForNewData.InsertData(orderDetail.Rows);

            worksheet.Columns().AdjustToContents();

            workbook.Save();
        }
        #endregion
    }
}
