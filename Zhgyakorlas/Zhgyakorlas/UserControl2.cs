using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zhgyakorlas.Models;

namespace Zhgyakorlas
{
    public partial class UserControl2 : UserControl
    {
        StudiesContext context = new StudiesContext();
        public UserControl2()
        {
            InitializeComponent();
            listBox1.DisplayMember = "Name";
        }

        private void UserControl2_Load(object sender, EventArgs e)
        {
            var ilist = from i in context.Courses select i;
            listBox1.DataSource = ilist.ToList();
        }

        private void DataFill() // csak a kurzus nevet jeleniti meg
        {
            listBox1.DataSource = (from i in context.Courses where i.Name.Contains(textBox1.Text) select i).ToList();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataFill();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e) //datagridview feltoltes
        {
            if (listBox1.SelectedIndex == null) return;
            Course course = listBox1.SelectedItem as Course;

            var courses = (from l in context.Lessons
                           select new
                           {
                               Nap = l.DayFkNavigation.Name,
                               Sáv = l.TimeFkNavigation.Name,
                               Oktató = l.InstructorFkNavigation.Name
                           }
                           );
            dataGridView1.DataSource = courses.ToList();
        }
    }
}
