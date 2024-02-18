using System;
using System.Formats.Asn1;

class Program
{
    static void Main(string[] args)
    {
        // Crear direcciones
        Address address1 = new Address("123 Main St", "Anytown", "CA", "USA");
        Address address2 = new Address("456 Elm St", "Othertown", "NY", "USA");
        Address address3 = new Address("Ezequiel 18", "GAM", "CDMX", "Mexico");

        // Crear clientes
        Customer customer1 = new Customer("John Doe", address1);
        Customer customer2 = new Customer("Jane Smith", address2);
        Customer customer3 = new Customer("Eduardo Rodriguez", address3);

        // Crear productos
        Product product1 = new Product("Widget", 1, 10.99, 2);
        Product product2 = new Product("Gadget", 2, 19.99, 1);
        Product product3 = new Product("Thingamajig", 3, 7.49, 3);
        Product product4 = new Product("Cellphone", 4, 23.45, 2);

        // Crear órdenes
        Order order1 = new Order(customer1);
        Order order2 = new Order(customer2);
        Order order3 = new Order(customer3);

        // Agregar productos a las órdenes
        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product4);

        order2.AddProduct(product2);
        order2.AddProduct(product3);
        order2.AddProduct(product4);

        order3.AddProduct(product1);
        order3.AddProduct(product2);
        order3.AddProduct(product4);

        // Mostrar etiquetas de embalaje y etiquetas de envío para las órdenes
        Console.WriteLine("Order 1:");
        Console.WriteLine(order1.PackingLabel());
        Console.WriteLine(order1.ShippingLabel());
        Console.WriteLine("Total Price: $" + order1.CalculateTotalPrice());

        Console.WriteLine();

        Console.WriteLine("Order 2:");
        Console.WriteLine(order2.PackingLabel());
        Console.WriteLine(order2.ShippingLabel());
        Console.WriteLine("Total Price: $" + order2.CalculateTotalPrice());

        Console.WriteLine();

        Console.WriteLine("Order 3:");
        Console.WriteLine(order3.PackingLabel());
        Console.WriteLine(order3.ShippingLabel());
        Console.WriteLine("Total Price: $" + order3.CalculateTotalPrice());
    }
}
