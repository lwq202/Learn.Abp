using System;
using Volo.Abp;
using Volo.Abp.Modularity;

namespace _1.BeginAbpByConsole
{
    public class AppModule:AbpModule
    {
        public override void PreConfigureServices(ServiceConfigurationContext context)
        {
            Configure<TestOptions>(option => { option.Message = "你好"; });
            Console.WriteLine(System.Reflection.MethodBase.GetCurrentMethod().Name);
        }

        public override void ConfigureServices(ServiceConfigurationContext context)
        {

            Console.WriteLine(System.Reflection.MethodBase.GetCurrentMethod().Name);
        }

        public override void PostConfigureServices(ServiceConfigurationContext context)
        {

            Console.WriteLine(System.Reflection.MethodBase.GetCurrentMethod().Name);
        }

        public override void OnPreApplicationInitialization(ApplicationInitializationContext context)
        {

            Console.WriteLine(System.Reflection.MethodBase.GetCurrentMethod().Name);
        }

        public override void OnApplicationInitialization(ApplicationInitializationContext context)
        {

            Console.WriteLine(System.Reflection.MethodBase.GetCurrentMethod().Name);
        }

        public override void OnPostApplicationInitialization(ApplicationInitializationContext context)
        {

            Console.WriteLine(System.Reflection.MethodBase.GetCurrentMethod().Name);
        }

        public override void OnApplicationShutdown(ApplicationShutdownContext context)
        {

            Console.WriteLine(System.Reflection.MethodBase.GetCurrentMethod().Name);
        }
    }
}