using System;

class Order
{
    // - _customer: Customer
    private Customer _customer;
    // - _products: List<Product>
    private List<Product> _product;
    // - _shippingCost: float
    private float _shippingCost;

    //Order(Customer customer, List<Product> products)
    public Order(Customer customer, List<Product> product)
    {
        _customer = customer;
        _product = product;
    }


    //+ TotalPrice()
    // + shippingLabel()
    // + PackingLabel()

}