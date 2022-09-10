using LightWAP.Core.Infrastructure.DependencyManagment;
using LightWAP.Core.Infrastructure.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LightWAP.Core.Infrastructure
{
    public class LightWAPEngine : IEngine
    {
        public virtual void RegisterDependencies(IServiceCollection services)
        {
            var typeFinder = new AppDomainTypeFinder();

            services.AddSingleton<IEngine>(this);

            services.AddSingleton<ITypeFinder>(typeFinder);

            var dependencyRegistrars = typeFinder.FindClassesOfType<IDependencyRegistrar>();

            var instances = dependencyRegistrars.Select(dependencyRegistrars => (IDependencyRegistrar)Activator.CreateInstance(dependencyRegistrars)).
                OrderBy(dependencyRegistrars => dependencyRegistrars.Order);

            foreach (var dependencyRegistrar in instances)
                dependencyRegistrar.Register(services);

            services.AddSingleton(services);
        }
    }
}
