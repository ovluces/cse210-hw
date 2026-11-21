public class Order
{
  private List<Product> _product = new();
  private Customer _customer;

  public Order(Customer customer)
  {
    _customer = customer;
  }

  public void AddProduct(Product product)
  {
    _product.Add(product);
  }

  public double CalculateTotal()
  {
    double total = 0;
    foreach (Product product in _product)
    {
      total += product.CostThisProduct();
    }
    return total;
  }

  public double CalculateShippingCost()
  {
    double tax = 0;
    if (_customer.IsInUSA())
    {
      tax = 5;
    }
    else
    {
      tax = 35;
    }
    return tax;
  }

  // public string DisplayOrder()
  // {
  //   string texto = "Customer: " + _customer + "\nProducts: ";
  //   return texto;
  // }

  public string GetShippingLabel()
  {
    string texto = _customer.DisplayCustomer();
    return texto;
  }

  public string GetPackingLabel()
  {
    string texto = "Product ID      Product Name               Price         Quantity         Sub Total\n";
    foreach (Product product in _product)
    {
      texto += product.GetProduct();
    }
    texto += "-----------\n";
    texto += "Total --> $" + CalculateTotal().ToString("N2");
    return texto;
  }
}