using LightWAP.Core.Domain.Language;
using LightWAP.Core.Extensions;
using LightWAP.Data.Repository.Interfaces;
using LightWAP.Services.Localization.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
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
        public async Task<LanguageStringResource> GetLanguageResourceByKeyAsync(string key)
        {
            var resources = await _repository.GetAllAsync();
            if (resources.IsNotEmpty())
            {
                return resources?.FirstOrDefault(o => o.ResourceKey == key);
            }
            return null;
        }
        public async Task<List<LanguageStringResource>> GetLanguageResourcesByValueAsync(string value)
        {
            return (await _repository.GetAllAsync()).Where(o => o.ResourceValue.Contains(value)).ToList();
        }

        public async Task<LanguageStringResource> GetLanguageStringResourceByIdAsync(object id)
        {
            return await _repository.GetByIdAsync(id);
        }

        #endregion
    }
}
