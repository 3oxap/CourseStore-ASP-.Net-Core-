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
    public class StoreProductController: Controller
    {
        private IAllProduct _productRep;
        private readonly StoreProduct _storeRep;

        public StoreProductController(IAllProduct productRep, StoreProduct storeRep)
        {
            _productRep = productRep;
            _storeRep = storeRep;
        }

        public ViewResult Index()
        { 
            ViewBag.Title = "Basket";
            var items = _storeRep.getStoreitems();
            _storeRep.listStoreItems = items;

            var obj = new StoreProductViewModel
            {
                storeProduct = _storeRep
            };
            return View(obj);
        }

        public RedirectToActionResult addToProduct(int id)
        {
            var item = _productRep.Products.FirstOrDefault(i => i.Id == id);
            if(item!=null)
            {
                _storeRep.AddToProduct(item);
            }
            return RedirectToAction("Index");
        }

         
    }
}
