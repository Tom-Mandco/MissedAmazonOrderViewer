namespace MandCo.AmazonOrders.Classes
{
    using PetaPoco;
    using System;

    public class SharedConnection : IDisposable
    {
        private Database db;

        public SharedConnection(Database db)
        {
            this.db = db;
            this.db.OpenSharedConnection();
        }

        public void Dispose()
        {
            this.db.CloseSharedConnection();
        }
    }
}
