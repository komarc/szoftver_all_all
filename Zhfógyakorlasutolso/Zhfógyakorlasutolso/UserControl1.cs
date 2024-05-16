using CsvHelper;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zhfógyakorlasutolso.Models;
using System.Globalization;

namespace Zhfógyakorlasutolso
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
            FillDataSource();
        }

        private void FillDataSource() // folyamatosan frissul a listbox ahogy ir a textboxba
        {
            var lista = (from i in context.Instructors where i.Name.Contains(textBox1.Text) select i).ToList();
            listBox1.DataSource = lista;
            label1.Text = lista.Count.ToString();
        }




        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null) return;
            Instructor instructor = (Instructor)listBox1.SelectedItem as Instructor;

            var lessons = (from l in context.Lessons
                           where l.InstructorFk == instructor.InstructorSk
                           select l).ToList();
            dataGridView1.DataSource = lessons;
            label2.Text = lessons.Count.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            FillDataSource();
        }

        private void buttonMentes_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new();
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(sfd.FileName);
                var csv = new CsvWriter(sw, CultureInfo.InvariantCulture);
                var ilist = (from i in context.Instructors select i).ToList();
                csv.WriteRecords(ilist);
                sw.Close();
            }
        }
    }
}
