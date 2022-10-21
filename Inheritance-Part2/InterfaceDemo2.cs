using System;
using System.Collections.Generic;
using System.Text;

namespace InheritancePart2
{
     interface IMain1
    {
        void Get();
        void Display();
    }
    interface IMain2
    {
        void Get();
        void Calculate();
    }

    class Demo : IMain1, IMain2
    {
        public void Display()
        {
            throw new NotImplementedException();
        }

        public void Get()
        {
            throw new NotImplementedException();
        }

        void IMain2.Calculate()
        {
            throw new NotImplementedException();
        }

        void IMain2.Get()
        {
            throw new NotImplementedException();
        }
    }


}
