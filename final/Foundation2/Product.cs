using System;

class Product
{
    //- _name: string
    private string _name;
    // - _productID: int
    private int _productID;
    // - _pricePerItem: float
    private float _pricePerItem;
    //- _howManySelected: int
    private int _howManySelected;

    //+ Product(name, ID, price, quanity)
    public Product(string name, int productID, float pricePerItem, int howManySelected)
    {
        _name = name;
        _productID = productID;
        _pricePerItem = pricePerItem;
        _howManySelected = howManySelected;
    }
    //+ GetPrice()
    public float GetPrice()
    {
        //return _howManySelected * _pricePerItem;
        return _howManySelected * _pricePerItem;
    }

    //perhaps add?
    //GetName()
    public string GetName()
    {
        return _name;
    }
    //GetQuantity()
    public int GetQuantity()
    {
        return _howManySelected;
    }
    //GetProductID()
    public int GetProductID()
    {
        return _productID;
    }
}