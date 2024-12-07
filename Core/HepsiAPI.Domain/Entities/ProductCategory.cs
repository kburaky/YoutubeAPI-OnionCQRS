﻿using HepsiAPI.Domain.Common;

namespace HepsiAPI.Domain.Entities
{
    public class ProductCategory : IEntityBase
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public Product Product { get; set; }
        public Category Category { get; set; }
    }
}
