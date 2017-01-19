using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order_msftTutortial
{
    class Customer
    {
        public string Name { get; private set; }

        private List<Order> _orders = new List<Order>();
        public IEnumerable<Order> Orders
        {
            get { return _orders; }
        }

        public  Orders OrderCollection { get; set; }
        


        public Customer(string name)
        {
            Name = name;
            OrderCollection = new Orders();
        }


        /// <summary>
        /// Before refactoring add order method
        /// </summary>
        /// <param name="order"></param>
        public void AddOrder(Order order)
        {
            if (order == null) return;
            if (order.IsValid()) return;


            var existingOrder = IsExistingOrder(order);

            if (existingOrder != null)
            {
                existingOrder.Items = order.Items;
            }
            else

                _orders.Add(order);
        }


        /// <summary>
        /// Add order method after refactoring
        /// </summary>
        /// <param name="order">The order</param>
        public void AddOrderRefactored(Order order)
        {
            OrderCollection.Add(order);
        }


        #region Private methods before refactoring
        private Order IsExistingOrder(Order order)
        {
            return _orders.FirstOrDefault(h => h.OrderNumber == order.OrderNumber);
        }


        private bool IsInvalidOrder(Order order)
        {
            return order.Date > DateTime.Now;
        }

        #endregion

    }
}
