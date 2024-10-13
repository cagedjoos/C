using System;

class Program
{
    static void Main(string[] args)
    {

        Address address = new Address();
        address.SetAddress("28 Gonzalez Ave");
        address.SetCity("Osseo");
        address.SetStateProvince( "Minnesota");
        address.SetCountry("USA");
        address.SetZipcode("55311");

        Customer customer = new Customer();
        customer.SetName("John Black");
        customer.address = address;

        Product product1 = new Product("Water Bottle", "1a2b3c4d", 5.99, 5);

        Product product2 = new Product("Phone Case", "hi1jk2lm3", 20.00, 4);

        Order order = new Order();
        order.SetCustomer(customer);
        order.AddProduct(product1);
        order.AddProduct(product2);

        order.DisplayShippingLabel();

        order.DisplayPackingList();

        double totalCost = order.GetTotalCost();
        Console.WriteLine($"Total Cost: ${totalCost}");

        Address address2 = new Address();
        address2.SetAddress("5 Tanglewood Rd");
        address2.SetCity("Lake Mary");
        address2.SetStateProvince("Sasketchewan");
        address2.SetCountry("CAN");
        address2.SetZipcode("32746");

        Customer customer2 = new Customer();
        customer2.SetName("Jim Black");
        customer2.address = address2;

        Product product3 = new Product("Rocket", "135791113", 50.58, 3);

        Product product4 = new Product("Rocket Launcher", "24681012", 3.89, 3);

        Order order1 = new Order();
        order1.SetCustomer(customer2);
        order1.AddProduct(product3);
        order1.AddProduct(product4);

        order1.DisplayShippingLabel();

        order1.DisplayPackingList();

        double totalCost1 = order1.GetTotalCost();
        Console.WriteLine($"Total Cost: ${totalCost1}");
    }
}