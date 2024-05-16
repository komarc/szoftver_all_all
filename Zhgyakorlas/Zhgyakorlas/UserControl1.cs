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

    public partial class UserControl1 : UserControl
    {
        StudiesContext context = new StudiesContext();
        public UserControl1()
        {
            InitializeComponent();
            listBox1.DisplayMember = "Name";
        }

        private void UserControl1_Load(object sender, EventArgs e) //feltoltjuk a listboxot
        {
            var ilist = from i in context.Instructors select i;
            listBox1.DataSource = ilist.ToList();
        }

        private void FillDataSource() // folyamatosan frissul a listbox ahogy ir a textboxba
        {
            listBox1.DataSource = (from i in context.Instructors where i.Name.Contains(textBox1.Text) select i).ToList();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            FillDataSource();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e) // datagridview feltöltése
        {
            if (listBox1.SelectedIndex == null) return;
            Instructor instructor = (Instructor)listBox1.SelectedItem as Instructor;

            var lessons = from l in context.Lessons
                          where l.InstructorFk == instructor.InstructorSk
                          select new
                          {
                              Kurzus = l.CourseFkNavigation.Name,
                              Nap = l.DayFkNavigation.Name,
                              Sáv = l.TimeFkNavigation.Name
                          };

            dataGridView1.DataSource = lessons.ToList();
        }
    }
}
