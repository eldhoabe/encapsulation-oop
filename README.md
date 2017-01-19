# encapsulation-oop
Exercise of encapsulation and oops

This is a basic example based on the encapsulation and oops tutorial in .net site https://www.microsoft.com/net/tutorials/csharp/getting-started/encapsulation-oop


Example of Poor Encapsulation
A very common example of poor encapsulation is the overuse of properties, especially for collection types. Usually, these types expose a great deal more functionality than any client code should be able to access, which can result in program bugs. Consider the following program, which prints customers and their orders:

    public class Program
    {
      public static void Main()
      {
        var customer1 = new Customer() { Name = "Steve"};
        customer1.Orders.Add(new Order("123"));
        customer1.Orders.Add(new Order("234"));
        customer1.Orders.Add(new Order("345"));

        var customer2= new Customer() { Name = "Eric"};
        customer2.Orders.Add(new Order("100"));
        customer2.Orders.Add(new Order("200"));
        customer2.Orders.Add(new Order("300"));

        var customers = new List<Customer>() { customer1, customer2};

        // print customers
        var orders = new List<Order>();
        foreach (var customer in customers)
        {
            Console.WriteLine(customer.Name);
            Console.WriteLine("Orders:");
            orders = customer.Orders;
            while(orders.Count > 0)
            {
                Console.WriteLine(orders[0].OrderNumber);
                orders.RemoveAt(0); // don't write code like this
            }
         }
         Console.WriteLine($"Customer 1 Order Count: {customer1.Orders.Count}");
         Console.WriteLine($"Customer 2 Order Count: {customer2.Orders.Count}");
       }
     }

     public class Customer
     {
        public string Name { get; set; }
        public List<Order> Orders { get; set;} = new List<Order>();
     }

     public class Order 
     {
       public Order(string orderNumber)
       {
          OrderNumber = orderNumber;
       }
       public string OrderNumber {get; set;}
     }


<h3>Next Steps </h3>

Start with the Customer and Order code shown above. Write a program that demonstrates the following requirements:

1. Customers have a property exposing their historic Orders <br/>
2. Customers expose a method for adding an Order <br/>
3. Trying to add a null Order should do nothing <br/>
4. Trying to add an Order with an existing OrderNumber should replace the existing Order (not add a duplicate) <br/>
5. Orders should expose an OrderDate (which can be read/write) <br/>
6. Trying to add an order with an OrderDate in the future should do nothing <br/>

<h5>When finished, you should have a console application that demonstrates (via Console.WriteLine) that each of these requirements is working correctly.</h5>
