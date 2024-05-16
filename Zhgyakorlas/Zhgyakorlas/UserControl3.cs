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
    public partial class UserControl3 : UserControl
    {
        StudiesContext context = new StudiesContext();
        public UserControl3()
        {
            InitializeComponent();
            listBox1.DisplayMember = "Name";
        }

        private void UserControl3_Load(object sender, EventArgs e)
        {
            var ilist = (from i in context.Instructors select i).ToList();
            listBox1.DataSource = ilist;
            label1.Text = ilist.Count.ToString();
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null) return;
            Instructor instructor = listBox1.SelectedItem as Instructor;

            var adatok = (from l in context.Instructors
                          where l.InstructorSk == instructor.InstructorSk
                          select new
                          {
                              nev = l.Name,
                              status = l.StatusFkNavigation.Name,
                              allas = l.EmployementFkNavigation.Name
                          }
                          ).ToList();
            dataGridView1.DataSource = adatok.ToList();
            label2.Text = adatok.Count.ToString();
        }
        private void FillData()
        {
            listBox1.DataSource = (from i in context.Instructors where i.Name.Contains(textBox1.Text) select i).ToList();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            FillData();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form = new();
            if (form.ShowDialog() == DialogResult.OK)
            {
                Instructor instructor = new();
                instructor.Name = textBox1.Text;
                //több tábla esetén több item
                context.Instructors.Add(instructor);
                try
                {
                    context.SaveChanges();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }


    }
}
