using LightWAP.Core.Domain.Category;
using LightWAP.Core.Domain.Customer;
using LightWAP.Core.Domain.Picture;
using LightWAP.Core.Domain.Product;
using LightWAP.Data.Configuration;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;

namespace LightWAP.Data
{
    public partial class LightWAPDBContext : IdentityDbContext<Customer>
    {
        public LightWAPDBContext(DbContextOptions<LightWAPDBContext> options) : base(options)
        {

        }

        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Category> Categories { get; set; }

        public virtual DbSet<ProductPictureMapping>  ProductPictureMappings { get; set; }
        public virtual DbSet<Picture> Pictures { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.HasAnnotation("Relational:Collation", "Cyrillic_General_CI_AS");

            modelBuilder.ApplyConfiguration(new ProductConfig());
            modelBuilder.ApplyConfiguration(new CategoryConfig());
            modelBuilder.ApplyConfiguration(new ProductPictureMappingConfig());

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
