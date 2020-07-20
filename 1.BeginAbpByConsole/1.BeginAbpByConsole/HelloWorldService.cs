using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.Options;
using Volo.Abp.DependencyInjection;

namespace _1.BeginAbpByConsole
{
    public class HelloWorldService:ITransientDependency
    {
        private readonly TestOptions _testOptions;

        public HelloWorldService(IOptions<TestOptions> testOptions)
        {
            _testOptions = testOptions.Value;
        }

        public void Hello()
        {
            Console.WriteLine(_testOptions.Message);
        }
    }
}
