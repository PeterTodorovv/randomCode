using System;
using System.Collections.Generic;
using System.Text;

namespace interfaceInheritance
{
    class MyClass: Base, First, Second
    {
        private int num;
        public MyClass(int n): base(n)
        {

        }
        public void setNum(int n)
        {
            num = n;
        }

        public int getNum()
        {
            return num;
        }

        public override int number 
        {
            get
            {
                return getNum();
            }
            set
            {
                setNum(value);
            }
        }

        public int this[int k]
        {
            get
            {
                int r = number;

                for(int i = 0; i<k; i++)
                {
                    r /= 10;
                }

                return r % 10;
            }
        }
    }
}
