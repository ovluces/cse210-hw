public class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int top)
    {
        _top = top;
        _bottom = 1;
    }

    public Fraction(int top, int bottom)
    {
        if (bottom != 0)
        {
            _top = top;
            _bottom = bottom;
        }
        else
        {
            Console.WriteLine("The bottom value can not be 0");
        }

    }

    public int GetTop()
    {
        return 0;

    }

    public void SetTop(int top)
    {

    }
    public int GetBottom()
    {
        return 0;
    }
    public void SetBottom(int bottom)
    {

    }

    public void GetFractionString()
    {
        Console.WriteLine($"{_top}/{_bottom}");
    }

    //respuesta del cse
    public string GetFractionString2()
    {
        // Notice that this is not stored as a member variable.
        // Is is just a temporary, local variable that will be recomputed each time this is called.
        string text = $"{_top}/{_bottom}";
        return text;
    }

    public void GetDecimalValue()
    {
        if (_bottom != 0)
        {
            double decimalValue = (double)_top / (double)_bottom;
            Console.WriteLine($"{decimalValue}");
        }
        else
        {
            Console.WriteLine("The bottom value can not be 0");
        }

    }

    public double GetDecimalValue2()
    {
        // Notice that this is not stored as a member variable.
        // Is will be recomputed each time this is called.
        return (double)_top / (double)_bottom;
    }
}