using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public Address GetAddress()
    {
        return _address;
    }

    public string GetName()
    {
        return _name;
    }

    public void SetName(string name)
    {
        _name = name;
    }

    public bool IsInUSA()
    {
        return _address.IsInUSA();
    }
}