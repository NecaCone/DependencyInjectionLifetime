using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjectionLifetime.Services
{
    public class ServiceConsumer
    {
        HelloService _helloService;

        public ServiceConsumer(HelloService helloService)
        {
            this._helloService = helloService;
        }

        public void print()
        {
            this._helloService.print();
        }
    }
}
