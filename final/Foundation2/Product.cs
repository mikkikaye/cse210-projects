using System;
public class Product
{
    private string _productName;
    private string _productID;
    private double _price;
    private int _quantity;
    public Product(string productName, string productID, double price)
    {
        _productName = productName;
        _productID = productID;
        _price = price;
        _quantity = 0;
    }
    public double CalculateCost()
    {
        double cost = _price * _quantity;
        return cost;
    }
    public void SetQuantity(int quantity)
    {
        _quantity = quantity;
    }
    public string PackingLabel()
    {
        return ($"{_productName} {_productID}: {_quantity} @ {_price}\n");
    }
}