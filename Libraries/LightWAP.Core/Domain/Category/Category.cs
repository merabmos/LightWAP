﻿using System;
using System.Collections.Generic;
using System.Text;
using LightWAP.Core.Domain.Product;

namespace LightWAP.Core.Domain.Category
{
    public class Category : BaseEntity
    {
        public string Name { get; set; }
        public int? SubCategoryId { get; set; }
        public List<Product.Product> Products { get; set; }
    }
}
