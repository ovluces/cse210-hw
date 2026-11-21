public class Product
{
  private string _name;
  private string _productId;
  private double _prize;
  private int _quantity;


  public Product()
  {
    _name = "name";
    _productId = "productId";
    _prize = 0;
    _quantity = 0;
  }
  public Product(string name, string productId, double prize, int quantity)
  {
    _name = name;
    _productId = productId;
    _prize = prize;
    _quantity = quantity;
  }

  public string GetName()
  {
    return _name;
  }

  public string GetProductId()
  {
    return _productId;
  }

  public double CostThisProduct()
  {
    return _prize * (double)_quantity;
  }

  public string GetProduct()
  {
    string texto = _productId + "          " + _name + "              " + _prize.ToString("N2") + "          " + _quantity + "                $" + CostThisProduct().ToString("N2") + "\n";
    //https://learn.microsoft.com/es-es/dotnet/api/system.double.tostring?view=net-10.0   format for decimals
    return texto;
  }

}
