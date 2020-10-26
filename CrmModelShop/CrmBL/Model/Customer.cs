using System.Collections.Generic;

namespace CrmBL.Model
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Chek> Cheks { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
