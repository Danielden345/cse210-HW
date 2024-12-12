using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation2 World!");
        
        List<Product> products = new List<Product>{
            new Product("carrots", 2135, 6, 4),
            new Product("bananas", 6453, 2, 5)
        };
        Address address1 = new Address("2895 E. Cathy Dr.", "Gilbert", "Az", "US");
        Customer customer = new Customer("Jeremy Fischer", address1);
        Order order1 = new Order(customer, products);

        Console.WriteLine(order1.getPackingLabel());
        Console.WriteLine(order1.getShippingLabel());
        Console.WriteLine($"Total Cost: {order1.calculateCost()}");
        Console.WriteLine($"Shipping Cost: {order1.calculateShippingCost()}\n");
        
        List<Product> product2 = new List<Product>{
            new Product("apples", 5456, 5, 15),
            new Product("lettuce", 6453, 23, 5)
        };
        Address address2 = new Address("5685 S. Arquepia", "Chimbote", "Ancash", "Peru");
        Customer customer2 = new Customer("Jose Miranda", address2);
        Order order2 = new Order(customer2, product2);
        Console.WriteLine(order2.getPackingLabel());
        Console.WriteLine(order2.getShippingLabel());
        Console.WriteLine($"Total Cost: {order2.calculateCost()}");
        Console.WriteLine($"Shipping Cost: {order2.calculateShippingCost()}");
    }
}