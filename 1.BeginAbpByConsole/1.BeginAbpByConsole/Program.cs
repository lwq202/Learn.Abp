using System;
using Volo.Abp;

namespace _1.BeginAbpByConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var application=AbpApplicationFactory.Create<AppModule>())
            {
                Console.WriteLine("调用Initialize前");
                application.Initialize();//初始化
                Console.WriteLine("调用Initialize后");

                var helloWorldService =
                    application.ServiceProvider.GetService(typeof(HelloWorldService)) as HelloWorldService;
                helloWorldService.Hello();
                Console.WriteLine("调用Shutdown前");
                application.Shutdown();
                Console.WriteLine("调用Shutdown后");
            }
            Console.WriteLine("Hello World!");
        }
    }
}
