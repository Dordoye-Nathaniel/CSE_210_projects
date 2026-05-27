using System;

public class Product
{
    private string _productName;
    private string _productId;
    private double _productPrice;
    private double _productQuantity;

    public string ProductName{get; set;}

    public string ProductId{get; set;}

    public double ProductPrice{get; set;}

    public double ProductQuantity{get; set;}

    public Product(string productName, string productId, double productPrice, double productQuantity)
    {
        ProductName = productName;
        ProductId = productId;
        ProductPrice = productPrice;
        ProductQuantity = productQuantity;
    }
    public double TotalCostOfProduct()
    {
        return ProductPrice * ProductQuantity;
    }
}