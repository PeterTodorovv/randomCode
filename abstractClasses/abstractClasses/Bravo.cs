using System;
using System.Collections.Generic;
using System.Text;

namespace abstractClasses
{
    class Bravo : Base
    {
        private string txt;

        public Bravo(string t) : base()
        {
            text = t;
        }

        public override string text 
        {
            get
            {
                return txt;
            }
            set
            {
                txt = value;
            }
        }

        public override int lenght
        {
            get
            {
                return txt.Length;
            }
        }

        public override char this[int k]
        {
            get
            {
                return txt[k];
            }
        }
    }
}
