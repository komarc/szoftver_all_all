using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Hajos
{
    internal class Kerdes
    {
        public string KérdésSzöveg { get; set; } = string.Empty; //ha zavar a zöld aláhúzás
        public string Válasz1 { get; set; } = string.Empty;
        public string Válasz2 { get; set; } = string.Empty;
        public string Válasz3 { get; set; } = string.Empty;
        public string URL { get; set; } = string.Empty;
        public int HelyesVálasz { get; set; }
        public int HelyesVálaszokSzáma { get; set; }
    }
}
