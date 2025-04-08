public class Address
{
   private string _streetAddress;
   private string _theCity;
   private string _stateOrProvince;
   private string _country;

   public Address(string streetAddress,string theCity, string stateOrProvince, string country )
   {
        _streetAddress = streetAddress;
        _theCity = theCity;
        _stateOrProvince = stateOrProvince;
        _country = country;
   }

    public string GetStreetAddress()
    {
        return _streetAddress;
    }

     public string GetTheCity()
    {
        return _theCity;
    }

     public string GetStateOrProvince()
    {
        return _stateOrProvince;
    }

     public string GetCountry()
    {
        return _country;
    }

    public string GetFullAddress()
    {
        return $"{_streetAddress}\n{_theCity}\n{_stateOrProvince}\n{_country}";
    }

    public bool IsUSA()
    {
        if (_country == "USA")
        {
            return true;
        }
        else
        {
            return false;
        }
    }

}
