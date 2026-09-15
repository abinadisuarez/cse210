public class Fraction
{
    private int _top;
    private int _bottom;

    // 1. No-parameter constructor: initializes to 1/1
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    // 2. One-parameter constructor: takes the top, sets bottom to 1
    public Fraction(int top)
    {
        _top = top;
        _bottom = 1;
    }

    // 3. Two-parameter constructor: takes both top and bottom
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    // Getter for _top
    public int GetTop()
    {
        return _top;
    }

    // Setter for _top
    public void SetTop(int top)
    {
        _top = top;
    }

    // Getter for _bottom
    public int GetBottom()
    {
        return _bottom;
    }

    // Setter for _bottom
    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }

    // Returns the fraction as a string, e.g. "3/4"
    public string GetFractionString()
    {
        return $"{_top}/{_bottom}";
    }

    // Returns the decimal value of the fraction, e.g. 0.75 for 3/4
    public double GetDecimalValue()
    {
        return (double)_top / _bottom;
    }
}