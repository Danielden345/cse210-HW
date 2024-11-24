using System;
using System.Collections.Generic;
using System.Dynamic;

public class Fraction{
    private int _top;
    private int _bottom;
    public int Top{
        get {return _top;}
        set {_top = value;}
    }
    
    public int Bottom{
        get {return _bottom;}
        set {
            if(value == 0){
                throw new ArgumentException("Denominator cannot be zero.");
            }
            _bottom = value;}
    }
    public Fraction(){
        _top = 1;
        _bottom = 1;
    }
    public Fraction(int Top){
        _top = Top;
        _bottom = 1;
    }
    public Fraction(int Top, int Bottom){
        if (Bottom == 0){
            throw new ArgumentException("Denominator cannot be zero.");
        }
        _top = Top;
        _bottom = Bottom;
    }
    public string GetFractionString(){
        return $"{Top}/{Bottom}";
    }
    public double GetDecimalValue(){
        return (double)_top/(double)_bottom;
    }
}
