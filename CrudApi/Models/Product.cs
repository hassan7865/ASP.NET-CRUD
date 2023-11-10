using System;
using System.Collections.Generic;

namespace CrudApi.Models
{
    public partial class Product
    {
        public Guid Productid { get; set; }
        public string Productname { get; set; } = null!;
        public int Price { get; set; }
        public bool Intstock { get; set; }
        public Guid Categoryid { get; set; }
        public DateTime Createdat { get; set; }

        public virtual Category Category { get; set; } = null!;
    }
}
