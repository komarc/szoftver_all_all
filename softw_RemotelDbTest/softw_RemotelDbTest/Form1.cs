namespace _9_softw_RemotelDbTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // Ezen a objektumon keresztül lehet majd elérni a távoli adatbázis elemeit
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
            catch (Exception kivétel)
            {
                MessageBox.Show(kivétel.InnerException.Message);
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