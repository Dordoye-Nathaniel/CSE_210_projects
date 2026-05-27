using System;

public class Address
{
    private string _streetAddress;
    private string _city;
    private string _state;
    private string _country;

    public string StreetAddress{ get; set;}
    public string City{ get; set;}

    public string State{get; set;}

    public string Country{get; set;}

    public Address(string streetAddress, string city, string state, string country)
    {
        StreetAddress = streetAddress;
        City = city;
        State = state;
        Country = country;
    }

    public string USAOrNot()
    {
        if(Country == "USA")
        {
            return "USA";
        }
        else
        {
            return "Not USA";
        }
    }

    public string AllFields()
    {
        return $"{StreetAddress}\n{City}\n{State}\n{Country}";
    }
}