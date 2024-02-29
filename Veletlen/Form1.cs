namespace Veletlen
{
    public partial class Form1 : Form
    {
        Random rnd = new Random(); //kell
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 100; i++)
            {
                Button button = new Button();
                Controls.Add(button);
                button.Size = new Size(20, 20);
                button.Width = rnd.Next(10,100); // min 10es  mretet max 100
                button.Height = rnd.Next(10,100);
                button.Left = rnd.Next(ClientRectangle.Width);//nem log igy ki a gomb ,alapbol a bal felso poziciot adja meg és igy kiolghat de igy nem
                button.Top = rnd.Next(ClientRectangle.Width);
            }
        }
    }
}