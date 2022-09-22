using LightWAP.Web.Areas.Admin.Models.Language;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LightWAP.Web.Areas.Admin.Factories.Interfaces
{
    public interface ILanguageFactory
    {
        Task<List<LanguageModel>> PrepareLanguageModelsAsync();
        Task AddLanguageAsync(LanguageModel model);
        Task<LanguageModel> PrepareLanguageModelAsync(int Id);
    }
}
