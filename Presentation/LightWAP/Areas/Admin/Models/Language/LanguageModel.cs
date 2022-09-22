using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LightWAP.Web.Areas.Admin.Models.Language
{
    public class LanguageModel : BaseModel
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string LanguageCulture { get; set; }

        [Required]
        public string FlagImageFileName { get; set; }
        public bool Published { get; set; }
        public int DisplayOrder { get; set; }
        public bool Rtl { get; set; }
        public List<LanguageStringResourceModel> LanguageStringResources { get; set; }

    }
   
}
