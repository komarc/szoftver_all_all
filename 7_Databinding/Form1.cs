using CsvHelper;
using System.ComponentModel;
using System.Globalization;

namespace _7_Databinding
{
    public partial class Form1 : Form
    {
        BindingList<Countrydata> CountryList = new();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {   //masik ZH-s fealdat
            countrydataBindingSource.DataSource = CountryList; // datagridview1 helyett countrydatabindingsource
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("countries.csv");
            var csv = new CsvReader(sr, CultureInfo.InvariantCulture); // kell a using System.Globalization;
            var tömb = csv.GetRecords<Countrydata>();

            foreach (var item in tömb)
            {
                CountryList.Add(item);
            }

            //ssr.Close();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Form2 fec = new Form2();



            if (countrydataBindingSource.Current is Countrydata) // üresség if, nem kötelezõ
            {
                fec.EditedCountryData = (Countrydata)countrydataBindingSource.Current; // ha nincs IF akkor csak ez a sor kell
            }


            fec.Show();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try // try tab tab
                {
                    StreamWriter sw = new StreamWriter(sfd.FileName);
                    var csv = new CsvWriter(sw, CultureInfo.InvariantCulture);
                    csv.WriteRecords(CountryList);

                    sw.Close(); // üres marad a fajl ha nem zarod le 
                }// ami tryba nem sikerul bemegy a catchbe
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message); // kiirja ha nincs meg a fajl, nempedig nem tortenik semmi
                }
            }

        }
    }
}