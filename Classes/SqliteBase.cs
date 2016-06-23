namespace MandCo.AmazonOrders.Classes
{
    using System.Data.Common;

    public class SqliteBase
    {
        private readonly PetaPoco.Database dbConnection;

        public SqliteBase(string connectionString)
        {

            DbProviderFactory sqlFactory = new System.Data.SQLite.SQLiteFactory();
            var db = new PetaPoco.Database(connectionString, sqlFactory);
        }

        public SharedConnection GetSharedConnection()
        {
            return new SharedConnection(dbConnection);
        }
    }
}