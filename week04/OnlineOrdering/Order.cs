class Order
{
    private List<Product> _products;
    private Customer _customer;


    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    public double CalculateTotalCost()
    {
        double totalCost = 0;

        foreach (Product product in _products)
        {
            totalCost += product.TotalCost();
        }

        if (_customer.LivesInUSA())
        {
            return totalCost + 5;
        }
        else
        {
            return totalCost + 35;
        }

    }

    public string GetPackagingLabel()
    {
        string label = "Packing Label:\n";

        foreach (Product product in _products)
        {
            label += $"{product.GetName()} (ID:{product.GetProductId()})";
        }

        return label;
    }

    public string GetShippingLabel()
    {
        return $"Shipping Label:\n{_customer.GetName()}\n{_customer.GetAddress().GetFullAddress()}";
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

}





// A shipping label should list the name and address of the customer