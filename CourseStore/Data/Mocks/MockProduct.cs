using CourseStore.Data.Interfaces;
using CourseStore.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseStore.Data.Mocks
{
    public class MockProduct : IAllProduct
    {
        private readonly IAllCategory _categoryProduct = new MockCategory();
        public IEnumerable<Product> Products {


            get
            {
                return new List<Product>
                {
                    new Product{name="Samsung A50", longDesc="Телефон нового поколения", shortDesc="Новейший телефон способный поддерживать обновление 2020 года ", img="/img/a_samsung_galaxy_a50_4gb_64gb_white_(sm_a505f_ds)_icon.jpg", price=450 ,isFavourite=true, available=true, Category=_categoryProduct.AllCategory.First()},
                    new Product{name="BLUCOME", longDesc="Стильные серьги ", shortDesc="станут изумительной деталью вашего образа", img="/img/Blucome.jpg", price=30,isFavourite=true, available=true, Category=_categoryProduct.AllCategory.Last()},
                    new Product{name="Cердца", longDesc="Большие сережки", shortDesc="Прекрасный подарок для любимого человека", img="/img/Серьги-сердце.jpg", price=60,isFavourite=false, available=true, Category=_categoryProduct.AllCategory.Last()},
                    new Product{name="iphone 11", longDesc="Модель будущего", shortDesc="Телефон с новым дизайном и 5 камерами", img="/img/4_zu_3_Teaser_Apple_iPhone11_Pro.jpg", price=1000,isFavourite=true, available=true, Category=_categoryProduct.AllCategory.First()},
                };
            }
        }
        public IEnumerable<Product> getFavProduct { get ; set; }

        public Product getObjectProduct(int id)
        {
            throw new NotImplementedException();
        }
    }
}
