using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7_Databinding
{
    public partial class Form2 : Form
    {
        public Countrydata EditedCountryData;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            bindingSource1.DataSource = EditedCountryData;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
