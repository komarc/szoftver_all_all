using CsvHelper;
using gyakorlas.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gyakorlas
{
    public partial class UserControl1 : UserControl
    {
        StudiesContext context = new StudiesContext();
        public UserControl1()
        {
            InitializeComponent();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            var ilist = (from i in context.Instructors select i).ToList();

            listBox1.DataSource = ilist;

            listBox1.DisplayMember = "Name";
            label1.Text = ilist.Count.ToString();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            FillDataSource();
        }
        private void FillDataSource()
        {
            var xd = (from i in context.Instructors
                      where i.Name.Contains(textBox1.Text)
                      select i).ToList();

            listBox1.DataSource = xd;
            label1.Text = xd.Count.ToString();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Instructor instructor = new Instructor();

            if (listBox1.SelectedItem == null) return;
            instructor = listBox1.SelectedItem as Instructor;

            var lessons = (from i in context.Lessons
                           where i.InstructorFk == instructor.InstructorSk
                           select new
                           {
                               Kurzus = i.CourseFkNavigation.Name,
                               Nap = i.DayFkNavigation.Name,
                               Sáv = i.TimeFkNavigation.Name,
                           }).ToList();
            dataGridView1.DataSource = lessons;

            label2.Text = lessons.Count.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();

            if (sfd.ShowDialog() == DialogResult.OK) { 
                
                StreamWriter sw = new StreamWriter(sfd.FileName);
                var csv = new CsvWriter(sw,CultureInfo.InvariantCulture);

                var ilist = (from i in context.Instructors select i).ToList();

                csv.WriteRecords(ilist);

                sw.Close();
            }
        }
    }
}
