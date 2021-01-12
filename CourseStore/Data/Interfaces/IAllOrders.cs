using CourseStore.Data.Models;
using CourseStore.Migrations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseStore.Data.Interfaces
{
    public interface IAllOrders
    {
        void createOrder(Order order);
    }
}
