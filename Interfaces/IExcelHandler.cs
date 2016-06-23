namespace MandCo.AmazonOrders.Interfaces
{
    using Classes;
    public interface IExcelHandler
    {
        void writeToExcel(string orderNumber);
    }
}
