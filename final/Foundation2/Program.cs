using System;

namespace OrderingSystem
{
    class Program
    {
        static void Main(string[] args) {
            // Create two customers
            Address customer1Address = new Address("123 Main St", "Provo", "UT", "USA");
            Customer customer1 = new Customer("Jane Smith", customer1Address);

            Address customer2Address = new Address("456 Oak St", "Seoul", "Seoul", "Korea");
            Customer customer2 = new Customer("Bareun Park", customer2Address);

            // Create two orders
            Order order1 = new Order(customer1);
            order1.AddProduct(new Product("Widget", "W1", 1.99, 2));
            order1.AddProduct(new Product("Gizmo", "G1", 2.99, 1));

            Order order2 = new Order(customer2);
            order2.AddProduct(new Product("Thing", "T1", 3.99, 3));
            order2.AddProduct(new Product("Doodad", "D1", 0.99, 4));

            // Display order information
            Console.WriteLine("Order 1:");
            Console.WriteLine($"Packing Label:\n{order1.GetPackingLabel()}");
            Console.WriteLine($"Shipping Label:\n{order1.GetShippingLabel()}");
            Console.WriteLine($"Total Price: {order1.GetTotalPrice():C2}");

            Console.WriteLine("\nOrder 2:");
            Console.WriteLine($"Packing Label:\n{order2.GetPackingLabel()}");
            Console.WriteLine($"Shipping Label:\n{order2.GetShippingLabel()}");
            Console.WriteLine($"Total Price: {order2.GetTotalPrice():C2}");
        }
    }

}