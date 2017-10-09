using ShopManageContact;
using System;
using System.Collections.Generic;

namespace ShopManageServices
{
    public class OrderService
    {
        public List<Order> GetOrderList()
        {
            var list = new List<Order>();
            for (int i = 0; i < 100; i++)
            {
                var order = new Order();
                order.Id = i;
                order.MemberId = 10 + i;
                order.MemberName = "test" + i;
                order.OrderAmount = 100 + i;
                order.OrderDate = DateTime.Now;
                list.Add(order);
            }
            return list;
        }
    }
}
