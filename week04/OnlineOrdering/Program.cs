using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        // ============================================================
        // ORDER 1 — Customer in the USA
        // ============================================================
        Address address1 = new Address("123 Main St", "Rexburg", "ID", "USA");
        Customer customer1 = new Customer("John Smith", address1);
        Order order1 = new Order(customer1);

        order1.AddProduct(new Product("Laptop", "P001", 899.99, 1));
        order1.AddProduct(new Product("Wireless Mouse", "P002", 25.50, 2));
        order1.AddProduct(new Product("Mechanical Keyboard", "P003", 45.00, 1));

        // ============================================================
        // ORDER 2 — Customer outside the USA
        // ============================================================
        Address address2 = new Address("456 Maple Ave", "Toronto", "ON", "Canada");
        Customer customer2 = new Customer("Jane Doe", address2);
        Order order2 = new Order(customer2);

        order2.AddProduct(new Product("Monitor", "P004", 299.99, 2));
        order2.AddProduct(new Product("HDMI Cable", "P005", 12.99, 3));

        // ============================================================
        // DISPLAY ORDER 1
        // ============================================================
        Console.WriteLine("==========================================");
        Console.WriteLine("                 ORDER 1                  ");
        Console.WriteLine("==========================================");
        Console.WriteLine();
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine();
        Console.WriteLine("Total Price: $" + order1.GetTotalCost().ToString("F2", CultureInfo.InvariantCulture));
        Console.WriteLine();

        // ============================================================
        // DISPLAY ORDER 2
        // ============================================================
        Console.WriteLine("==========================================");
        Console.WriteLine("                 ORDER 2                  ");
        Console.WriteLine("==========================================");
        Console.WriteLine();
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine();
        Console.WriteLine("Total Price: $" + order2.GetTotalCost().ToString("F2", CultureInfo.InvariantCulture));
        Console.WriteLine();
    }
}