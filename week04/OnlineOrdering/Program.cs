using System;

class Program
{
    static void Main(string[] args)
    {
       
        //Create Addresses
            Address address1 = new Address("5630 Kincaid Street", "Burnaby", "BC", "Canada");
            Address address2 = new Address("3614 Maple Drive", "Maple Ridge", "BC", "Canada");

            //Create Customers
            Customer customer1 = new Customer("Donna Ronson", address1);
            Customer customer2 = new Customer("Peggy Wong", address2);

            //Create Orders
            Order order1 = new Order(customer1);
            Order order2 = new Order(customer2);

            //Create and Add Products to Order 1
            order1.AddProduct(new Product("Cloud Kickers 2.0", "J1539", 999.99, 1));
            order1.AddProduct(new Product("Shoe Polish", "P1002", 25.50, 2));

            //Create and Add Products to Order 2
            order2.AddProduct(new Product("Monitor", "X2001", 199.99, 1));
            order2.AddProduct(new Product("Keyboard", "X2002", 49.99, 1));
            order2.AddProduct(new Product("USB-C Cable", "X2003", 9.99, 3));

            //Display Order Information
            Console.WriteLine(order1.GetPackingLabel());
            Console.WriteLine(order1.GetShippingLabel());
            Console.WriteLine($"Total Price: {order1.GetTotalPrice():C}\n");

            Console.WriteLine(order2.GetPackingLabel());
            Console.WriteLine(order2.GetShippingLabel());
            Console.WriteLine($"Total Price: {order2.GetTotalPrice():C}\n");

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
    }
}