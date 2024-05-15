namespace _9_softw_RemotelDbTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // Ezen a objektumon kereszt�l lehet majd el�rni a t�voli adatb�zis elemeit
        Models.StudentContext studentContext = new Models.StudentContext();

        private void Form1_Load(object sender, EventArgs e)
        {
            studentBindingSource.DataSource = studentContext.Students.ToList();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                studentContext.SaveChanges();
            }
            catch (Exception kiv�tel)
            {
                MessageBox.Show(kiv�tel.InnerException.Message);
            }
        }

        private void textBoxId_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxNeptun_TextChanged(object sender, EventArgs e)
        {
            var er = from x in studentContext.Students 
                     where x.Name.StartsWith(textBoxNeptun.Text)
                     select x;

            studentBindingSource.DataSource = er.ToList();   
        }
    }
}