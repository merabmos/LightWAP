using LightWAP.Core.Domain.Language;
using LightWAP.Services.Localization.Interfaces;
using LightWAP.Web.Areas.Admin.Models.Language;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LightWAP.Web.Areas.Admin.Factories
{
    public class LanguageStringResourceFactory
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
        public async Task<List<LanguageStringResourceModel>> PrepareLanguageStringResourceModelsAsync()
        {
            var languagesResourcesModels = new List<LanguageStringResourceModel>();

            var languagesResources = await _languageStringResourceService.GetAllLanguagesStringResourcesAsync();

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


        public async Task AddLanguageAsync(LanguageStringResourceModel model)
        {
            var languageResource = new LanguageStringResource()
            {
                LanguageId = model.LanguageId,
                ResourceValue = model.ResourceValue,
                ResourceKey = model.ResourceKey
            };

            await _languageStringResourceService.InsertLanguageStringResourceAsync(languageResource);
        }

        #endregion
    }
}
