using CourseStore.Data.Interfaces;
using CourseStore.Data.Models;
using CourseStore.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace CourseStore.Controllers
{
    public class HomeController:Controller
    {
        private IAllProduct _productRep;
      

        public HomeController(IAllProduct productRep)
        {
            _productRep = productRep;
          
        }

        public ViewResult Index()
        {
           
            var homeProduct = new HomeViewModel
            {
                favProducr = _productRep.getFavProduct
            };
            ViewBag.Title = "Home";
            return View(homeProduct); 
        }
    }
}
