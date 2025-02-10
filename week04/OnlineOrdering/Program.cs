using System;
public class Program
{
    public static void Main(string[] args)
    {
        // Creating some products
        Product product1 = new Product("Air Fryer", 21011, 1500.00, 2);
        Product product2 = new Product("Bucchi Blender", 11025, 1059.00, 3);
        Product product3 = new Product("Apple AirBud", 11023, 118.00, 1);

        // Creating an address for the customer
        Address address1 = new Address("13th Street", "New York", "NY", "USA");
        Address address2 = new Address("345 Cooper Square", "Vancouver", "BC", "Canada");

        // Creating customers
        Customer customer1 = new Customer("Erica Brown", address1);
        Customer customer2 = new Customer("Tom Jones", address2);

        // Creating orders
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(customer2);
        order2.AddProduct(product2);
        order2.AddProduct(product3);

        // Display order details
        Console.WriteLine($"Order 1 Details:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.GetTotalPrice():0.00}\n");

        Console.WriteLine($"Order 2 Details:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.GetTotalPrice():0.00}");
    }
}
