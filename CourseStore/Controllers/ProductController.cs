using CourseStore.Data.Interfaces;
using CourseStore.Data.Models;
using CourseStore.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseStore.Controllers
{
    public class ProductController :Controller
    {
        private readonly IAllProduct _AllProduct;
        private readonly IAllCategory _AllCategory;

        public ProductController(IAllProduct allProduct, IAllCategory allCategory)
        {
            _AllProduct = allProduct;
            _AllCategory = allCategory; 
        }
         [Route("Product/List")]
        [Route("Product/List/{category}")]
        public ViewResult List(string category)
        {
            string _category = category;
            IEnumerable<Product> products=null;
            string productCategory="";
            if(string.IsNullOrEmpty(category))
            {
                products = _AllProduct.Products.OrderBy(i => i.Id);
            }
            else
            {
                if (string.Equals("Smartphone", category, StringComparison.OrdinalIgnoreCase))
                {
                    products = _AllProduct.Products.Where(i => i.Category.Name.Equals("Smartphone")).OrderBy(i => i.Id);
                }
                else
                {
                    if (string.Equals("Accessories", category, StringComparison.OrdinalIgnoreCase))
                    {
                        products = _AllProduct.Products.Where(i => i.Category.Name.Equals("Accessories")).OrderBy(i => i.Id);
                    } 
                }
                productCategory = _category;
            }

            ViewBag.Title = "Product";
            var productObj = new ProductListViewModels
            {
                getAllProduct = products,
                productCategory = productCategory
            }; 

            return View(productObj);
        }
    }
}
