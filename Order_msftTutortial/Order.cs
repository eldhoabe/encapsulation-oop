using System;
using System.Collections.Generic;

namespace Order_msftTutortial
{
    internal class Order
    {
        public string OrderNumber { get; private set; }


        public List<string> Items { get; set; }

        public DateTime Date
        {

            get;
            set;


        }

        public Order(string orderNumber)
        {
            OrderNumber = orderNumber;
        }


        public bool IsInvalidOrder()
        {
            return Date > DateTime.Now;
        }



    }
}