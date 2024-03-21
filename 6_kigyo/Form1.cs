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

        int irány_x = 1;
        int irány_y = 0;

        int lépésszám = 0;

        List<KígyóElem> kígyó = new List<KígyóElem> ();


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
            lépésszám++;
            fej_x += irány_x * KígyóElem.m;
            fej_y += irány_y * KígyóElem.m;

            foreach (KígyóElem item in Controls)
            {
                if (item.Top == fej_y && item.Left == fej_x)
                {
                    timer1.Enabled = false;
                    return;
                }

            }

            KígyóElem k = new KígyóElem();
            k.Top=fej_y;
            k.Left=fej_x;
            Controls.Add(k);

            kígyó.Add(k);

            if (kígyó.Count>KígyóElem.hossz)
            {
                kígyó.RemoveAt(0);
            }
            if (lépésszám % 2 ==0) { k.BackColor = Color.Yellow; }
            else {k.BackColor = Color.Red; }
        }
        

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up) { irány_x = 0;irány_y = -1; }
            if (e.KeyCode == Keys.Down) { irány_x = 0; irány_y = 1; }
            if (e.KeyCode == Keys.Left) { irány_x = -1; irány_y = 0; }
            if (e.KeyCode == Keys.Right) { irány_x = 1; irány_y = 0; }

           
        }
    }
}