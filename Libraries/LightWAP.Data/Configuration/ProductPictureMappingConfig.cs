using LightWAP.Core.Domain.Product;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace LightWAP.Data.Configuration
{
    public class ProductPictureMappingConfig : IEntityTypeConfiguration<ProductPictureMapping>
    {
        public void Configure(EntityTypeBuilder<ProductPictureMapping> builder)
        {
            builder.HasOne(o => o.Product).WithMany(o => o.ProductPictureMappings).HasForeignKey(o => o.ProductId).OnDelete(DeleteBehavior.Cascade);
            
            builder.HasOne(o => o.Picture).WithMany(o => o.ProductPictureMappings).HasForeignKey(o => o.PictureId).OnDelete(DeleteBehavior.Cascade);

            builder.Property(o => o.DisplayOrder).HasDefaultValue(1);

            builder.ToTable("Product_Picture_Mappings");

        }
    }
}
