using System;
using System.Collections.Generic;

public class Order
{
    private List<Product> products;
    private Customer customer;
    private const double shippingCostUSA = 5.0;
    private const double shippingCostInternational = 35.0;

    public Order(Customer customer, List<Product> products)
    {
        this.customer = customer;
        this.products = products;
    }

    public double GetTotalPrice()
    {
        double totalProductPrice = 0;
        foreach (var product in products)
        {
            totalProductPrice += product.GetTotalPrice();
        }

        double shippingCost = customer.IsInUSA() ? shippingCostUSA : shippingCostInternational;
        return totalProductPrice + shippingCost;
    }

    public string GetPackingLabel()
    {
        string label = "";
        foreach (var product in products)
        {
            label += product.GetLabel() + "\n";
        }
        return label;
    }

    public string GetShippingLabel()
    {
        return customer.GetShippingLabel();
    }
}
