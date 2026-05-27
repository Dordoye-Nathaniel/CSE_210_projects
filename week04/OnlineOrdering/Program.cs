using System;

class Program
{
    static void Main(string[] args)
    {
        Address address = new Address ("Real Avenue", "NewYork", "NewYork", "USA");
        Product product = new Product ("Shoe", "243-456", 24.00, 5.00);
        Product product2 = new Product ("kettle", "242-456", 14.00, 4.00);
        Product product3 = new Product ("Shoe", "244-456", 2.00, 3.00);
        List <Product> products = new List<Product>{
            product, 
            product2, 
            product3};
        Customer customer = new Customer("Nathaniel", address);
        Order order = new Order(customer,products);

        System.Console.WriteLine($"Shipping label:\n{order.ShippingLabel()}\n");
        System.Console.WriteLine($"Packing label:\n{order.PackingLabel()}");
        System.Console.WriteLine($"Total cost plus shipping:{order.TotalCostPlusShipping()}$");
        

    }
}