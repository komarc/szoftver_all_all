using _10_Csillagterkep.Models;

namespace _10_Csillagterkep
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           Graphics g = this.CreateGraphics();

            Pen pen = new Pen(Color.Black);
             
            Brush brush = new SolidBrush(Color.White);

           // g.FillEllipse(brush, 0, 0, 100, 100); //kör, bal felso sarok, szelesseg, magassag

            hajosContext context = new hajosContext();

            var stars = (from x in context.StarData
                         //orderby x.Y
                         select new { x.Hip, x.Magnitude, x.X, x.Y }).ToList();
                        
            g.Clear(Color.DarkBlue);

            double nagyítás = 300;
            int cx = ClientRectangle.Width / 2;
            int cy = ClientRectangle.Height / 2;


            foreach ( var star in stars )
            {
                //if (star.Magnitude>6){continue; }
                //if (Math.Sqrt(Math.Pow(star.X, 2) + Math.Pow(star.Y, 2)) > 1) continue;


                double x = star.X * nagyítás + cx;
                double y = star.Y * nagyítás + cy;

                double size = 20 * Math.Pow(10, star.Magnitude / -2.5);

               // g.FillEllipse(brush, (float)x, (float)y, 1, 1);
                g.FillEllipse(brush, (float)x, (float)y, (float)size, (float)size);
            }

            var lines = context.ConstellationLines.ToList();

            foreach ( var line in lines )
            {
                var star1 = (from x in stars
                            where x.Hip == line.Star1
                             select x).FirstOrDefault(); 
                
                var star2 = (from x in stars
                            where x.Hip == line.Star2
                             select x).FirstOrDefault();

                double x1 = star1.X * nagyítás + cx;
                double y1 = star1.Y * nagyítás + cy;

                if (star1 is null || star2 is null) { continue; }
                
                double x2 = star2.X * nagyítás + cx;
                double y2 = star2.Y * nagyítás + cy;

                g.DrawLine(pen, (float)x1, (float)y1, (float)x2, (float)y2);
            }



        }
    }
}