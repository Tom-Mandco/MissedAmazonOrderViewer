namespace MandCo.AmazonOrders.Classes
{
    using System.Windows.Forms;
    using Interfaces;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Data;

    public class DataHandler : IDataHandler
    {
        private readonly IRepository repository;

        public DataHandler(IRepository repository)
        {
            this.repository = repository;
        }

        public void SetOrderDataGrid(DataGridView dg)
        {
            string ButtonColumnName = "Fix";

            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();

            if (dg.Columns.Count < 3)
            {
                dg.Columns.Add(btn);
                btn.HeaderText = ButtonColumnName;
                btn.Text = "Run PHP";
                btn.Name = "btnEnabled";
                btn.UseColumnTextForButtonValue = true;
            }

            dg.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dg.RowHeadersVisible = false;
            dg.AutoResizeRows();
            dg.AutoResizeColumns();
            dg.AllowUserToAddRows = false;
            dg.AllowUserToDeleteRows = false;

            dg.Width = dg.Columns.GetColumnsWidth(DataGridViewElementStates.Displayed) + (dg.RowHeadersVisible ? dg.RowHeadersWidth : 0) + 3;
            dg.Height = dg.Rows.GetRowsHeight(DataGridViewElementStates.Displayed) + (dg.ColumnHeadersVisible ? dg.ColumnHeadersHeight : 0) + 3;
        }

        public IEnumerable<OrderDetail> GetUnprocessedOrders()
        {
            return repository.GetOrderDetail();
        }

        public ExpandedOrderDetail GetExpandedOrderDetail(string orderNumber)
        {
            return repository.GetExpandedOrderDetail(orderNumber);
        }

        public DataTable BindOrderData()
        {
            DataTable orderDT = new DataTable();
            orderDT.Columns.Add("Order Number");
            orderDT.Columns.Add("Last Updated");

            IEnumerable<OrderDetail> OrderDetails = GetUnprocessedOrders();
            if (OrderDetails != null)
            {
                foreach (var detail in OrderDetails)
                {
                    orderDT.Rows.Add(detail.Order_Number, detail.Last_update);
                }
            }
            else
            {
                orderDT.Rows.Add("No Rows Found", "");
            }
            return orderDT;
        }

        public DataTable BindExpandedOrderData(string orderNumber)
        {
            DataTable orderDT = new DataTable();

            ExpandedOrderDetail OrderDetail = GetExpandedOrderDetail(orderNumber);
            if (OrderDetail != null)
            {
                #region Set Columns
                orderDT.Columns.Add("Order Number");
                orderDT.Columns.Add("Order Status");
                orderDT.Columns.Add("Order Date");
                orderDT.Columns.Add("Orig Branch");
                orderDT.Columns.Add("Orig Order Date");
                orderDT.Columns.Add("Cust No");
                orderDT.Columns.Add("Cust Title");
                orderDT.Columns.Add("Cust Firstname");
                orderDT.Columns.Add("Cust Surname");
                orderDT.Columns.Add("House Number");
                orderDT.Columns.Add("Street");
                orderDT.Columns.Add("District");
                orderDT.Columns.Add("Town");
                orderDT.Columns.Add("County");
                orderDT.Columns.Add("Postcode");
                orderDT.Columns.Add("Tel No");
                orderDT.Columns.Add("Email Address");
                orderDT.Columns.Add("Deliver To");
                orderDT.Columns.Add("Del Branch");
                orderDT.Columns.Add("Del Charge");
                orderDT.Columns.Add("Del Option");
                orderDT.Columns.Add("Payment Status");
                orderDT.Columns.Add("Deposit Paid");
                orderDT.Columns.Add("Total Amount");
                orderDT.Columns.Add("Last Update");
                orderDT.Columns.Add("Last Update User");
                orderDT.Columns.Add("Weight Kg");
                orderDT.Columns.Add("Carrier");
                orderDT.Columns.Add("Tracking No");
                orderDT.Columns.Add("Picklist No");
                orderDT.Columns.Add("Comments");
                orderDT.Columns.Add("No Of Errors");
                orderDT.Columns.Add("Validation Errors");
                orderDT.Columns.Add("Date Corrected");
                orderDT.Columns.Add("Corrected By");
                orderDT.Columns.Add("Authorisation Flag");
                orderDT.Columns.Add("Authorisation User");
                orderDT.Columns.Add("Authorisation Date");
                orderDT.Columns.Add("Source Channel");
                orderDT.Columns.Add("Channel Orderno");
                orderDT.Columns.Add("Company Name");
                orderDT.Columns.Add("Job Title");
                orderDT.Columns.Add("Country Code");
                orderDT.Columns.Add("Tel No2");
                orderDT.Columns.Add("Del Cust Title");
                orderDT.Columns.Add("Del Cust Firstname");
                orderDT.Columns.Add("Del Cust Surname");
                orderDT.Columns.Add("Del House No");
                orderDT.Columns.Add("Del Street");
                orderDT.Columns.Add("Del District");
                orderDT.Columns.Add("Del Town");
                orderDT.Columns.Add("Del County");
                orderDT.Columns.Add("Del Country Code");
                orderDT.Columns.Add("Del Postcode");
                orderDT.Columns.Add("Channel Tracking No");
                orderDT.Columns.Add("Total Discount");
                orderDT.Columns.Add("Vat");
                orderDT.Columns.Add("Giftwrap");
                orderDT.Columns.Add("Loyalty Number");
                #endregion

                orderDT.Rows.Add(OrderDetail.ORDER_NUMBER, OrderDetail.ORDER_STATUS, OrderDetail.ORDER_DATE, OrderDetail.ORIG_BRANCH, OrderDetail.ORIG_ORDER_DATE,
                    OrderDetail.CUST_NO, OrderDetail.CUST_TITLE, OrderDetail.CUST_FIRSTNAME, OrderDetail.CUST_SURNAME, OrderDetail.HOUSE_NUMBER, OrderDetail.STREET,
                    OrderDetail.DISTRICT, OrderDetail.TOWN, OrderDetail.COUNTY, OrderDetail.POSTCODE, OrderDetail.TEL_NO, OrderDetail.EMAIL_ADDRESS, OrderDetail.DELIVER_TO,
                    OrderDetail.DEL_BRANCH, OrderDetail.DEL_CHARGE, OrderDetail.DEL_OPTION, OrderDetail.PAYMENT_STATUS, OrderDetail.DEPOSIT_PAID, OrderDetail.TOTAL_AMOUNT,
                    OrderDetail.LAST_UPDATE, OrderDetail.LAST_UPDATE_USER, OrderDetail.WEIGHT_KG, OrderDetail.CARRIER, OrderDetail.TRACKING_NO, OrderDetail.PICKLIST_NO,
                    OrderDetail.COMMENTS, OrderDetail.NO_OF_ERRORS, OrderDetail.VALIDATION_ERRORS, OrderDetail.DATE_CORRECTED, OrderDetail.CORRECTED_BY,
                    OrderDetail.AUTHORISATION_FLAG, OrderDetail.AUTHORISATION_USER, OrderDetail.AUTHORISATION_DATE, OrderDetail.SOURCE_CHANNEL, OrderDetail.CHANNEL_ORDERNO,
                    OrderDetail.COMPANY_NAME, OrderDetail.JOB_TITLE, OrderDetail.COUNTRY_CODE, OrderDetail.TEL_NO2, OrderDetail.DEL_CUST_TITLE, OrderDetail.DEL_CUST_FIRSTNAME,
                    OrderDetail.DEL_CUST_SURNAME, OrderDetail.DEL_HOUSE_NO, OrderDetail.DEL_STREET, OrderDetail.DEL_DISTRICT, OrderDetail.DEL_TOWN, OrderDetail.DEL_COUNTY,
                    OrderDetail.DEL_COUNTRY_CODE, OrderDetail.DEL_POSTCODE, OrderDetail.CHANNEL_TRACKING_NO, OrderDetail.TOTAL_DISCOUNT, OrderDetail.VAT, OrderDetail.GIFTWRAP,
                    OrderDetail.LOYALTY_NUMBER);
            }
            else
            {
            }
            return orderDT;
        }
    }
}
