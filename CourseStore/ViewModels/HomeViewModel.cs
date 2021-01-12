using CourseStore.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseStore.ViewModels
{
    public class HomeViewModel
    { 
        public IEnumerable<Product> favProducr { get; set; }
    }
}
