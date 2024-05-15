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
    public partial class UserControl2 : UserControl
    {
        StudiesContext context = new StudiesContext();
        public UserControl2()
        {
            InitializeComponent();
        }

        private void UserControl2_Load(object sender, EventArgs e)
        {
            var ilist = (from i in context.Courses select i).ToList();
            listBox1.DataSource = ilist;
            label1.Text = ilist.Count.ToString();
            listBox1.DisplayMember = "Name";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Course course = new Course();
            if (listBox1.SelectedItem == null) return;
            course = listBox1.SelectedItem as Course;

            var courses = (from i in context.Lessons
                           where i.CourseFk == course.CourseSk
                           select new
                           {
                               Nap = i.DayFkNavigation.Name,
                               Idő = i.TimeFkNavigation.Name,
                               Előadó = i.InstructorFkNavigation.Name
                           }).ToList();
            dataGridView1.DataSource = courses;
            label2.Text = courses.Count.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            FillDataSource();
        }
        private void FillDataSource()
        {
            var xd = (from i in context.Courses where i.Name.Contains(textBox1.Text) select i).ToList();

            listBox1.DataSource = xd;

            label1.Text = xd.Count.ToString(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormAdd formAdd = new FormAdd();

            if (formAdd.ShowDialog()==DialogResult.OK)
            {
                context.Courses.Add(formAdd.hozzaad);
                context.SaveChanges();
            }
        }
    }
}
