using LightWAP.Core.Infrastructure.DependencyManagment;
using LightWAP.Services.Localization;
using LightWAP.Services.Localization.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace LightWAP.Services.Infrastructure
{
    public class DependencyRegistrar : IDependencyRegistrar
    {
        public void Register(IServiceCollection services)
        {
            services.AddScoped<ILanguageService, LanguageService>();
        }
        public int Order => 2;
    }
}
