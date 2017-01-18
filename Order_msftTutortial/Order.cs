using System;
using System.Collections.Generic;

namespace Order_msftTutortial
{
    internal class Order
    {
        public string OrderNumber { get; set; }


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


        

    }
}