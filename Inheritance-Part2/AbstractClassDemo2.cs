using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceDemo
{
    // Abbstract Class > A class in which some of the methods are defined and some of the methds are not
    // defined
    // The methods  which are not defined are k.a. abstract methods 
    // The Methods which are defined are k.a. Concrete methods
    abstract class Shape
    {
        protected int x, y, area;
        abstract public void Get();
        abstract public void CalculateArea();
        public void DisplayArea()
        {
            Console.WriteLine("Area is " + area);
        }
    }

    class Square : Shape
    {
        public override void Get()
        {
            Console.WriteLine("Enter Side");
            x = Byte.Parse(Console.ReadLine());
        }

        public override void CalculateArea()
        {
            area = x * x;
        }
    }
    class Rectangle : Shape
    {
        public override void Get()
        {
            Console.WriteLine("Enter Length");
            x = Byte.Parse(Console.ReadLine());
            Console.WriteLine("Enter Width");
            y = Byte.Parse(Console.ReadLine());
        }

        public override void CalculateArea()
        {
            area = x * y;
        }
    }

    class Triangle : Shape
    {
        public override void Get()
        {
            Console.WriteLine("Enter Base");
            x = Byte.Parse(Console.ReadLine());
            Console.WriteLine("Enter height");
            y = Byte.Parse(Console.ReadLine());
        }

        public override void CalculateArea()
        {
            area = (int).5 * x * y;
        }
    }
    public class ASDemo
    {
        static void Main()
        {
            //Console.WriteLine("Square");
            //Square square = new Square();
            //square.Get();
            //square.CalculateArea();
            //square.DisplayArea();

            //Console.WriteLine("Rectangle");
            //Rectangle rectangle = new Rectangle();
            //rectangle.Get();
            //rectangle.CalculateArea();
            //rectangle.DisplayArea();

            //Console.WriteLine("Triangle");
            //Triangle triangle = new Triangle();
            //triangle.Get();
            //triangle.CalculateArea();
            //triangle.DisplayArea();

            Shape shape;

            Console.WriteLine("Square");
            shape = new Square();
            shape.Get();
            shape.CalculateArea();
            shape.DisplayArea();

            Console.WriteLine("Rectangle");
            shape = new Rectangle();
            shape.Get();
            shape.CalculateArea();
            shape.DisplayArea();

            Console.WriteLine("Triangle");
            shape = new Triangle();
            shape.Get();
            shape.CalculateArea();
            shape.DisplayArea();



        }
    }
}


