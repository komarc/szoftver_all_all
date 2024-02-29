namespace Feladatok_3het
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Button B = new Button();
            Controls.Add(B);
            B.Left = ClientRectangle.Width / 2 - B.Width / 2;
            B.Top = ClientRectangle.Width / 2 - B.Height / 2;

            for (int sor = 0; sor < 20; sor++)
            {
                for (int oszlop = 0; oszlop < 20; oszlop++)
                {
                        VillogoGomb gombok = new VillogoGomb();
                        Controls.Add(gombok);
                    gombok.Size = new Size(20, 20);
                    gombok.Top = oszlop * 20; // milyen messze legyen a tetejetol
                    gombok.Left = sor * 20;
                }
            }
        
        
        }
    }
}