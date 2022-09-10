using LightWAP.Core.Infrastructure.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace LightWAP.Core.Infrastructure.DependencyManagment
{
    public interface IDependencyRegistrar
    {
        void Register(IServiceCollection services);

        int Order { get; }
    }
}
