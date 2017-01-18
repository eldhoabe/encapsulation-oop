using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order_msftTutortial
{
    class Program
    {
        static void Main(string[] args)
        {
            var order = new Order("123")
            {
                Date = DateTime.Now,
            };


            var existingOrder = new Order("123")
            {
                Date = DateTime.Now.AddDays(-2),
            };

            var futureOrder = new Order("123")
            {
                Date = DateTime.Now.AddDays(2),
            };




            var customer = new Customer("Eldho");
            customer.AddOrder(order);
            customer.AddOrder(null);
            customer.AddOrder(existingOrder);
            customer.AddOrder(futureOrder);


            foreach (Order customerOrder in customer.Orders)
            {
                Console.WriteLine(customerOrder.OrderNumber);
            }

            Console.ReadLine();
        }
    }
}
