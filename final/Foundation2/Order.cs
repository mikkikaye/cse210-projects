using System;
public class Order
{
    private List<Product> _products;
    private Customer _customer;
    private int _shippingCost;

    public Order(Customer customer)
    {
        _customer = customer;

        if (customer.InUSA())
        {
            _shippingCost = 5;
        }
        else
        {
            _shippingCost = 35;
        }
        
        _products = new List<Product>();
    }
    public double TotalCost()
    {
        double cost = 0.0;

        foreach (Product product in _products)
        {
            cost += product.CalculateCost();
        }
        cost += _shippingCost;
        
        return cost;
    }
    public void AddProduct(Product newProduct)
    {
        _products.Add(newProduct);
    }
    public string CreatePackingLabel()
    {
        string newPacking = new string("");
        foreach (Product product in _products)
        {
            newPacking = newPacking + product.PackingLabel();
        }
        return newPacking;
    }
    public string CreateShippingLabel()
    {
        
        return _customer.ShippingLabel();
    }


}