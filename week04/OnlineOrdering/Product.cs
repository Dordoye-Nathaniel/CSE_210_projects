using System;

public class Product
{
    private string _productName;
    private string _productId;
    private double _productPrice;
    private double _productQuantity;

    public string ProductName
    {
        get {return _productName;}
        set{_productName = value;}
    }

    public string ProductId
    {
        get {return _productId;}
        set {_productId = value;}
    }

    public double ProductPrice
    {
        get {return _productPrice;}
        set {_productPrice = value;}
    }

    public double ProductQuantity
    {
        get {return _productQuantity;}
        set {_productQuantity = value;}
    }

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