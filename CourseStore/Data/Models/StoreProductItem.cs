using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseStore.Data.Models
{
    public class StoreProductItem
    {
        public int id { get; set; }
        public Product product { get; set; }
        public int price { get; set; }

        public string ShopProductId { get; set; }
    }
}
