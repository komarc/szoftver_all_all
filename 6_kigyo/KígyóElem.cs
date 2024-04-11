using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_kigyo
{ //asd
    internal class KígyóElem : PictureBox
    {
        public static int m = 20;
        public static int hossz=1; 
        public KígyóElem()
        {
            Width = KígyóElem.m;
            Height = KígyóElem.m;
            BackColor = Color.Fuchsia;
        }
    }
}
