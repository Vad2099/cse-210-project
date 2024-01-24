using System;

public class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }

    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    //public override string ToString()
    //{
        //return $"{_top}/{_bottom}";
    //}

    public int GetTopNumber()
    {
        return _top;        
    }

    public void SetTopNumber(int top)
    {
        _top = top;
    }

    public int GetBottomNumber()
    {
        return _bottom;
    }

    public void SetBottomNumber(int bottom)
    {
        _bottom = bottom;
    }

     // Method to return the fraction in the form "3/4"
    public string GetFractionString()
    {
        return $"{_top}/{_bottom}";
    }

    // Method to return the decimal value of the fraction
    public double GetDecimalValue()
    {
        return (double)_top / _bottom;
    }


}