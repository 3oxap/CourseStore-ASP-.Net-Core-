using CourseStore.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseStore.Data.Interfaces
{
    public interface IAllCategory
    {
        IEnumerable<Category> AllCategory { get; }
    }
}
