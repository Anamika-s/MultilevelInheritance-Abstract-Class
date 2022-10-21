using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceInterface
{
    interface IShape
    {
        
        void Get();
        void CalculateArea();
        void DisplayArea();
    }
    class Square : IShape
    {
        int side, area;
        public void CalculateArea()
        {
            area = side * side;
        }

        public void DisplayArea()
        {
            Console.WriteLine("Area is " + area);

        }

        public void Get()
        {
            Console.WriteLine("Enter Side");
            side = Byte.Parse(Console.ReadLine());
        }
    }
    class Rectangle : IShape
    {

        public void CalculateArea()
        {
            throw new NotImplementedException();
        }

        public void DisplayArea()
        {
            throw new NotImplementedException();
        }

        public void Get()
        {
            throw new NotImplementedException();
        }
    }
}
