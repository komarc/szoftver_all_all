namespace Haromszog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int sor = 0; sor < 10; sor++)
            {
                for (int oszlop = 0; oszlop < 10; oszlop++)
                {
                    if (sor >= oszlop)
                    {
                        Button button = new Button();
                        Controls.Add(button);
                        button.Size = new Size(40, 40);
                        button.Top = sor*40;//ne rakja egybe, size=top
                        button.Left = oszlop*40;
                    }

                }
            }
        }
    }
}