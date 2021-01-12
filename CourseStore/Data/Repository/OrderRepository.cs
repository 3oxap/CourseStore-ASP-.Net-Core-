using CourseStore.Data.Interfaces;
using CourseStore.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseStore.Data.Repository
{
    public class OrderRepository : IAllOrders
    {
        private readonly AppDbContent appDbContent;
        private readonly StoreProduct storeProduct;

        public OrderRepository(AppDbContent appDbContent, StoreProduct storeProduct)
        {
            this.appDbContent = appDbContent;
            this.storeProduct = storeProduct;
        }
        public void createOrder(Order order)
        {
            order.orderTime = DateTime.Now;
            appDbContent.order.Add(order);
            appDbContent.SaveChanges();
            var items = storeProduct.listStoreItems;

            foreach(var el in items)
            {
                var orderDetail = new OrderDetail
                {
                    productID = el.product.Id,
                    orderID = order.id,
                    price = el.product.price
                };

                appDbContent.orderDetail.Add(orderDetail);
            }

            appDbContent.SaveChanges();
        }
    }
}
