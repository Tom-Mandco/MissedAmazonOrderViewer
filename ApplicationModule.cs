namespace MandCo.AmazonOrders
{
    using Ninject.Modules;
    using NLog;
    using Interfaces;
    using Classes;
    using System.Configuration;
    using System;

    public class ApplicationModule : NinjectModule
    {
        public override void Load()
        {
            string connectionString = "";
            try
            {
                connectionString = ConfigurationManager.AppSettings["OracleConnection"];
            }
            catch (Exception ex)
            {

            }

            Bind<ILog>().ToMethod(x =>
            {
                var scope = x.Request.ParentRequest.Service.FullName;
                var log = (ILog)LogManager.GetLogger(scope, typeof(Log));
                return log;
            });
            Bind<IRepository>().To<OracleRepository>().InSingletonScope().WithConstructorArgument("connectionString", connectionString);
            Bind<IDataHandler>().To<DataHandler>();
            Bind<IProcessHandler>().To<ProcessHandler>();
            Bind<IEmailHandler>().To<EmailHandler>();
            Bind<IEmailWriter>().To<EmailWriter>();
            Bind<IEmailSender>().To<EmailSender>();
            Bind<IExcelHandler>().To<ExcelHandler>();
            Bind<IExcelReader>().To<ExcelReader>();
            Bind<IExcelWriter>().To<ExcelWriter>();
            Bind<IExcelCreater>().To<ExcelCreater>();
        }
    }
}
