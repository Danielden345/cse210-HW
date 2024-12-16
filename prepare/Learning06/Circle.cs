using System;
using System.Dynamic;

public class Cicrle : Shape
{
    private double _radius{get;set;}
    public Cicrle(string color, double radius) : base(color)
    {
        _radius = radius;
    }
    public override double GetArea()
    {
        return 2*Math.PI*_radius;
    }
}