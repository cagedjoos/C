public class Address
{
    private string _address = "";
    private string _city = "";
    private string _stateprovince = "";
    private string _country = "";
    private string _zipcode = "";

    public string GetAddress()
    {
        return _address;
    }

    public void SetAddress(string Address)
    {
        _address = Address;
    }

    public string GetCity()
    {
        return _city;
    }

    public void SetCity(string City)
    {
        _city = City;
    }

    public string GetStateProvince()
    {
        return _stateprovince;
    }

    public void SetStateProvince(string StateProvince)
    {
        _stateprovince = StateProvince;
    }

    public string GetCountry()
    {
        return _country;
    }

    public void SetCountry(string Country)
    {
        _country = Country;
    }

    public string GetZipcode()
    {
        return _zipcode;
    }
    
    public void SetZipcode(string Zipcode)
    {
        _zipcode = Zipcode;
    }

    public bool LiveInUSA()
    {
        if (_country.ToLower() == "usa")
        {
            return true;
        }
        else
        {
            return false;
        }
        
    }

    public void DisplayWholeAddress()
    {
        Console.WriteLine($"{_address}, {_city}, {_stateprovince}, {_zipcode}, {_country}");
    }
}