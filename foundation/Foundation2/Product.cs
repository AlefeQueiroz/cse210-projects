// Class to represent a Product
class Product
{
    private string name;
    private string productId;
    private decimal price;
    private int quantity;

    // Constructor to initialize product fields
    public Product(string name, string productId, decimal price, int quantity)
    {
        this.name = name;
        this.productId = productId;
        this.price = price;
        this.quantity = quantity;
    }

    // Method to calculate the total cost of the product
    public decimal GetTotalCost()
    {
        return price * quantity;
    }

    // Method to get the product information for the packing label
    public string GetPackingLabel()
    {
        return $"{name} (ID: {productId})";
    }
}

