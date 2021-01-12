    using CourseStore.Data.Interfaces;
using CourseStore.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseStore.Data.Repository
{
    public class ProductRepository : IAllProduct
    {
        private readonly AppDbContent appDbContent;

        public ProductRepository(AppDbContent appDbContent)
        {
            this.appDbContent = appDbContent;
        }



        public IEnumerable<Product> Products => appDbContent.Products.Include(c=>c.Category);

        public IEnumerable<Product> getFavProduct => appDbContent.Products.Where(p => p.isFavourite == true).Include(c=>c.Category);

        public Product getObjectProduct(int id) => appDbContent.Products.FirstOrDefault(p => p.Id == id);
       
    }
}
