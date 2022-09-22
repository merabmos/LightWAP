using LightWAP.Core.Infrastructure.DependencyManagment;
using LightWAP.Core.Infrastructure.Interfaces;
using LightWAP.Data.Repository.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace LightWAP.Data.Repository
{
    public class DependencyRegistrar : IDependencyRegistrar
    {
        public void Register(IServiceCollection services)
        {
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
        }
        public int Order => 0;
    }
}
