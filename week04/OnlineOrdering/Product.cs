using System; 
public class Product
{
    private string name;
    private int productId;
    private double price;
    private int quantity;

    // Constructor to initialize product
    public Product(string name, int productId, double price, int quantity)
    {
        this.name = name;
        this.productId = productId;
        this.price = price;
        this.quantity = quantity;
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

    public int GetProductId()
    {
        return productId;
    }

    public void SetProductId(int productId)
    {
        this.productId = productId;
    }

    public double GetPrice()
    {
        return price;
    }

    public void SetPrice(double price)
    {
        this.price = price;
    }

    public int GetQuantity()
    {
        return quantity;
    }

    public void SetQuantity(int quantity)
    {
        this.quantity = quantity;
    }

    // Method to calculate total cost of the product
    public double GetTotalCost()
    {
        return price * quantity;
    }
}