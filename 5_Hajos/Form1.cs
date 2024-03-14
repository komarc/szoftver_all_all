namespace _5_Hajos
{
    public partial class Form1 : Form
    { //bemásolni a txt-t a projektbe
        //a txt tulajdonságában copy if newer-re kell állítani
        List<Kerdes> ÖsszesKérdés;
        List<Kerdes> AktuálisKérdések = new List<Kerdes>();
        int megjelenítettKérdésSzáma = 5; //csak azért 5 mert ahhoz van kép is

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // ÖsszesKérdés = new List<Kerdes>();
            ÖsszesKérdés = KérdésBeolvasás();
            for (int i = 0; i < 7; i++)
            {
                AktuálisKérdések.Add(ÖsszesKérdés[0]);
                ÖsszesKérdés.RemoveAt(0);
            }
            dataGridView1.DataSource = AktuálisKérdések;

            KérdésMegjelenítése(AktuálisKérdések[megjelenítettKérdésSzáma]);
        }

        void KérdésMegjelenítése(Kerdes kerdes)
        {

            label1.Text = kerdes.KérdésSzöveg;
            textBox1.Text = kerdes.Válasz1;
            textBox2.Text = kerdes.Válasz2;
            textBox3.Text = kerdes.Válasz3;

            if (string.IsNullOrEmpty(kerdes.URL))
            {
                pictureBox1.Visible = false;
            }
            else
            {
                pictureBox1.Visible = true;
                pictureBox1.Load("https://storage.altinum.hu/hajo/" + kerdes.URL);
            }

            textBox1.BackColor = Color.White;
            textBox2.BackColor = Color.White;
            textBox3.BackColor = Color.White;
        }



        List<Kerdes> KérdésBeolvasás()
        {
            List<Kerdes> kérdések = new();
            StreamReader sr = new StreamReader("hajozasi_szabalyzat_kerdessor_BOM.txt", true);
            //be kell zárni a fájlt
            while (!sr.EndOfStream)
            {
                string sor = sr.ReadLine() ?? "n/a"; //ha NULL az érték n/a lesz helyette
                //int? string? bool? esetén NULL-t is visszaadhat
                string[] tömb = sor.Split("\t");

                if (tömb.Length != 7) continue;

                Kerdes k = new();
                k.KérdésSzöveg = tömb[1]; // ...tömb[1].ToUpper(); is létezik
                k.Válasz1 = tömb[2].Trim('"'); //elejérõl végérõl leszedi a "
                k.Válasz2 = tömb[3].Trim('"');
                k.Válasz3 = tömb[4].Trim('"');
                k.URL = tömb[5];

                int x = 0;
                int.TryParse(tömb[6], out x); //megprobalj a szöveget szamma allaktiani, ha sikerul kicsereli ha nem hagyja

                k.HelyesVálasz = int.Parse(tömb[6]);

                kérdések.Add(k);
            }


            sr.Close();
            return kérdések;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            megjelenítettKérdésSzáma++;
            if (megjelenítettKérdésSzáma == AktuálisKérdések.Count) { megjelenítettKérdésSzáma = 0; } // .Count a lista elemének végéig
            KérdésMegjelenítése(AktuálisKérdések[megjelenítettKérdésSzáma]);
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.Red;
            if (AktuálisKérdések[megjelenítettKérdésSzáma].HelyesVálasz == 1)
            {
                textBox1.BackColor= Color.Green;
            }
            else
            {
                AktuálisKérdések[megjelenítettKérdésSzáma].HelyesVálaszokSzáma = 0;
            }
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.BackColor = Color.Red;
            if (AktuálisKérdések[megjelenítettKérdésSzáma].HelyesVálasz == 2)
            {
                textBox2.BackColor = Color.Green;
            }
            else
            {
                AktuálisKérdések[megjelenítettKérdésSzáma].HelyesVálaszokSzáma = 0;
            }
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            textBox3.BackColor = Color.Red;
            if (AktuálisKérdések[megjelenítettKérdésSzáma].HelyesVálasz == 3)
            {
                textBox3.BackColor = Color.Green;
            }
            else
            {
                AktuálisKérdések[megjelenítettKérdésSzáma].HelyesVálaszokSzáma = 0;
            }
        }
    }
}