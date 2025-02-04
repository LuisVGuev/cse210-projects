public class Customer
{
    private string name;
    private Address address;

    public Customer(string name, Address address)
    {
        this.name = name;
        this.address = address;
    }

    public string GetShippingLabel()
    {
        return $"Name: {name}\n{address.ToString()}";
    }

    public bool IsInUSA()
    {
        return address.IsInUSA();
    }
}
