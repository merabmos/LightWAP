using System;
using System.Collections.Generic;
using System.Text;
using LightWAP.Core.Domain.Language;
using LightWAP.Services.Localization.Interfaces;
using System.Threading.Tasks;
using LightWAP.Data.Repository.Interfaces;

namespace LightWAP.Services.Localization
{
    public class LanguageService : ILanguageService
    {
        #region Properties
        private readonly IRepository<Language> _repository;
        #endregion

        #region Constructor
        public LanguageService(IRepository<Language> repository)
        {
            _repository = repository;
        }
        #endregion

        #region Methods
        public async Task InsertLanguageAsync(Language language)
        {
            await _repository.InsertAsync(language);
        }
        public async Task UpdateLanguageAsync(Language language)
        {
            await _repository.UpdateAsync(language);
        }

        public async Task DeleteLanguageAsync(Language language)
        {
            await _repository.DeleteAsync(language);
        }

        public async Task<IList<Language>> GetAllLanguagesAsync()
        {
            return await _repository.GetAllAsync();
        }
        public async Task<Language> GetLanguageByIdAsync(object id)
        {
            return await _repository.GetByIdAsync(id);
        }

        #endregion

    }
}
