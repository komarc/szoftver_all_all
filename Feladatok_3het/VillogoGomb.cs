using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feladatok_3het
{
    internal class VillogoGomb : Button //villogogomb ugyanazt tudja mint amit a button osztaly tud
    {
        public VillogoGomb() 
        {
            MouseEnter += VillogoGomb_MouseEnter; //'MouseEnter +=' és tab
            MouseLeave += VillogoGomb_MouseLeave;
            MouseHover += VillogoGomb_MouseHover;
            MouseClick += VillogoGomb_MouseClick;
        }
        int szamolo = 0;
        private void VillogoGomb_MouseClick(object? sender, MouseEventArgs e)
        {
            if (szamolo==5)
            {
                szamolo = 1;
                Text = szamolo.ToString();
            }
            else
            {
                szamolo++;
                Text=szamolo.ToString();
            }
        }

        
        private void VillogoGomb_MouseHover(object? sender, EventArgs e)
        {
            BackColor = Color.Green;
        }

        private void VillogoGomb_MouseLeave(object? sender, EventArgs e)
        {
            
        }

        private void VillogoGomb_MouseEnter(object? sender, EventArgs e)
        {
            BackColor = Color.Fuchsia;
        }
    }
}
