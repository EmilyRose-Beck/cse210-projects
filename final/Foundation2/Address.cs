using System;

class Address
{
    //-_streetAddress string()
    private string _streetAddress;

    //-_city: string()
    private string _city;

    // - _stateProvince: string()
    private string _stateProvince;
    
    //- _country: string()
    private string _country;

    // +Address(street, city, state, country)
    public Address(string streetAddress, string city, string stateProvince, string country)
    {
        _streetAddress = streetAddress;
        _city = city;
        _stateProvince = stateProvince;
        _country = country;
    }

    //do I have to do these?
    //better safe than sorry I guess
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

    public string GetCountry()
    {
        return _country;
    }


    // + IsUsa
    public bool IsUsa()
    {
        return _country.Trim().ToUpper() == "USA";
    }


    // + GetFullAddress
    public string GetFullAddress()
    {
        return $"{_streetAddress}\n{_city}, {_stateProvince}\n{_country}";
    }

}