using System;

public class Customer
{
    private string _customerName;
    private Address _address;

    public string CustomerName{ get{return _customerName;} set{_customerName = value;}}

    public Address Address{get{return _address;} set{_address = value;}}

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