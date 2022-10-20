using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance_Part2
{
    class Square
    {
        int side, area;
        public void Get()
        {
            Console.WriteLine("Enter Side");
            side = Byte.Parse(Console.ReadLine());
        }
        public void CalculateArea()
        {
            area = side * side;
        }
        public void DisplayArea()
        {
            Console.WriteLine("Area is " + area);
        }
    }
    class Rectangle
    {
        int length,width, area;
        public void Get()
        {
            Console.WriteLine("Enter Length");
            length = Byte.Parse(Console.ReadLine());
            Console.WriteLine("Enter Width");
            width = Byte.Parse(Console.ReadLine());
        }
        public void CalculateArea()
        {
            area = length * width;
        }
        public void DisplayArea()
        {
            Console.WriteLine("Area is " + area);
        }
    }

    class Triangle
    {
        int Base, height, area;
        public void Get()
        {
            Console.WriteLine("Enter Base");
            Base = Byte.Parse(Console.ReadLine());
            Console.WriteLine("Enter height");
            height = Byte.Parse(Console.ReadLine());
        }
        public void CalculateArea()
        {
            area = (int) .5 * Base * height;
        }
        public void DisplayArea()
        {
            Console.WriteLine("Area is " + area);
        }
    }
}
