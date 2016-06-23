namespace MandCo.AmazonOrders.Classes
{
    using Interfaces;
    using ClosedXML.Excel;
    using System.Configuration;
    using System;
    using System.Collections.Generic;
    using System.Data;

    public class ExcelCreater : IExcelCreater
    {
        private ILog logger;

        public ExcelCreater(ILog logger)
        {
            this.logger = logger;
        }

        public void CreateNewSpreadsheet()
        {
            logger.Info(String.Format("Excel Creater - Generating Spreadsheet\n Path : {0}\n Name : {1}",ConfigurationManager.AppSettings["ExcelFilePath"], ConfigurationManager.AppSettings["ExcelFileName"]));

            DataTable dt = GetHeadersInTable();

            XLWorkbook xlwb = new XLWorkbook();
            xlwb.Worksheets.Add(dt, "Missed Orders");

            xlwb.SaveAs(String.Format("{0}{1} - [{2}]{3}",
                    ConfigurationManager.AppSettings["ExcelFilePath"],
                    ConfigurationManager.AppSettings["ExcelFileName"],
                    ConfigurationManager.AppSettings["RunLevel"],
                    ConfigurationManager.AppSettings["FileExtension"]));
        }

        List<string> GetTabHeaders()
        {
            List<string> result = new List<string>();

            result.Add("Order Number");
            result.Add("Order Status");
            result.Add("Order Date");
            result.Add("Orig Branch");
            result.Add("Orig Order Date");
            result.Add("Cust No");
            result.Add("Cust Title");
            result.Add("Cust Firstname");
            result.Add("Cust Surname");
            result.Add("House Number");
            result.Add("Street");
            result.Add("District");
            result.Add("Town");
            result.Add("County");
            result.Add("Postcode");
            result.Add("Tel No");
            result.Add("Email Address");
            result.Add("Deliver To");
            result.Add("Del Branch");
            result.Add("Del Charge");
            result.Add("Del Option");
            result.Add("Payment Status");
            result.Add("Deposit Paid");
            result.Add("Total Amount");
            result.Add("Last Update");
            result.Add("Last Update User");
            result.Add("Weight Kg");
            result.Add("Carrier");
            result.Add("Tracking No");
            result.Add("Picklist No");
            result.Add("Comments");
            result.Add("No Of Errors");
            result.Add("Validation Errors");
            result.Add("Date Corrected");
            result.Add("Corrected By");
            result.Add("Authorisation Flag");
            result.Add("Authorisation User");
            result.Add("Authorisation Date");
            result.Add("Source Channel");
            result.Add("Channel Orderno");
            result.Add("Company Name");
            result.Add("Job Title");
            result.Add("Country Code");
            result.Add("Tel No2");
            result.Add("Del Cust Title");
            result.Add("Del Cust Firstname");
            result.Add("Del Cust Surname");
            result.Add("Del House No");
            result.Add("Del Street");
            result.Add("Del District");
            result.Add("Del Town");
            result.Add("Del County");
            result.Add("Del Country Code");
            result.Add("Del Postcode");
            result.Add("Channel Tracking No");
            result.Add("Total Discount");
            result.Add("Vat");
            result.Add("Giftwrap");
            result.Add("Loyalty Number");

            return result;
        }


        DataTable GetHeadersInTable()
        {
            List<string> list = GetTabHeaders();
            DataTable table = new DataTable();

            foreach (string s in list)
            {
                table.Columns.Add(s);
            }

            

            return table;
        }
    }
}
