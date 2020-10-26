﻿using System.Collections.Generic;

namespace CrmBL.Model
{
    class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Count { get; set; }

        public ICollection<Sell> Sells { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
