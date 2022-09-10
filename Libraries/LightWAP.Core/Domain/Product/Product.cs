using System;
using System.Collections.Generic;
using System.Text;
using LightWAP.Core.Domain.Category;
namespace LightWAP.Core.Domain.Product
{
    public class Product : BaseEntity
    {
        public int Id { get; set; }
        public int? CategoryId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string ShortDescription { get; set; }
        public string FullDescrtiption { get; set; }
        public DateTime CreatedOnUtc { get; set; }
        public DateTime? UpdatedOnUtc { get; set; }
        public bool Deleted { get; set; }
        public Category.Category Category { get; set; }
        public List<ProductPictureMapping> ProductPictureMappings { get; set; }
    }
}
