using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace LightWAP.Core.Infrastructure.Interfaces
{
    public interface IEngine
    {

        /// <summary>
        /// Register dependencies
        /// </summary>
        /// <param name="services">Collection of service descriptors</param>
        /// <param name="appSettings">App settings</param>
        void RegisterDependencies(IServiceCollection services);
    }
}
