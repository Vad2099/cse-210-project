using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square("red",5);
        

        Rectangle rectangle = new Rectangle("green", 5, 8);
        

        Circle circle = new Circle("black",10);
    

        List<Shape> shapes = new List<Shape>();
        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);

        foreach (Shape s in shapes)
        {
            string color = s.GetColor();
            double area = s.GetArea();

            Console.WriteLine($"color: {color} and area: {area}");
        }
        


    
    }
}