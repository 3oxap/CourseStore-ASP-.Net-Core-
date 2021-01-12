using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseStore.Data.Models
{
    public class StoreProduct
    {
        private readonly AppDbContent appDbContent;

        public StoreProduct(AppDbContent appDbContent)
        {
            this.appDbContent = appDbContent;
        }
        public string storeProductId { get; set; }

        public List<StoreProductItem> listStoreItems { get; set; } 

        public static StoreProduct getProduct(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;
            var context = services.GetService<AppDbContent>();
            string StoreProductId = session.GetString("ProductId") ?? Guid.NewGuid().ToString();

            session.SetString("ProductId", StoreProductId);

            return new StoreProduct(context) { storeProductId = StoreProductId };
        }

        public void AddToProduct(Product product)
        {
            this.appDbContent.StoreProductItems.Add(new StoreProductItem
            {
                ShopProductId = storeProductId,
                product = product,
                price = product.price
            });

            appDbContent.SaveChanges();
        }

        public List<StoreProductItem> getStoreitems()
        {
            return appDbContent.StoreProductItems.Where(c => c.ShopProductId == storeProductId).Include(c => c.product).ToList();
        }

    }
}
