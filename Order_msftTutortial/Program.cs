using System;

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


            customer.AddOrderRefactored(order);
            customer.AddOrderRefactored(null);
            customer.AddOrderRefactored(existingOrder);
            customer.AddOrderRefactored(futureOrder);

            var s = new Order("s");

            foreach (var item in s)
            {
                
            }

            foreach (var customerOrder in customer.OrderCollection)
            {
                Console.WriteLine(customerOrder);
            }

            Console.ReadLine();
        }
    }
}
