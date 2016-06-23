using System;

namespace MandCo.AmazonOrders.Models
{
    public class ExpandedOrderDetail
    {

        public DateTime ORIG_ORDER_DATE { get; set; }
        public DateTime ORDER_DATE { get; set; }
        public DateTime LAST_UPDATE { get; set; }
        public DateTime DATE_CORRECTED { get; set; }
        public DateTime AUTHORISATION_DATE { get; set; }

        public string CUST_NO { get; set; }
        public string CUST_TITLE { get; set; }
        public string CUST_FIRSTNAME { get; set; }
        public string CUST_SURNAME { get; set; }
        public string HOUSE_NUMBER { get; set; }
        public string STREET { get; set; }
        public string DISTRICT { get; set; }
        public string TOWN { get; set; }
        public string COUNTY { get; set; }
        public string POSTCODE { get; set; }
        public string TEL_NO { get; set; }
        public string ORDER_NUMBER { get; set; }
        public string EMAIL_ADDRESS { get; set; }
        public string COMPANY_NAME { get; set; }
        public string JOB_TITLE { get; set; }
        public string COUNTRY_CODE { get; set; }
        public string TEL_NO2 { get; set; }
        public string DEL_CUST_TITLE { get; set; }
        public string DEL_CUST_FIRSTNAME { get; set; }
        public string DEL_CUST_SURNAME { get; set; }
        public string DEL_HOUSE_NO { get; set; }
        public string DEL_STREET { get; set; }
        public string DEL_DISTRICT { get; set; }
        public string DEL_TOWN { get; set; }
        public string DEL_COUNTY { get; set; }
        public string DEL_COUNTRY_CODE { get; set; }
        public string DEL_POSTCODE { get; set; }
        public string CHANNEL_TRACKING_NO { get; set; }
        public string LAST_UPDATE_USER { get; set; }
        public string TRACKING_NO { get; set; }
        public string COMMENTS { get; set; }
        public string VALIDATION_ERRORS { get; set; }
        public string CORRECTED_BY { get; set; }
        public string AUTHORISATION_FLAG { get; set; }
        public string AUTHORISATION_USER { get; set; }
        public string LOYALTY_NUMBER { get; set; }
        public string CHANNEL_ORDERNO { get; set; }

        public int ORDER_STATUS { get; set; }
        public int ORIG_BRANCH { get; set; }
        public int DELIVER_TO { get; set; }
        public int DEL_BRANCH { get; set; }
        public int DEL_OPTION { get; set; }
        public int PAYMENT_STATUS { get; set; }
        public int SOURCE_CHANNEL { get; set; }
        public int NO_OF_ERRORS { get; set; }
        public int PICKLIST_NO { get; set; }
        public int CARRIER { get; set; }
        public float DEL_CHARGE { get; set; }
        public float DEPOSIT_PAID { get; set; }
        public float TOTAL_AMOUNT { get; set; }
        public float WEIGHT_KG { get; set; }
        public float TOTAL_DISCOUNT { get; set; }
        public float VAT { get; set; }
        public float GIFTWRAP { get; set; }

    }
}