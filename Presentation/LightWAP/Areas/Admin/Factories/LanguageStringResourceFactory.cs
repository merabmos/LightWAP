using LightWAP.Core.Domain.Language;
using LightWAP.Core.Extensions;
using LightWAP.Services.Localization.Interfaces;
using LightWAP.Web.Areas.Admin.Factories.Interfaces;
using LightWAP.Web.Areas.Admin.Models.Language;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LightWAP.Web.Areas.Admin.Factories
{
    public class LanguageStringResourceFactory : ILanguageStringResourceFactory
    {
        #region Properties
        private readonly ILanguageStringResourceService _languageStringResourceService;
        #endregion

        #region Constructor
        public LanguageStringResourceFactory(ILanguageStringResourceService languageStringResourceService)
        {
            _languageStringResourceService = languageStringResourceService;
        }
        #endregion

        #region Method
        public async Task<string> GetResourceValueByKeyAsync(string key)
        {
            var resources = await _languageStringResourceService.GetLanguageResourceByKeyAsync(key);

            if (resources.IsNotNull()) return resources.ResourceValue;
            else return null;
        }
        public async Task<List<LanguageStringResourceModel>> PrepareLanguageStringResourceModelsAsync(int? languageId)
        {
            var languagesResourcesModels = new List<LanguageStringResourceModel>();

            var languagesResources = await _languageStringResourceService.GetAllLanguagesStringResourcesAsync();

            if (languageId.HasValue)
                languagesResources.Where(o => o.LanguageId == languageId.Value);

            foreach (var languageResource in languagesResources)
            {
                var languageResourceModel = new LanguageStringResourceModel()
                {
                    Id = languageResource.Id,
                    LanguageId = languageResource.LanguageId,
                    ResourceKey = languageResource.ResourceKey,
                    ResourceValue = languageResource.ResourceValue
                };

                languagesResourcesModels.Add(languageResourceModel);
            }

            return languagesResourcesModels;
        }

        public async Task<LanguageStringResourceModel> PrepareLanguageStringResourceModelAsync(int Id)
        {
            var languageResource = await _languageStringResourceService.GetLanguageStringResourceByIdAsync(Id);

            var languageResourceModel = new LanguageStringResourceModel()
            {
                Id = languageResource.Id,
                LanguageId = languageResource.LanguageId,
                ResourceKey = languageResource.ResourceKey,
                ResourceValue = languageResource.ResourceValue
            };

            return languageResourceModel;
        }


        public async Task AddLanguageStringResourceAsync(LanguageStringResourceModel model)
        {
            bool exists = (await GetResourceValueByKeyAsync(model.ResourceKey)).IsNotNull();

            if (exists)
            {
                var languageStringResource = await _languageStringResourceService.GetLanguageResourceByKeyAsync(model.ResourceKey);

                if (model.ResourceValue != languageStringResource.ResourceValue)
                {
                    languageStringResource.ResourceValue = model.ResourceValue;
                    await _languageStringResourceService.UpdateLanguageStringResourceAsync(languageStringResource);
                }
            }
            else
            {
                var languageResource = new LanguageStringResource()
                {
                    LanguageId = model.LanguageId,
                    ResourceValue = model.ResourceValue,
                    ResourceKey = model.ResourceKey
                };

                await _languageStringResourceService.InsertLanguageStringResourceAsync(languageResource);
            }

        }

        #endregion
    }
}
