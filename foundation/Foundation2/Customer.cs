// Class to represent a Customer
class Customer
{
    private string name;
    private Address address;

    // Constructor to initialize customer fields
    public Customer(string name, Address address)
    {
        this.name = name;
        this.address = address;
    }

    // Method to get the name of the customer
    public string GetName()
    {
        return name;
    }

    // Method to check if the customer lives in the USA
    public bool LivesInUSA()
    {
        return address.IsInUSA();
    }

    // Method to get the full address of the customer
    public string GetAddress()
    {
        return address.GetFullAddress();
    }
}
