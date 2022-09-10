using LightWAP.Core.Domain.Language;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LightWAP.Services.Localization.Interfaces
{
    public interface ILanguageService
    {
        Task InsertLanguageAsync(Language language);
        Task DeleteLanguageAsync(Language language);
        Task UpdateLanguageAsync(Language language);
        Task<IList<Language>> GetAllLanguagesAsync(Language language);
    }
}
