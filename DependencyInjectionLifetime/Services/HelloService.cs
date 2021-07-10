using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjectionLifetime.Services
{
    public class HelloService
    {
        MesssageService messsageService;
        int _random;

        public HelloService(MesssageService service)
        {
            _random = new Random().Next();
            this.messsageService = service;
        }

        public void print()
        {
            Console.WriteLine($"Hello {_random} Service message: " + messsageService.Message());
        }
    }
}
