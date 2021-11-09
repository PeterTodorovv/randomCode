using System;
using System.Collections.Generic;
using System.Text;

namespace abstractClasses
{
    class Alpha: Base
    {
        private char[] symbs;

        public Alpha(string t): base()
        {
            text = t;
        }

        public override string text
        {
            get
            {
                return new string(symbs);
            }
            set
            {
                symbs = value.ToCharArray();
            }
        }
        public override int lenght
        {
            get
            {
                return symbs.Length;
            }
        }

        public override char this[int k]
        {
            get
            {
                return symbs[k];
            }
        }


    }
}
