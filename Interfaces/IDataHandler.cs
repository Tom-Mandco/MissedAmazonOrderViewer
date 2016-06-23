namespace MandCo.AmazonOrders.Interfaces
{
    using System.Collections.Generic;
    using System.Data;
    using System.Windows.Forms;
    using Models;

    public interface IDataHandler
    {
        void SetOrderDataGrid(DataGridView dg);
        DataTable BindOrderData();
        IEnumerable<OrderDetail> GetUnprocessedOrders();
        DataTable BindExpandedOrderData(string orderNumber);
    }
}
