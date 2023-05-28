using System;
public class Address
{
    private string _streetAddress;
    private string _city;
    private string _stateProvince;
    private string _country;

    public Address(string streetAddress, string city, string stateProvince, string country)
    {
        _streetAddress = streetAddress;
        _city = city;
        _stateProvince = stateProvince;
        _country = country;
    }
    public bool IsUSA()
    {
        if (_country == "USA")
        {
            return true;
        }
        return false;
    }
    public string DisplayAddress()
    {
        return ($"{_streetAddress}\n{_city}, {_stateProvince}\n{_country}");
    }
}