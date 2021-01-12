using CourseStore.Data.Interfaces;
using CourseStore.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Hosting;
using System.IO;

namespace CourseStore.Controllers
{

    public class NewProductController:Controller
    {
        private readonly INewProduct _newProduct;
        private readonly IWebHostEnvironment _webHost;

        public NewProductController(INewProduct newProduct, IWebHostEnvironment webHost)
        {
            _newProduct = newProduct;
            _webHost = webHost;
        }

        public IActionResult NewProduct()
        {
            return View();
        }
        [HttpPost]
        public IActionResult NewProduct(Product product, IFormFile imgfile)
        {
            var saveimg = Path.Combine(_webHost.WebRootPath, "img", imgfile.FileName);
            string imgText = "/img/"+imgfile.FileName;
            using (var uploidImg = new FileStream(saveimg, FileMode.Create))
            {
                imgfile.CopyTo(uploidImg);
            }

            if (ModelState.IsValid)
            {
                _newProduct.CreatProduct(product, imgText);
                return RedirectToAction("Complete");
            }
            return View(product);
        }

        public IActionResult Complete()
        {
            return View();
        }
    }
}
