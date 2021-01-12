using CourseStore.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseStore.Data.Interfaces
{
    public interface INewProduct
    {
        void CreatProduct(Product product,string way);
    }
}
