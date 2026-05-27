using System;
using System.Reflection.Metadata.Ecma335;

public class Order
{
    List <Product> _product = new List<Product>();
    private Customer _customer;

    private const int _shippingCostUSA = 5;
    private const int _shippingCostNotUSA = 35;

    public Order(Customer customer, List<Product> products)
    {
        Customer = customer;
        Product = products;
    }

    public Customer Customer { get{return _customer;} set{_customer = value;}}

    public List<Product> Product {get{return _product;} set{_product = value;}}

    public string PackingLabel()
    {
        string label = "";
        foreach(var product in _product)
        {
            label += $"Product name:{product.ProductName}--Product ID:{product.ProductId}\n";
        }
        return label;
    }

    public string ShippingLabel()
    {
        return $"Customer name:{_customer.CustomerName}\n{_customer.Address.AllFields()}";
    }

    public double TotalCostPlusShipping()
    {
        double totCost = 0;
        foreach(var product in _product)
        {
            totCost += product.TotalCostOfProduct();
        }

        if (_customer.LiveInUSAOrNot() == "USA")
        {
            totCost += _shippingCostUSA; 
                
        }
        else
        {
            totCost += _shippingCostNotUSA; 
        }

        return totCost;
    }

   
}