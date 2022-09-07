using LightWAP.Core.Domain.Language;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace LightWAP.Data.Configuration
{
    public class LanguageStringResourceConfig : IEntityTypeConfiguration<LanguageStringResource>
    {
        public void Configure(EntityTypeBuilder<LanguageStringResource> builder)
        { 
            builder.Property(o => o.ResourceKey).IsRequired();
            builder.Property(o => o.ResourceValue).IsRequired();
            builder.Property(o => o.LanguageId).IsRequired();
        }
    }
}
