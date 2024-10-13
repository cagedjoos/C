public class Customer
{
    private string _name = "";
    public Address address = new Address();
    public string GetName()
    {
        return _name;
    }
    public void SetName(string name)
    {
        _name = name;
    }

    public bool LiveInUSA()
    {
        return address.LiveInUSA();
        
    }
}