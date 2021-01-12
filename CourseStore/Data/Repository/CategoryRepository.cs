using CourseStore.Data.Interfaces;
using CourseStore.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseStore.Data.Repository
{
    public class CategoryRepository : IAllCategory
    {
        private readonly AppDbContent appDbContent;

        public CategoryRepository(AppDbContent appDbContent)
        {
            this.appDbContent = appDbContent;
        }

        public IEnumerable<Category> AllCategory => appDbContent.Categories;
    }
}
