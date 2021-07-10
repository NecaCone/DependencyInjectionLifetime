using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjectionLifetime.Enum
{
    public class Enums
    {
        public enum Lifetime
        {
            // same instance
            Singleton = 0,
            //fresh instance every type 
            Transient = 1
        }
    }
}
