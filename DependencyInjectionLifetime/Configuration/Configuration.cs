using DependencyInjectionLifetime.Dependecies;
using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjectionLifetime.Configuration
{
    public sealed class Configuration
    {
        public DependecyContainer dependecyContainer;

        private Configuration()
        { 
            dependecyContainer = DependecyContainer.Instance;
        } 

        private static Configuration instance = null;
        public static Configuration Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Configuration();
                }
                return instance;
            }
        }

    }
}
