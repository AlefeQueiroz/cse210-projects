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

// Class to represent an Order
class Order
{
    private List<Product> products;
    private Customer customer;

    // Constructor to initialize the order with a list of products and a customer
    public Order(Customer customer)
    {
        products = new List<Product>();
        this.customer = customer;
    }

    // Method to add a product to the order
    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    // Method to calculate the total cost of the order, including shipping
    public decimal GetTotalCost()
    {
        decimal total = 0;

        // Sum up the total cost of all products
        foreach (var product in products)
        {
            total += product.GetTotalCost();
        }

        // Add shipping cost based on the customer's location
        decimal shippingCost = customer.LivesInUSA() ? 5 : 35;
        total += shippingCost;

        return total;
    }

    // Method to generate the packing label
    public string GetPackingLabel()
    {
        string packingLabel = "Packing Label:\n";

        foreach (var product in products)
        {
            packingLabel += product.GetPackingLabel() + "\n";
        }

        return packingLabel;
    }

    // Method to generate the shipping label
    public string GetShippingLabel()
    {
        return $"Shipping Label:\n{customer.GetName()}\n{customer.GetAddress()}";
    }
}
