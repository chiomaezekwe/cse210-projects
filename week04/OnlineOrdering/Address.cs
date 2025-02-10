using System;
public class Address
{
    private string street;
    private string city;
    private string state;
    private string country;

    // Constructor to initialize Address
    public Address(string street, string city, string state, string country)
    {
        this.street = street;
        this.city = city;
        this.state = state;
        this.country = country;
    }

    // Getter and Setter methods
    public string GetStreet()
    {
        return street;
    }

    public void SetStreet(string street)
    {
        this.street = street;
    }

    public string GetCity()
    {
        return city;
    }

    public void SetCity(string city)
    {
        this.city = city;
    }

    public string GetState()
    {
        return state;
    }

    public void SetState(string state)
    {
        this.state = state;
    }

    public string GetCountry()
    {
        return country;
    }

    public void SetCountry(string country)
    {
        this.country = country;
    }

    // Method to determine if the address is in the USA
    public bool isInUSA()
    {
        return country.Equals("USA", StringComparison.OrdinalIgnoreCase);
    }

    // Method to get the full address in a formatted string
    public string getFullAddress()
    {
        return $"{street}\n{city}, {state}\n{country}";
    }
}