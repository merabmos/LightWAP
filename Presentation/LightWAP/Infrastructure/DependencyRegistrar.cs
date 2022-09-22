using LightWAP.Core.Infrastructure.DependencyManagment;
using LightWAP.Services.Localization;
using LightWAP.Services.Localization.Interfaces;
using LightWAP.Web.Areas.Admin.Factories;
using LightWAP.Web.Areas.Admin.Factories.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace LightWAP.Web.Infrastructure
{
    public class DependencyRegistrar : IDependencyRegistrar
    {
        public void Register(IServiceCollection services)
        {
            #region Services
            services.AddScoped<ILanguageService, LanguageService>();
            services.AddScoped<ILanguageStringResourceService, LanguageStringResourceService>();
            #endregion

            #region Factories

            services.AddScoped<ILanguageFactory, LanguageFactory>();

            #endregion
        }
        public int Order => 2;
    }
}
