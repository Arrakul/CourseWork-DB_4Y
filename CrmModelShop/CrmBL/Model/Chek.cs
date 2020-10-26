using System;
using System.Collections.Generic;

namespace CrmBL.Model
{
    public class Chek
    {
        public int ChekId { get; set; }

        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }

        public int SellerId { get; set; }
        public virtual Seller Seller { get; set; }

        public virtual ICollection<Sell> Sells { get; set; }

        public DateTime Created { get; set; }

        public override string ToString()
        {
            return $"№{ChekId} от {Created.ToString("dd.MM.yy hh:mm:ss")}";
        }
    }
}
