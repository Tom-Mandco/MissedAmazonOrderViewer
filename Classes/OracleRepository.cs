namespace MandCo.AmazonOrders.Classes
{
    using Interfaces;
    using Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class OracleRepository : OracleBase, IRepository
    {
        public OracleRepository(string connectionString)
            : base(connectionString)
        {
        }

        public string getConnectionStringFromOR()
        {
            using (new SharedConnection(dbConnection))
            {
                return dbConnection.Connection.ConnectionString.ToString();
            }
        }

        public IEnumerable<OrderDetail> GetOrderDetail()
        {
            using (new SharedConnection(dbConnection))
            {
                var result = dbConnection.Query<OrderDetail>(SqlLoader.GetSql("GetOrderDetails"));
                return result.Any() ? result : null;
            }
        }

        public ExpandedOrderDetail GetExpandedOrderDetail(string orderNumber)
        {
            using (new SharedConnection(dbConnection))
            {
                var result = dbConnection.Query<ExpandedOrderDetail>(SqlLoader.GetSql("GetExpandedOrderDetails"), orderNumber);
                return result.Any() ? result.First() : null;
            }
        }
    }
}
