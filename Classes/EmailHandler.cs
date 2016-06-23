namespace MandCo.AmazonOrders.Classes
{
    using Classes;
    using Interfaces;

    public class EmailHandler : IEmailHandler
    {
        private IDataHandler dataHandler;
        private IEmailWriter emailWriter;
        private IEmailSender emailSender;
        
        public EmailHandler(IDataHandler dataHandler, IEmailWriter emailWriter, IEmailSender emailSender)
        {
            this.dataHandler = dataHandler;
            this.emailWriter = emailWriter;
            this.emailSender = emailSender;
        }
    }
}
