using System;
using System.Collections.Generic;
using System.Text;

namespace LightWAP.Core.Domain.Language
{
    public class Language : BaseEntity
    {
        public string Name { get; set; }
        public string LanguageCulture { get; set; }
        public string FlagImageFileName { get; set; }
        public bool Published { get; set; }
        public int DisplayOrder { get; set; }

        /// <summary>
        /// Gets or Sets a value indicating whether the language supports "Right-to-left"
        /// </summary>
        public bool Rtl { get; set; }
        public List<LanguageStringResource> LanguageStringResources { get; set; }

    }
}
