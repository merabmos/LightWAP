using System;
using System.Collections.Generic;
using System.Text;

namespace LightWAP.Core.Domain.Language
{
    public class LanguageStringResource : BaseEntity
    {
        public int Id { get; set; }
        public int LanguageId { get; set; }
        public string ResourceKey { get; set; }
        public string ResourceValue { get; set; }
        public Language Language { get; set; }
    }
}
