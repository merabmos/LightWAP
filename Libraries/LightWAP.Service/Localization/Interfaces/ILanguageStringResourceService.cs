using LightWAP.Core.Domain.Language;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LightWAP.Services.Localization.Interfaces
{
    public interface ILanguageStringResourceService
    {
        Task InsertLanguageStringResourceAsync(LanguageStringResource language);
        Task DeleteLanguageStringResourceAsync(LanguageStringResource language);
        Task UpdateLanguageStringResourceAsync(LanguageStringResource language);
        Task<IList<LanguageStringResource>> GetAllLanguagesStringResourcesAsync();
        Task<LanguageStringResource> GetLanguageStringResourceByIdAsync(object id);
        Task<LanguageStringResource> GetLanguageResourceByKeyAsync(string key);
    }
}
