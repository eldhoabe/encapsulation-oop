using System;
using System.Collections;
using System.Collections.Generic;

namespace Order_msftTutortial
{
    class Order : IEquatable<Order> , IEnumerable<Order>
    {
        public string OrderNumber { get; private set; }

        public List<string> Items { get; set; }

        public DateTime Date { get; set; }

        public Order(string orderNumber)
        {
            OrderNumber = orderNumber;
        }


        public bool IsValid()
        {
            return Date < DateTime.Now;
        }

       
        public int GetHashCode(Order obj)
        {
            return obj.OrderNumber.GetHashCode();
        }

        public bool Equals(Order other)
        {
            return this.OrderNumber == other.OrderNumber;
        }

        public override bool Equals(object obj)
        {
            var order = obj as Order;
            return order != null && order.OrderNumber.Equals(OrderNumber);
        }

        public override int GetHashCode()
        {
            return OrderNumber.GetHashCode();
        }

        public IEnumerator<Order> GetEnumerator()
        {
            return GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}