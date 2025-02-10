using System;
public class Order
{
    private List<Product> products;
    private Customer customer;

    // Constructor to initialize order of customer
    public Order(Customer customer)
    {
        this.customer = customer;
        this.products = new List<Product>();
    }

    // Method to add a product to order
    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    // Method to calculate total price of order
    public double GetTotalPrice()
    {
        double productTotal = 0;
        foreach (var product in products)
        {
            productTotal += product.GetTotalCost();
        }

        // Shipping cost based on customer's location
        double shippingCost = customer.isFromUSA() ? 5 : 35;

        // Total price including shipping fee
        return productTotal + shippingCost;
    }

    // Method to get packing label for the order
    public string GetPackingLabel()
    {
        string packingLabel = "Packing Label:\n";
        foreach (var product in products)
        {
            packingLabel += $"{product.GetName()} (ID: {product.GetProductId()})\n";
        }
        return packingLabel;
    }

    // Method to get shipping label for the order
    public string GetShippingLabel()
    {
        return $"Shipping Label:\n{customer.GetName()}\n{customer.GetAddress().getFullAddress()}";
    }
}
