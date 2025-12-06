using System;
class Customer
{
    // - _customerName: string
    private string _customerName;
    //- _address: Address
    private Address _address;

    // + Customer(name, address)
    public Customer(string customerName, Address address)
    {
        _customerName = customerName;
        _address = address; 
    }

    // + GetCustomerName()
    public string GetCustomerName()
    {
        return _customerName;
    }
    // + GetAddress()
    public Address GetAddress()
    {
        return _address;
    }
    // + GetShippingAddress()
    public string GetShippingAddress()
    {
        return _address.GetFullAddress();
    }
}