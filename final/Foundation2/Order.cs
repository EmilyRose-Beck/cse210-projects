using System;

class Order
{
    // - _customer: Customer
    private Customer _customer;
    // - _products: List<Product>
    private List<Product> _products;
    // - _shippingCost: float
    private float _shippingCost;

    //Order(Customer customer, List<Product> products)
    public Order(Customer customer, List<Product> products)
    {
        _customer = customer;
        _products = products;

        //+ shippingCost()
        if (_customer.GetAddress().IsUsa())
        {
            _shippingCost = 5f;
        }
        else
        {
            _shippingCost = 35f;
        }
    }


    //+ TotalPrice()
    public float TotalPrice()
    {
        float total = 0;

        foreach (Product product in _products)
        {
            total += product.GetPrice();
        }

        total += _shippingCost;
        return total;
    }

    // + shippingLabel()
    public string ShippingLabel()
    {
        return $"{_customer.GetCustomerName()}\n{_customer.GetShippingAddress()}";
    }
    // + PackingLabel()
    public string PackingLabel()
    {
        string label = "";

        foreach (Product product in _products)
        {
            label += $"Product: {product.GetName()}, ID: {product.GetProductID()}\n";
        }
        return label;
    }




}