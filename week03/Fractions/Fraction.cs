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
            Console.WriteLine("The bottom can not be 0");
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

    public string GetFractionString()
    {

        return "0";
    }

    public double GetDecimalValue()
    {
        return 0;
    }
}