using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("----------------------------------------------------------------------------------------------");
        Console.WriteLine("OnlineOrdering Project.");
        Console.WriteLine("----------------------------------------------------------------------------------------------");
        Console.WriteLine(" ");
        Console.WriteLine("Order #1.");
        Address myAddress1 = new("North Mills Avenue", "Orlando", "Florida", "USA");
        Customer myCustomer1 = new("Caribe Corp.", myAddress1);

        Order myOrder1 = new(myCustomer1);
        myOrder1.AddProduct(new Product("Whole Milk      ", "WM0001", 4.31, 4));
        myOrder1.AddProduct(new Product("Large White Eggs", "LWE003", 2.47, 1));
        myOrder1.AddProduct(new Product("White Bread     ", "WB0045", 1.82, 3));

        Console.WriteLine("----------------------------------------------------------------------------------------------");
        Console.WriteLine("Shipping Label.");
        Console.WriteLine($"{myOrder1.GetShippingLabel()}");

        Console.WriteLine("----------------------------------------------------------------------------------------------");
        Console.WriteLine("Packing Label.");
        Console.WriteLine($"{myOrder1.GetPackingLabel()}");
        Console.WriteLine("----------------------------------------------------------------------------------------------");
        Console.WriteLine($"Shipping Cost.: ${myOrder1.CalculateShippingCost()}");
        Console.WriteLine("");
        Console.WriteLine("----------------------------------------------------------------------------------------------");
        Console.WriteLine("Order #2.");
        Address myAddress2 = new("Nuevo Leon", "Mexico DF", "Mexico DF", "Mexico");
        Customer myCustomer2 = new("One Dollar Store.", myAddress2);

        Order myOrder2 = new(myCustomer2);
        myOrder2.AddProduct(new Product("Greeting card   ", "GCD023", 1.25, 9));
        myOrder2.AddProduct(new Product("Toothpaste      ", "TPA002", 1.20, 3));
        myOrder2.AddProduct(new Product("Notebook        ", "NTB001", 1.00, 20));
        Console.WriteLine("----------------------------------------------------------------------------------------------");
        Console.WriteLine("Shipping Label.");
        Console.WriteLine($"{myOrder2.GetShippingLabel()}");

        Console.WriteLine("----------------------------------------------------------------------------------------------");
        Console.WriteLine("Packing Label.");
        Console.WriteLine($"{myOrder2.GetPackingLabel()}");
        Console.WriteLine("----------------------------------------------------------------------------------------------");
        Console.WriteLine($"Shipping Cost.: ${myOrder2.CalculateShippingCost()}");

    }
}