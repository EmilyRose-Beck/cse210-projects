using System;

//reused Address from prevous Address class in F. 2
public class Address
{
    //-_streetAddress string()
    private string _streetAddress;

    //-_city: string()
    private string _city;

    // - _stateProvince: string()
    private string _stateProvince;
    

    // +Address(street, city, state, country)
    public Address(string streetAddress, string city, string stateProvince )
    {
        _streetAddress = streetAddress;
        _city = city;
        _stateProvince = stateProvince;
    }

    public string GetStreetAddress()
    {
        return _streetAddress;
    }

    public string GetCity()
    {
        return _city;
    }

    public string GetStateProvince()
    {
        return _stateProvince;
    }


    // + GetFullAddress
    public string GetFullAddress()
    {
        return $"{_streetAddress}\n{_city}, {_stateProvince}";
    }

}