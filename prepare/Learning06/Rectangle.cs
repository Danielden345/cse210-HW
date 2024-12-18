using System;
using System.Collections.Generic;

public class Rectangle : Shape
{
    private double _length{get;set;}
    private double _width{get;set;}
    public Rectangle(string color, double length, double width) : base(color)
    {
        _length = length;
        _width = width;
    }
    public override double GetArea()
    {
        return _length * _width;
    }
}