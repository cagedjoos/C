public class Product
{
    private string _name;
    private string _productId;
    private double _price;
    private int _quantity;

    public string GetName()
    {
        return _name;
    }

    public void SetName(string name)
    {
        _name = name;
    }

    public string GetId()
    {
        return _productId;
    }

    public void SetId(string productId)
    {
        _productId = productId;
    }

    public Product(string name, string productId, double price, int quantity) 
    {
        _name = name;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }

    public double TotalCost()
    {
        double multiply = _price * _quantity;
        return multiply;
    }
}