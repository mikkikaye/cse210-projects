using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<List<string>> customerList = new List<List<string>>();
        List<string> customer1 = new List<string>(){"Bill", "945 E 956 N", "American Fork", "Utah", "USA"};
        customerList.Add(customer1);
        List<string> customer2 = new List<string>(){"Stacey", "945 E 956 N", "Calgary", "Alberta", "Canada"};
        customerList.Add(customer2);

        List<List<string>> productList = new List<List<string>>();
        List<string> product1 = new List<string>(){"string cheese", "(#01)", "8.59", "1"};
        productList.Add(product1);
        List<string> product2 = new List<string>(){"bagel", "(#02)", "1.02", "6"};
        productList.Add(product2);
        List<string> product3 = new List<string>(){"Diet Coke", "(#03)", "11.58", "2"};
        productList.Add(product3);
        List<string> product4 = new List<string>(){"ice cream", "(#04)", "5.98", "1"};
        productList.Add(product4);

        List<Order> orderList = new List<Order>();

        int h = 0;
        for (int i = 0; i < 2; i++)
        {
            Address address = new Address(customerList[i][1], customerList[i][2], customerList[i][3], customerList[i][4]);
            Customer customer = new Customer(customerList[i][0], address);
            Order order = new Order(customer);
            orderList.Add(order);

            for (int j= 0; j < 2; j++)
            {
                Product product = new Product(productList[h][0], productList[h][1], double.Parse(productList[h][2]));
                product.SetQuantity(int.Parse(productList[h][3]));
                order.AddProduct(product);
                h++;
            }
        }
        foreach (Order order in orderList)
        {
            Console.WriteLine($"Customer's Order:\n--------------------------------\n{order.CreatePackingLabel()}");
            Console.WriteLine($"Customer's Shipping Label:\n--------------------------------\n{order.CreateShippingLabel()}");
            Console.WriteLine($"Total Cost: ${order.TotalCost()}\n\n");
        }

    }
}