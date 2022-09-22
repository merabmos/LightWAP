using LightWAP.Web.Areas.Admin.Factories.Interfaces;
using LightWAP.Web.Areas.Admin.Models.Language;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
namespace LightWAP.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class LanguageController : Controller
    {
        #region Fields
        public readonly ILanguageFactory _languageFactory;
        #endregion

        #region Constructor
        public LanguageController(ILanguageFactory languageFactory)
        {
            _languageFactory = languageFactory;
        }
        #endregion

        #region Methods
        // GET: LanguageController
        public async Task<ActionResult> Index()
        {
            var languages = await _languageFactory.PrepareLanguageModelsAsync();

            if (languages.Count != 0)
            {
                return View(languages);
            }
            else
            {
                return RedirectToAction("Create");
            }
        }

        // GET: LanguageController/Create
        public ActionResult Create()
        {
            LanguageModel languageModel = new LanguageModel();

            return View(languageModel);
        }

        // POST: LanguageController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(LanguageModel model)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            await _languageFactory.AddLanguageAsync(model);
            
            return RedirectToAction("Edit");
        }

        // GET: LanguageController/Edit/5
        public async Task<ActionResult> Edit(int id)
        {

            var model = await _languageFactory.PrepareLanguageModelAsync(id);

            return View(model);
        }

        // POST: LanguageController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: LanguageController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: LanguageController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        #endregion
    }
}
