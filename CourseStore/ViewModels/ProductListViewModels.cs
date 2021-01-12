using CourseStore.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseStore.ViewModels
{
    public class ProductListViewModels
    {
        public IEnumerable<Product> getAllProduct { get; set; }

        public string productCategory { get; set;  }
    }
}
