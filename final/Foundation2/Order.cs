using System;
using System.Collections.Generic;

public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer)
    {
        _products = new List<Product>();
        _customer = customer;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double CalculateTotalPrice()
    {
        double totalPrice = 0;

        // Calcular el costo total de los productos en el pedido
        foreach (Product product in _products)
        {
            totalPrice += product.GetTotalCostProduct();
        }

        // Agregar el costo de envío
        if (_customer.IsInUSA())
        {
            totalPrice += 5; // Costo de envío dentro de EE. UU.
        }
        else
        {
            totalPrice += 35; // Costo de envío internacional
        }
        
        return totalPrice;
    }

    public string PackingLabel()
    {
        string label = "Packing Label:\n";
        foreach (Product product in _products)
        {
            label += $"Name: {product.GetNameProduct()}, ID: {product.GetID()}\n";
        }
        return label;
    }

    public string ShippingLabel()
    {
        string label = "Shipping Label:\n";
        label += $"Customer Name: {_customer.GetName()}\n";
        label += _customer.GetAddress().GetAddressDetails();
        return label;
    } 
}
