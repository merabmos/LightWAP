using System;
using System.Collections.Generic;
using System.Text;

namespace LightWAP.Core.Domain.Language
{
    public class Language
    {
        public string Name { get; set; }
        public string LanguageCulture { get; set; }
        public string FlagImageFileName { get; set; }
        public bool Published { get; set; }
        public int DisplayOrder { get; set; }

    }
}
