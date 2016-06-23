namespace MandCo.AmazonOrders.Interfaces
{
    public interface IProcessHandler
    {
        void ProcessNewOrder(string orderNumber);
        void writeToExcelFile(string orderNumber);
    }
}
