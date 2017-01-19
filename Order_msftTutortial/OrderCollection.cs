using System;
using System.Collections;
using System.Collections.Generic;

namespace Order_msftTutortial
{
    class Orders : IEnumerable<Order> 
    {
        private ISet<Order> _orders = new HashSet<Order>();

        public void Add(Order order)
        {
            if (IsValid(order)) 
            {
                _orders.Add(order);
            }
        }

        public IEnumerator<Order> GetEnumerator()
        {
            return _orders.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _orders.GetEnumerator();
        }

        private bool IsValid(Order order)
        {
            if (order == null) return false;
            return order.IsValid();
        }
    }
}
