using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static DependencyInjectionLifetime.Enum.Enums;

namespace DependencyInjectionLifetime.Dependecies
{
    public class DependecyResolver
    {
        DependecyContainer _dependecyContainer;
        public DependecyResolver(DependecyContainer dependecyContainer)
        {
            _dependecyContainer = dependecyContainer;
        }

        public T GetService<T>()
        {
            return (T)GetService(typeof(T));
        }

        public object GetService(Type type)
        {
            var dependency = _dependecyContainer.GetDependency(type);
            var constructor = dependency.Type.GetConstructors().Single();
            var parameters = constructor.GetParameters().ToArray();

            if (parameters.Length != 0)
            {
                var parameterImplementations = new object[parameters.Length];

                for (var i = 0; i < parameters.Length; i++)
                {
                    parameterImplementations[i] = GetService(parameters[i].ParameterType);
                }

                return CreateImplementation(dependency, t => Activator.CreateInstance(t, parameterImplementations));
            }

            return CreateImplementation(dependency, t => Activator.CreateInstance(t));
        }

        public object CreateImplementation(Dependecy dependency, Func<Type, object> factory)
        {
            if (dependency.Implemented)
                return dependency.Implementation;

            var implementation = factory(dependency.Type);

            if (dependency.Lifetime == Lifetime.Singleton)
            {
                dependency.AddImplementation(implementation);
            }

            return implementation;
        }

    }
}
