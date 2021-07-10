using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjectionLifetime.Services
{
    public class MesssageService
    {
        int _random;
        public MesssageService()
        {
            _random = new Random().Next();
        }
        public string Message()
        {
            return "Test" + _random;
        }
    }
}
