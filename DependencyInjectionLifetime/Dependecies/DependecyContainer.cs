using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static DependencyInjectionLifetime.Enum.Enums;

namespace DependencyInjectionLifetime.Dependecies
{
    public sealed class DependecyContainer
    {
        private List<Dependecy> _dependencies;
        private DependecyContainer()
        {
            _dependencies = new List<Dependecy>();
        }

        private static DependecyContainer instance = null;
        public static DependecyContainer Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DependecyContainer();
                }
                return instance;
            }
        }

        public void AddSingleton<T>()
        {
            _dependencies.Add(new Dependecy(typeof(T), Lifetime.Singleton));
        }

        public void AddTransient<T>()
        {
            _dependencies.Add(new Dependecy(typeof(T), Lifetime.Transient));
        }

        public Dependecy GetDependency(Type type)
        {
            var dependency = _dependencies.Single(_ => _.Type.Name == type.Name);
            return dependency;
        }
    }
}
