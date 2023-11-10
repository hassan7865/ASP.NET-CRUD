using System;
using System.Collections.Generic;

namespace CrudApi.Models
{
    public partial class Category
    {
        public Category()
        {
            Products = new HashSet<Product>();
        }

        public Guid Categoryid { get; set; }
        public string Categoryname { get; set; } = null!;
        public DateTime Createdat { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
