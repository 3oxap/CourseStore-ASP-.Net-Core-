using CourseStore.Data.Interfaces;
using CourseStore.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseStore.Data.Mocks
{
    public class MockCategory : IAllCategory
    {
        public IEnumerable<Category> AllCategory
        {
            get
            {
                return new List<Category> {
                    new Category{Name="Smartphone", Desc="modern phones"},
                    new Category{Name="Accessories", Desc="body jewelry"}
                };
            }
        }
    }
}
