using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;

public class Square : Shape
{
    private int _side{get;set;}
    public Square(string color, int side) : base(color){
        _side=side;
    }
    public override double GetArea()
    {
        return _side * _side;
    }


}