using gyakorlas.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gyakorlas
{
    public partial class FormAdd : Form
    {
        public Course hozzaad = new Course();
        public FormAdd()
        {
            InitializeComponent();
        }

        private void FormAdd_Load(object sender, EventArgs e)
        {
            bindingSource1.DataSource = hozzaad;

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
