public class Address
{
  private string _street;
  private string _city;
  private string _state; //_state/province
  private string _country;


  public Address(string street, string city, string state, string country)
  {
    _street = street;
    _city = city;
    _state = state; //_state/province
    _country = country;
  }

  public bool IsInUSA()
  {
    if (_country == "USA" || (_country == "U.S.A.") || (_country == "E.E.U.U.") || (_country == "United States of America"))
    {
      return true;
    }
    else
    {
      return false;
    }
  }

  public string DisplayAddress()
  {
    string texto = "Street: " + _street + " | City: " + _city + " | State/Province: " + _state + " | Country: " + _country;
    return texto;
  }
}