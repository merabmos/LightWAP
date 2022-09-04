using LightWAP.Core.Domain.Product;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace LightWAP.Data.Configuration
{
    public class ProductConfig : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.Property(o => o.Name).IsRequired();

            builder.Property(o => o.CategoryId).IsRequired(false);

            builder.Property(o => o.Price).HasDefaultValue(0).HasColumnType("decimal(18,4)");

            builder.Property(o => o.CreatedOnUtc).HasColumnType("datetime2(7)").IsRequired();

            builder.Property(o => o.UpdatedOnUtc).HasColumnType("datetime2(7)").IsRequired(false);

            builder.Property(o => o.Deleted).HasDefaultValue(false);

            builder.HasOne(o => o.Category).WithMany(o => o.Products).HasForeignKey("CategoryId").OnDelete(DeleteBehavior.Restrict);
        }
    }
}
