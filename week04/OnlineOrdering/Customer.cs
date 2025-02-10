using System;
public class Customer
{
    private string name;
    private Address address;

    // Constructor to initialize customer
    public Customer(string name, Address address)
    {
        this.name = name;
        this.address = address;
    }

    // Getter and Setter methods
    public string GetName()
    {
        return name;
    }

    public void SetName(string name)
    {
        this.name = name;
    }

    public Address GetAddress()
    {
        return address;
    }

    public void SetAddress(Address address)
    {
        this.address = address;
    }

    // Method to check if the customer is from the USA
    public bool isFromUSA()
    {
        return address.isInUSA();
    }
}