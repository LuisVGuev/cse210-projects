using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        //Address
        Address address1 = new Address("123 Main St", "Manhatan", "NY", "USA");
        Address address2 = new Address("456 Oak Ave", "Francias", "ON", "Paria");

        //Customer
        Customer customer1 = new Customer("Josep Pain", address1);
        Customer customer2 = new Customer("Karelys James", address2);

        //Data Products
        Product product1 = new Product("Laptop", 101, 999.99, 1);
        Product product2 = new Product("Mouse", 102, 25.50, 2);
        Product product3 = new Product("Keyboard", 103, 50.75, 1);

        //List Products
        List<Product> products1 = new List<Product> { product1, product2 };
        List<Product> products2 = new List<Product> { product2, product3 };
        Order order1 = new Order(customer1, products1);
        Order order2 = new Order(customer2, products2);

        //Orders
        Console.WriteLine("Order 1:");
        Console.WriteLine("Packing Label:\n" + order1.GetPackingLabel());
        Console.WriteLine("Shipping Label:\n" + order1.GetShippingLabel());
        Console.WriteLine("Total Price: $" + order1.GetTotalPrice() + "\n");

        Console.WriteLine("Order 2:");
        Console.WriteLine("Packing Label:\n" + order2.GetPackingLabel());
        Console.WriteLine("Shipping Label:\n" + order2.GetShippingLabel());
        Console.WriteLine("Total Price: $" + order2.GetTotalPrice());
    }
}
