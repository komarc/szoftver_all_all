namespace _5_Hajos
{
    public partial class Form1 : Form
    { //bem�solni a txt-t a projektbe
        //a txt tulajdons�g�ban copy if newer-re kell �ll�tani
        List<Kerdes> �sszesK�rd�s;
        List<Kerdes> Aktu�lisK�rd�sek = new List<Kerdes>();
        int megjelen�tettK�rd�sSz�ma = 5; //csak az�rt 5 mert ahhoz van k�p is

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // �sszesK�rd�s = new List<Kerdes>();
            �sszesK�rd�s = K�rd�sBeolvas�s();
            for (int i = 0; i < 7; i++)
            {
                Aktu�lisK�rd�sek.Add(�sszesK�rd�s[0]);
                �sszesK�rd�s.RemoveAt(0);
            }
            dataGridView1.DataSource = Aktu�lisK�rd�sek;

            K�rd�sMegjelen�t�se(Aktu�lisK�rd�sek[megjelen�tettK�rd�sSz�ma]);
        }

        void K�rd�sMegjelen�t�se(Kerdes kerdes)
        {

            label1.Text = kerdes.K�rd�sSz�veg;
            textBox1.Text = kerdes.V�lasz1;
            textBox2.Text = kerdes.V�lasz2;
            textBox3.Text = kerdes.V�lasz3;

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



        List<Kerdes> K�rd�sBeolvas�s()
        {
            List<Kerdes> k�rd�sek = new();
            StreamReader sr = new StreamReader("hajozasi_szabalyzat_kerdessor_BOM.txt", true);
            //be kell z�rni a f�jlt
            while (!sr.EndOfStream)
            {
                string sor = sr.ReadLine() ?? "n/a"; //ha NULL az �rt�k n/a lesz helyette
                //int? string? bool? eset�n NULL-t is visszaadhat
                string[] t�mb = sor.Split("\t");

                if (t�mb.Length != 7) continue;

                Kerdes k = new();
                k.K�rd�sSz�veg = t�mb[1]; // ...t�mb[1].ToUpper(); is l�tezik
                k.V�lasz1 = t�mb[2].Trim('"'); //elej�r�l v�g�r�l leszedi a "
                k.V�lasz2 = t�mb[3].Trim('"');
                k.V�lasz3 = t�mb[4].Trim('"');
                k.URL = t�mb[5];

                int x = 0;
                int.TryParse(t�mb[6], out x); //megprobalj a sz�veget szamma allaktiani, ha sikerul kicsereli ha nem hagyja

                k.HelyesV�lasz = int.Parse(t�mb[6]);

                k�rd�sek.Add(k);
            }


            sr.Close();
            return k�rd�sek;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            megjelen�tettK�rd�sSz�ma++;
            if (megjelen�tettK�rd�sSz�ma == Aktu�lisK�rd�sek.Count) { megjelen�tettK�rd�sSz�ma = 0; } // .Count a lista elem�nek v�g�ig
            K�rd�sMegjelen�t�se(Aktu�lisK�rd�sek[megjelen�tettK�rd�sSz�ma]);
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.Red;
            if (Aktu�lisK�rd�sek[megjelen�tettK�rd�sSz�ma].HelyesV�lasz == 1)
            {
                textBox1.BackColor= Color.Green;
            }
            else
            {
                Aktu�lisK�rd�sek[megjelen�tettK�rd�sSz�ma].HelyesV�laszokSz�ma = 0;
            }
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.BackColor = Color.Red;
            if (Aktu�lisK�rd�sek[megjelen�tettK�rd�sSz�ma].HelyesV�lasz == 2)
            {
                textBox2.BackColor = Color.Green;
            }
            else
            {
                Aktu�lisK�rd�sek[megjelen�tettK�rd�sSz�ma].HelyesV�laszokSz�ma = 0;
            }
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            textBox3.BackColor = Color.Red;
            if (Aktu�lisK�rd�sek[megjelen�tettK�rd�sSz�ma].HelyesV�lasz == 3)
            {
                textBox3.BackColor = Color.Green;
            }
            else
            {
                Aktu�lisK�rd�sek[megjelen�tettK�rd�sSz�ma].HelyesV�laszokSz�ma = 0;
            }
        }
    }
}