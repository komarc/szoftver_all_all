namespace _6_kigyo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int fej_x = 100;
        int fej_y = 100;

        int ir�ny_x = 1;
        int ir�ny_y = 0;

        int l�p�ssz�m = 0;

        List<K�gy�Elem> k�gy� = new List<K�gy�Elem> ();


        private void Form1_Load(object sender, EventArgs e)
        {
            List<string> list = new List<string>();
            for (int i = 0; i < list.Count; i++)
            {
                //list [i]
            }
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            l�p�ssz�m++;
            fej_x += ir�ny_x * K�gy�Elem.m;
            fej_y += ir�ny_y * K�gy�Elem.m;

            foreach (K�gy�Elem item in Controls)
            {
                if (item.Top == fej_y && item.Left == fej_x)
                {
                    timer1.Enabled = false;
                    return;
                }

            }

            K�gy�Elem k = new K�gy�Elem();
            k.Top=fej_y;
            k.Left=fej_x;
            Controls.Add(k);

            k�gy�.Add(k);

            if (k�gy�.Count>K�gy�Elem.hossz)
            {
                k�gy�.RemoveAt(0);
            }
            if (l�p�ssz�m % 2 ==0) { k.BackColor = Color.Yellow; }
            else {k.BackColor = Color.Red; }
        }
        

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up) { ir�ny_x = 0;ir�ny_y = -1; }
            if (e.KeyCode == Keys.Down) { ir�ny_x = 0; ir�ny_y = 1; }
            if (e.KeyCode == Keys.Left) { ir�ny_x = -1; ir�ny_y = 0; }
            if (e.KeyCode == Keys.Right) { ir�ny_x = 1; ir�ny_y = 0; }

           
        }
    }
}