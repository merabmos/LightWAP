using LightWAP.Core.Domain.Language;
using LightWAP.Data.Repository.Interfaces;
using LightWAP.Services.Localization.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LightWAP.Services.Localization
{
    public class LanguageStringResourceService : ILanguageStringResourceService
    {
        #region Properties
        private readonly IRepository<LanguageStringResource> _repository;
        #endregion

        #region Constructor
        public LanguageStringResourceService(IRepository<LanguageStringResource> repository)
        {
            _repository = repository;
        }
        #endregion
        #region Methods
        public async Task InsertLanguageStringResourceAsync(LanguageStringResource language)
        {
            await _repository.InsertAsync(language);
        }
        public async Task UpdateLanguageStringResourceAsync(LanguageStringResource language)
        {
            await _repository.UpdateAsync(language);
        }

        public async Task DeleteLanguageStringResourceAsync(LanguageStringResource language)
        {
            await _repository.DeleteAsync(language);
        }

        public async Task<IList<LanguageStringResource>> GetAllLanguagesStringResourcesAsync()
        {
            return await _repository.GetAllAsync();
        }
        public async Task<LanguageStringResource> GetLanguageStringResourceByIdAsync(object id)
        {
            return await _repository.GetByIdAsync(id);
        }
      
        #endregion
    }
}
