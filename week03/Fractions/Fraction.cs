public class Fraction
{
    //attributes
    private int _top;
    private int _bottom;

    //constructors
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
        _top = top;
        _bottom = bottom;
    }

    //Getter
    public int GetTopValue()
    {
        return _top;
    }

    public int GetBottomValue()
    {
        return _bottom;
    }

    //Setter
    public void SetTopValue(int top)
    {
        _top = top;
    }

    public void SetBottomValue(int bottom)
    {
        _bottom = bottom;
    }

    //methods
    public string GetFractionString()
    {
        return $"{_top}/{_bottom}";
    }

    public double GetDecimalValue()
    {
        double result = (double)_top / _bottom;
        return Math.Round(result, 2);
    }


}

// Create a method called GetFractionString that returns the fraction in the form 3/4.
// Create a method called GetDecimalValue that returns a double that is the result of dividing the top number by the bottom number, such as 0.75.
// Verify that you can call each constructor and that you can retrieve and display the different representations for a few different fractions. For example, you could try:
// 1
// 5
// 3/4
// 1/3
// Sample Output


// 1/1
// 1
// 5/1
// 5
// 3/4
// 0.75
// 1/3
// 0.3333333333333333