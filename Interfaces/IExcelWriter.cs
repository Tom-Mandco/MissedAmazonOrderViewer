namespace MandCo.AmazonOrders.Interfaces
{
    public interface IExcelWriter
    {
        void WriteToExcel(string orderNumber);
    }
}
