using System;
using System.Collections.Generic;
using System.Text;

namespace interfaces
{
    class MyClass: MyInterface
    {
        private int num;
        public MyClass(int n)
        {
            number = n;
            show();
        }

        public void show()
        {
            Console.WriteLine("Number = " + number);
        }

        public void setNum(int n)
        {
            num = n;
        }

        public int getNum()
        {
            return num;
        }

        public int number
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
                for(int i = 0; i < k; i++)
                {
                    r /= 10;
                }

                return r % 10;
            }
        }
    }
}
