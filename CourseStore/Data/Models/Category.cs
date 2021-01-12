using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseStore.Data.Models
{
    public class Category
    {

        public int id { get; set; }
        public string Name { get; set; }
        public string Desc { get; set; }
        public List<Product> Products { get; set; }

    }
}
