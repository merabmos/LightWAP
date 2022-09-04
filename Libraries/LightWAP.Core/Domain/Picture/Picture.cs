using LightWAP.Core.Domain.Product;
using System;
using System.Collections.Generic;
using System.Text;

namespace LightWAP.Core.Domain.Picture
{
    public class Picture
    {
        public int Id { get; set; }
        public string FileLocation { get; set; }
        public string FileName { get; set; }
        public List<ProductPictureMapping> ProductPictureMappings { get; set; }
    }
}
