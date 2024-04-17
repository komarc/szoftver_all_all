using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _8_ra_mintaZH
{
    public partial class Form2 : Form
    {
        public Versenyzo versenyzo;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            versenyzoBindingSource.DataSource = versenyzo;
        }
    }
}
