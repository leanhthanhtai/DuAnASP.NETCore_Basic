
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCore.Data.Entities
{
    public class Product
    {   
        public int Id { get; set; }
        public decimal Price { get; set; }
        public decimal OriginalPrice { get; set; }
        public int ViewCount { get; set; }
        public int Stock { get; set; }
        public DateTime CreatedDate { get; set; }
        public string SeoAlias { get; set; }
        public bool? IsFeatured { get; set; }


        public List<OrderDetail> OrderDetails { get; set; }

        public List<Cart> Carts { get; set; }

        public List<ProductTranslation> ProductTranslations { get; set; }

        public List<ProductImage> ProductImages { get; set; }
        public virtual List<ProductInCategory> ProductInCategories { get; set; }

    }
}
