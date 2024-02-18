using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

public class Product
{
    private string _nameProduct;
    private int _productID;
    private double _price;
    private int _quantity;

    public Product(string nameProduct, int productID, double price, int quantity)
    {
        _nameProduct = nameProduct;
        _productID = productID;
        _price = price;
        _quantity = quantity;
    }

    public string GetNameProduct()
    {
        return _nameProduct;
    }

    public int GetID()
    {
        return _productID;
    }

    public double GetPrice()
    {
        return _price;
    }

    public int GetQuantity()
    {
        return _quantity;
    }

    public double GetTotalCostProduct()
    {
        return _price * _quantity;
    }
}
