using System;
using System.Collections.Generic;
using System.Text;

namespace abstractClasses
{
    abstract class Base
    {
        public abstract string text
        {
            get;
            set;
        }

        public abstract char this[int k]
        {
            get;
        }

        public abstract int lenght
        {
            get;
        }
    }
}
