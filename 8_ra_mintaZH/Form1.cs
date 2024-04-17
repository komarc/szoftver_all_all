using CsvHelper;
using System.ComponentModel;
using System.Globalization;

namespace _8_ra_mintaZH
{
    public partial class Form1 : Form
    {
        BindingList<Versenyzo> Vlista = new BindingList<Versenyzo>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                StreamReader sr = new StreamReader("futoversenyzok.csv");
                var csv = new CsvReader(sr, CultureInfo.InvariantCulture);
                var t�mb = csv.GetRecords<Versenyzo>();

                foreach (var k in t�mb)
                {
                    Vlista.Add(k);
                }

                sr.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            versenyzoBindingSource.DataSource = Vlista;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    StreamWriter sw = new StreamWriter(sfd.FileName);
                    var csv = new CsvWriter(sw, CultureInfo.InvariantCulture);
                    csv.WriteRecords(Vlista);

                    sw.Close();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (versenyzoBindingSource.Current == null)
            {
                return;
            }
            if (MessageBox.Show("Biztos t�r�lni akarod?", "T�rl�s", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                versenyzoBindingSource.RemoveCurrent();
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            Form2 fec = new();


            if (versenyzoBindingSource.Current is Versenyzo)
            {
                fec.versenyzo = (Versenyzo)versenyzoBindingSource.Current;


            }
            fec.Show();
        }

        private void buttonKerdes_Click(object sender, EventArgs e)
        {
            double minimum = double.PositiveInfinity;
            double maximum = double.NegativeInfinity;

            //leggyorsabban futo futonak a neve
            string leggyorsabb = string.Empty;

            foreach (var item in Vlista)
            {
                if (item.EredmenyPerc<minimum)
                {
                    minimum = item.EredmenyPerc;
                    leggyorsabb = item.Nev;
                }
            }


            


            decimal �sszeg = 0;
            int darab = 0;

            foreach (var item in Vlista)
            {
               // �sszeg += item.EredmenyPerc; // �sszes versenyz� �sszes eredm�nye
                if (item.Nemzetiseg == "USA")
                {
                    �sszeg += item.EredmenyPerc;
                    darab++;
                }
            }

            decimal atlag = �sszeg/darab;



            MessageBox.Show($"A legjobb id� {minimum}");


        }
    }
}
