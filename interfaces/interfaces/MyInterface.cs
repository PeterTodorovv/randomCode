using System;
using System.Collections.Generic;
using System.Text;

namespace interfaces
{
    interface MyInterface
    {
        void show();
        void setNum(int n);
        int getNum();

        int number
        {
            get;
            set;
        }

        int this[int k]
        {
            get;
        }


    }
}
