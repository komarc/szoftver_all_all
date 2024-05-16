namespace Zhfógyakorlasutolso
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            UserControl usercontrol1 = new UserControl1();
            panel1.Controls.Add(usercontrol1);

            usercontrol1.Dock = DockStyle.Fill;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
