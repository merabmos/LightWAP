using LightWAP.Web.Areas.Admin.Models.Language;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LightWAP.Web.Areas.Admin.Factories.Interfaces
{
    public interface ILanguageStringResourceFactory
    {
        Task<List<LanguageStringResourceModel>> PrepareLanguageStringResourceModelsAsync(int? languageId);
        Task<LanguageStringResourceModel> PrepareLanguageStringResourceModelAsync(int Id);
        Task AddLanguageStringResourceAsync(LanguageStringResourceModel model);

    }
}
