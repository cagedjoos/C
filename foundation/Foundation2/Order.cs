public class Order
{
    private List<Product> _products = new List<Product>();

    private Customer _customer;

    public void SetCustomer(Customer customer)
    {
        _customer = customer;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double GetTotalCost()
    {
        double shipping = 0;
        double grandTotal = 0;
        double total = 0;
        if (_customer.LiveInUSA() == true)
        {
            shipping = 5;
        }
        else
        {
            shipping = 35;
        }
        foreach (var product in _products)
        {
            total += product.TotalCost();
        }
        grandTotal = total + shipping;
        return grandTotal;
    }

    public void DisplayPackingList()
    {
        Console.WriteLine("Packing Label");
        foreach (var product in _products)
        {
            Console.WriteLine($"Product Name:{product.GetName()}, Product #:{product.GetId()}");
        }
    }

    public void DisplayShippingLabel()
    {
        Console.WriteLine("Shipping Label");
        Console.WriteLine($"{_customer.GetName()}");
        _customer.address.DisplayWholeAddress();
    }
}