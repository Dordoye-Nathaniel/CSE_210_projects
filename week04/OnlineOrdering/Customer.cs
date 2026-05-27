using System;

public class Customer
{
    private string _customerName;
    private Address _address;

    public string CustomerName{get; set;}

    public Address Address{get; set;}

    public Customer(string customerName, Address address)
    {
        CustomerName =  customerName;
        _address = address;
    }

    public string LiveInUSAOrNot()
    {
        return _address.USAOrNot();
    }
}