using LightWAP.Core.Domain.Language;
using LightWAP.Services.Localization.Interfaces;
using LightWAP.Web.Areas.Admin.Factories.Interfaces;
using LightWAP.Web.Areas.Admin.Models.Language;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LightWAP.Web.Areas.Admin.Factories
{
    public class LanguageFactory : ILanguageFactory
    {
        #region Properties
        private readonly ILanguageService _languageService;
        #endregion

        #region Constructor
        public LanguageFactory(ILanguageService languageService)
        {
            _languageService = languageService;
        }

        #endregion

        #region Methods
        public async Task<List<LanguageModel>> PrepareLanguageModelsAsync()
        {
            var languageModels = new List<LanguageModel>();

            var languages = await _languageService.GetAllLanguagesAsync();

            foreach (var language in languages)
            {
                var languageModel = new LanguageModel()
                {
                    Id = language.Id,
                    Name = language.Name,
                    DisplayOrder = language.DisplayOrder,
                    Published = language.Published,
                    FlagImageFileName = language.FlagImageFileName,
                    LanguageCulture = language.LanguageCulture,
                    Rtl = language.Rtl
                };

                languageModels.Add(languageModel);
            }

            return languageModels;
        }

        public async Task<LanguageModel> PrepareLanguageModelAsync(int Id)
        {

            var language = await _languageService.GetLanguageByIdAsync(Id);

            var languageModel = new LanguageModel()
            {
                Id = language.Id,
                Name = language.Name,
                DisplayOrder = language.DisplayOrder,
                Published = language.Published,
                FlagImageFileName = language.FlagImageFileName,
                LanguageCulture = language.LanguageCulture,
                Rtl = language.Rtl
            };


            return languageModel;
        }


        public async Task AddLanguageAsync(LanguageModel model)
        {
            var language = new Language()
            {
                Name = model.Name,
                DisplayOrder = model.DisplayOrder,
                Published = model.Published,
                FlagImageFileName = model.FlagImageFileName,
                LanguageCulture = model.LanguageCulture,
                Rtl = model.Rtl
            };

            await _languageService.InsertLanguageAsync(language);
        }

        #endregion
    }
}
