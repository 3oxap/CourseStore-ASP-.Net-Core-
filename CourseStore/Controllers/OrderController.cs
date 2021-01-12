using CourseStore.Data.Interfaces;
using CourseStore.Data.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseStore.Controllers
{
    public class OrderController:Controller
    {
        private readonly IAllOrders allOrders;
        private readonly StoreProduct storeProduct;

        public OrderController(IAllOrders allOrders, StoreProduct storeProduct)
        {
            this.allOrders = allOrders;
            this.storeProduct = storeProduct;
        }

        public IActionResult Checkout()
        {
            return View(); 
        }


        [HttpPost]
        public IActionResult Checkout(Order order)
        {
            storeProduct.listStoreItems = storeProduct.getStoreitems();

            if (storeProduct.listStoreItems.Count == 0)
            {
                ModelState.AddModelError("", "0 items in the cart");
            }

            if (ModelState.IsValid)
            {
                allOrders.createOrder(order);
                return RedirectToAction("Complete");
            }
                
            return View(order);
        }

        public IActionResult Complete()
        {
            ViewBag.Message = "Order processed successfully";
            return View();
        }

    }
}
