using LightWAP.Core.Domain.Language;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace LightWAP.Data.Configuration
{
    public class LanguageConfig : IEntityTypeConfiguration<Language>
    {
        public void Configure(EntityTypeBuilder<Language> builder)
        {
            builder.Property(o => o.LanguageCulture).IsRequired();
            builder.Property(o => o.DisplayOrder).IsRequired().HasDefaultValue(1);
            builder.Property(o => o.FlagImageFileName).IsRequired();
            builder.Property(o => o.Published).IsRequired().HasDefaultValue(true);
            builder.Property(o => o.Name).IsRequired();
            builder.HasMany(o => o.LanguageStringResources).WithOne(o => o.Language).HasForeignKey(o => o.LanguageId).OnDelete(DeleteBehavior.Cascade);
            builder.Property(o => o.Rtl).IsRequired().HasDefaultValue(false);
        }
    }
}
