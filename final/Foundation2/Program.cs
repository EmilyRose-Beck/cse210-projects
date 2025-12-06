using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {

        Address address1 = new Address(
            "150 Esquire Dr",
            "Denison",
            "Tx",
            "USA"
        );

        Customer customer1 = new Customer("John Smith", address1);

        List<Product> order1Products = new List<Product>()
        {
            new Product("USB Cable", 11, 4.99f, 13),
            new Product("Laptop Stand", 20, 29.99f, 1),
            new Product("Mouse Pad", 3, 9.99f, 2)
        };

        Order order1 = new Order(customer1, order1Products);

        Console.WriteLine("Order Packing Label:");
        Console.WriteLine(order1.PackingLabel());

        Console.WriteLine("Order Shipping Label:");
        Console.WriteLine(order1.ShippingLabel());

        Console.WriteLine($"Order Total: ${order1.TotalPrice()}\n");



        Address address2 = new Address(
            "55 Dragon Road",
            "Tokyo",
            "Tokyo Prefecture",
            "Japan"
        );

        Customer customer2 = new Customer("Aiko Tanaka", address2);

        List<Product> order2Products = new List<Product>()
        {
            new Product("Art Book", 4952, 19.99f, 1),
            new Product("Brush Set", 55, 14.49f, 2)
        };

        Order order2 = new Order(customer2, order2Products);

        Console.WriteLine("Order Packing Label:");
        Console.WriteLine(order2.PackingLabel());

        Console.WriteLine("Order Shipping Label:");
        Console.WriteLine(order2.ShippingLabel());

        Console.WriteLine($"Order Total: ${order2.TotalPrice()}\n");

    }
}
