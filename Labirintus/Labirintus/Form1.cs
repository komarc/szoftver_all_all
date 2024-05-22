using System.Diagnostics;
using System.Reflection.Metadata;

namespace Labirintus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        PictureBox player = new PictureBox();
        PictureBox cel = new PictureBox();

        List<PictureBox> falak = new List<PictureBox>();
        int second = 0;
        int minute = 0;
        int steps = 0;
        int last_x = 0;
        int last_y = 0;

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    StreamReader sr = new StreamReader(ofd.FileName);
                    int y = 0;
                    while (!sr.EndOfStream)
                    {
                        string sor = sr.ReadLine();
                        for (int x = 0; x < sor.Length; x++)
                        {
                            if (sor[x] == '#')
                            {
                                PictureBox pb = new PictureBox();
                                pb.Location = new Point(x * 20, y * 20);
                                pb.Size = new Size(20, 20);
                                pb.BackColor = Color.Black;
                                this.Controls.Add(pb);
                                falak.Add(pb);
                                last_x = x * 20;

                            }
                        }
                        last_y = y * 20;
                        y++;
                    }

                    player.Location = new Point(0, 0);
                    player.Size = new Size(20, 20);
                    player.BackColor = Color.Red;
                    Controls.Add(player);

                    cel.Location = new Point(last_x + 20, last_y);
                    cel.Size = new Size(20, 20);
                    cel.BackColor = Color.Purple;
                    Controls.Add(cel);



                    Controls.Remove(button1);

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

            int x = player.Location.X;
            int y = player.Location.Y;

            if (e.KeyCode == Keys.Right)
            {

                x += 20;
            }
            if (e.KeyCode == Keys.Left)
            {

                x -= 20;
            }
            if (e.KeyCode == Keys.Up)
            {

                y -= 20;
            }
            if (e.KeyCode == Keys.Down)
            {

                y += 20;
            }



            var wall = falak.FirstOrDefault(w => w.Location.X == x && w.Location.Y == y);

            if (wall == null)
            {


                if (y >= ClientRectangle.Y && x >= ClientRectangle.X)
                {
                    player.Location = new Point(x, y);
                    steps++;
                    timer1.Enabled = true;
                    if (player.Bounds.IntersectsWith(cel.Bounds))
                    {
                        timer1.Enabled = false;
                        MessageBox.Show($"Nyertél ennyi idõ alatt:{minute}:{second} és ennyi lépéssel: {steps}");
                        Restart();
                    }
                }

            }

            label5.Text = steps.ToString();
        }
        private void Restart()
        {
            second = 0;
            minute = 0;
            steps = 0;
            player.Location = new Point(0, 0);
            label4.Text = "0";
            label5.Text = "0";
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            second++;
            if (second == 60)
            {
                second = 0;
                minute++;
            }
            label4.Text = ($"{minute}:{second}").ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Restart();
        }
    }
}
