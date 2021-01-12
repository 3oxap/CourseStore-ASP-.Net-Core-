using CourseStore.Data.Interfaces;
using CourseStore.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace CourseStore.Data.Repository
{
    public class NewProductRepository : INewProduct
    {
        private readonly AppDbContent appDbContent;

        public NewProductRepository(AppDbContent appDbContent)
        {
            this.appDbContent = appDbContent;
           
        }
        public void CreatProduct(Product product, string Way)
        {


            var newProduct = new Product
            {
                name = product.name,
                shortDesc = product.shortDesc,
                longDesc = product.longDesc,
                img = Way,
                price = product.price,
                isFavourite = product.isFavourite,
                available = product.available,
                categoryID=product.categoryID
            };
            appDbContent.Products.Add(newProduct);
            appDbContent.SaveChanges();
        }
    }
}
