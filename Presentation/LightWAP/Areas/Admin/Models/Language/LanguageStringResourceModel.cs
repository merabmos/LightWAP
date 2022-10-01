using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LightWAP.Web.Areas.Admin.Models.Language
{
    public class LanguageStringResourceModel : BaseModel
    {
        public int LanguageId { get; set; }
        public string ResourceKey { get; set; }
        public string ResourceValue { get; set; }
    }
}
