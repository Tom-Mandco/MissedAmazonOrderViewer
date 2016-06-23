namespace MandCo.AmazonOrders.Interfaces
{
    using Models;
    using System.Collections.Generic;

    public interface IRepository
    {
        IEnumerable<OrderDetail> GetOrderDetail();
        ExpandedOrderDetail GetExpandedOrderDetail(string orderNumber);
    }
}
