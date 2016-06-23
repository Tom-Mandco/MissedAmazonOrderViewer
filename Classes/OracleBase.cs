namespace MandCo.AmazonOrders.Classes
{
    using PetaPoco;
    using Oracle.ManagedDataAccess.Client;

    public class OracleBase
    {
        protected readonly PetaPoco.Database dbConnection;

        public OracleBase(string connectionString)
        {
            dbConnection = new Database(connectionString, new OracleClientFactory());
        }

        public SharedConnection GetSharedConnection()
        {
            return new SharedConnection(dbConnection);
        }
    }
}
