using System;
using System.Collections.Generic;
using System.Text;

namespace interfaceInheritance
{
    abstract class Base
    {
        public abstract int number
        {
            get;
            set;
        }

        public Base(int n)
        {
            number = n;
            show();
        }

        public void show()
        {
            Console.WriteLine("number = " + number);
        }
    }
}
