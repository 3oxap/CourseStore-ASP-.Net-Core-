using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseStore.Data.Models
{
    public class OrderDetails
    {
        public int id { get; set; }
        public int orderId { get; set; }
        public int productId { get; set; }
        public uint price { get; set; }
        public virtual Product product { get; set; }
        public virtual Orders order { get; set; }

    }
}
