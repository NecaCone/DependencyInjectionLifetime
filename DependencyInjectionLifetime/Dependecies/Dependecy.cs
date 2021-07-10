using System;
using System.Collections.Generic;
using System.Text;
using static DependencyInjectionLifetime.Enum.Enums;

namespace DependencyInjectionLifetime.Dependecies
{
    public class Dependecy
    {
        public Type Type { get; set; }
        public Lifetime Lifetime { get; set; }

        public object Implementation { get; set; }
        public bool Implemented { get; set; }

        public Dependecy(Type type, Lifetime lifetime)
        {
            Type = type;
            Lifetime = lifetime;
        }

        public void AddImplementation(object objectToImplement)
        {
            this.Implementation = objectToImplement;
            this.Implemented = true;
        }
    }
}
