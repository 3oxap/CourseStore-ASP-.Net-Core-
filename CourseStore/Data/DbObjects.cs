using CourseStore.Data.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseStore.Data
{
    public class DbObjects
    {
        public static void Initial(AppDbContent content)
        {
           

            if (!content.Categories.Any())
                content.Categories.AddRange(Categories.Select(c=>c.Value));

            if (!content.Products.Any())
            {
                content.AddRange(
                    new Product { name = "Samsung A50", longDesc = "Телефон нового поколения", shortDesc = "Новейший телефон способный поддерживать обновление 2020 года ", img = "/img/a_samsung_galaxy_a50_4gb_64gb_white_(sm_a505f_ds)_icon.jpg", price = 450, isFavourite = true, available = true, Category = Categories["Smartphone"] },
                    new Product { name = "BLUCOME", longDesc = "Стильные серьги ", shortDesc = "станут изумительной деталью вашего образа", img = "/img/Blucome.jpg", price = 30, isFavourite = true, available = true, Category = Categories["Accessories"] },
                    new Product { name = "Cердца", longDesc = "Большие сережки", shortDesc = "Прекрасный подарок для любимого человека", img = "/img/Серьги-сердце.jpg", price = 60, isFavourite = false, available = true, Category = Categories["Accessories"]  },
                    new Product { name = "iphone 11", longDesc = "Модель будущего", shortDesc = "Телефон с новым дизайном и 5 камерами", img = "/img/4_zu_3_Teaser_Apple_iPhone11_Pro.jpg", price = 1000, isFavourite = true, available = true, Category = Categories["Smartphone"] }
                     ) ;
            }

            content.SaveChanges(); 
        }


        private static Dictionary<string, Category> category;
        public static Dictionary<string, Category> Categories
        {
            get
            {
                if (category == null)
                {
                    var list = new Category[]
                    {
                          new Category{Name="Smartphone", Desc="modern phones"},
                          new Category{Name="Accessories", Desc="body jewelry"}
                    };

                    category = new Dictionary<string, Category>();
                    foreach (Category el in list)
                        category.Add(el.Name, el);
                }
                return category;
            }
        }
    }
}
