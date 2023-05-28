using System;
public class Customer
{
    private string _customerName;
    private Address _address;

    public Customer(string customerName, Address address)
    {
        _customerName = customerName;
        _address = address;
    }
    public bool InUSA()
    {
        return _address.IsUSA();
    }
    public string ShippingLabel()
    {
        return ($"{_customerName}:\n{_address.DisplayAddress()}");
    }
}