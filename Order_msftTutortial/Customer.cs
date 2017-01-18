using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order_msftTutortial
{
    class Customer
    {
        public string Name { get; set; }

        private List<Order> _orders = new List<Order>();
        public IEnumerable<Order> Orders
        {
            get { return _orders; }
        }


        public Customer(string name)
        {
            Name = name;
        }


        public void AddOrder(Order order)
        {
            if (order == null) return;

            var existingOrder = IsExistingOrder(order);

            if (existingOrder != null)
            {
                existingOrder.Items = order.Items;
            }
            else
                _orders.Add(order);
        }


        private Order IsExistingOrder(Order order)
        {
            return _orders.FirstOrDefault(h => h.OrderNumber == order.OrderNumber);
        }


    }
}
