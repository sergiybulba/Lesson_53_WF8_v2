namespace Lesson_53_WF_8_v2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Rectangle rectangle = new Rectangle();
        Rectangle ellipse = new Rectangle();
        Rectangle circle = new Rectangle();
        Brush brush;
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics Turtle = e.Graphics;
            Turtle.Clear(Color.Black);

            Pen pen = new Pen(Color.FromArgb(100, 180, 32), 25);    // т≥ло
            ellipse = new Rectangle(150, 175, 250, 350);
            Turtle.DrawEllipse(pen, ellipse);
            brush = new SolidBrush(Color.FromArgb(3, 231, 32));
            Turtle.FillEllipse(brush, ellipse);

            ellipse = new Rectangle(190, 105, 170, 125);            // щоки
            Turtle.FillEllipse(brush, ellipse);

            ellipse = new Rectangle(212, 62, 125, 125);             // лоб    
            Turtle.FillEllipse(brush, ellipse);

            ellipse = new Rectangle(95, 380, 75, 75);               // права верхн€ лапа 
            Turtle.FillEllipse(brush, ellipse);

            ellipse = new Rectangle(380, 380, 75, 75);              // л≥ва верхн€ лапа    
            Turtle.FillEllipse(brush, ellipse);

            rectangle = new Rectangle(205, 450, 40, 165);           // права нижн€ лапа 
            Turtle.FillRectangle(brush, rectangle);

            rectangle = new Rectangle(305, 450, 40, 165);           // л≥ва нижн€ лапа 
            Turtle.FillRectangle(brush, rectangle);

            rectangle = new Rectangle(211, 72, 128, 35);           // пов'€зка на голов≥
            brush = new SolidBrush(Color.FromArgb(176, 0, 255));
            Turtle.FillRectangle(brush, rectangle);

            rectangle = new Rectangle(205, 573, 40, 27);           // пов'€зки на нижн≥х лапах
            Turtle.FillRectangle(brush, rectangle);
            rectangle = new Rectangle(305, 573, 40, 27);
            Turtle.FillRectangle(brush, rectangle);

            rectangle = new Rectangle(402, 78, 35, 537);           // палиц€
            brush = new SolidBrush(Color.Olive);
            Turtle.FillRectangle(brush, rectangle);

            rectangle = new Rectangle(402, 288, 35, 167);           // заливка на палиц≥
            brush = new SolidBrush(Color.FromArgb(224, 193, 255));
            Turtle.FillRectangle(brush, rectangle);

            rectangle = new Rectangle(193, 238, 165, 200);           // щит на пуз≥
            brush = new SolidBrush(Color.Yellow);
            Turtle.FillRectangle(brush, rectangle);

            circle = new Rectangle(191, 344, 167, 165);
            Turtle.FillEllipse(brush, circle);

            pen = new Pen(Color.Black, 2);                          // оч≥, праве
            ellipse = new Rectangle(234, 82, 25, 25);
            Turtle.DrawPie(pen, ellipse, 190, 170);
            Turtle.FillPie(Brushes.White, ellipse, 190, 170);

            ellipse = new Rectangle(238, 85, 20, 20);
            Turtle.FillPie(Brushes.Red, ellipse, 190, 170);

            ellipse = new Rectangle(243, 88, 14, 14);
            Turtle.FillPie(Brushes.Black, ellipse, 180, 170);

            ellipse = new Rectangle(245, 87, 4, 4);
            Turtle.FillEllipse(Brushes.White, ellipse);

            ellipse = new Rectangle(287, 82, 25, 25);               // оч≥, л≥ве       
            Turtle.DrawPie(pen, ellipse, 180, 170);
            Turtle.FillPie(Brushes.White, ellipse, 180, 170);

            ellipse = new Rectangle(288, 85, 20, 20);
            Turtle.FillPie(Brushes.Red, ellipse, 180, 170);

            ellipse = new Rectangle(290, 88, 14, 14);
            Turtle.FillPie(Brushes.Black, ellipse, 180, 170);

            ellipse = new Rectangle(297, 87, 4, 4);
            Turtle.FillEllipse(Brushes.White, ellipse);

            ellipse = new Rectangle(211, 115, 128, 80);               // рот
            Turtle.FillPie(Brushes.White, ellipse, 0, 180);
            ellipse = new Rectangle(211, 140, 128, 30);
            Turtle.FillEllipse(Brushes.Black, ellipse);
            ellipse = new Rectangle(210, 140, 130, 25);
            brush = new SolidBrush(Color.FromArgb(3, 231, 32));
            Turtle.FillEllipse(brush, ellipse);
            ellipse = new Rectangle(211, 106, 128, 90);
            pen = new Pen(Color.Black, 10);
            Turtle.DrawArc(pen, ellipse, 5, 170);

            ellipse = new Rectangle(259, 159, 35, 35);                  // зуби
            Turtle.FillPie(Brushes.Black, ellipse, 65, 50);

            ellipse = new Rectangle(255, 130, 9, 9);                    // н≥с
            Turtle.FillEllipse(Brushes.Orange, ellipse);
            ellipse = new Rectangle(285, 130, 9, 9);                    
            Turtle.FillEllipse(Brushes.Orange, ellipse);

        }
    }
}