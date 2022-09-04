using System;
using System.Collections.Generic;
using System.Text;

namespace LightWAP.Core.Domain.Product
{
    public class ProductPictureMapping
    {
        public int Id { get; set; }
        public int? ProductId { get; set; }
        public int? PictureId { get; set; }
        public int DisplayOrder{ get; set; }
        public Product Product { get; set; }
        public Picture.Picture Picture { get; set; }

    }
}
