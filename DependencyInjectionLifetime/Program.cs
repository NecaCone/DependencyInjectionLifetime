using DependencyInjectionLifetime.Dependecies;
using DependencyInjectionLifetime.Services;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DependencyInjectionLifetime
{
    class Program
    {
        static void Main(string[] args)
        {

            var configuration = Configuration.Configuration.Instance;
            configuration.dependecyContainer.AddTransient<HelloService>();
            configuration.dependecyContainer.AddTransient<ServiceConsumer>();
            configuration.dependecyContainer.AddSingleton<MesssageService>();

            var resolver = new DependecyResolver(configuration.dependecyContainer); 

            var service = resolver.GetService<ServiceConsumer>();
            var service2 = resolver.GetService<MesssageService>();

            var a = new Test1(service2);
            a.Print();
        }
    }

    public class Test1
    {
        private MesssageService _messsageService;
        public Test1(MesssageService messsageService)
        {
            _messsageService = messsageService;
        }

        public void Print() {
            Console.WriteLine($"Im using the Message Service {_messsageService.Message() }");
        }
    }

}
