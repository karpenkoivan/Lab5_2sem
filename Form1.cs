using System.Numerics;
using Timer = System.Windows.Forms.Timer;

namespace Lab5_2sem
{
    public partial class Form1 : Form
    {
        Circle circle;
        Square square;
        Rhomb rhomb;

        Timer timer = new Timer();
        public Form1()
        {
            InitializeComponent();
            this.Paint += Draw;
            this.DoubleBuffered = true;


            circle = new Circle(50, new Vector2(100, 100));
            square = new Square(100, new Vector2(100, 225));
            rhomb = new Rhomb(75, 100, new Vector2(100, 400));
            timer.Interval = 5;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            Invalidate();
        }

        private void Square_Clicked(object sender, EventArgs e)
        {
            square.SwapState();
        }
        private void Circle_Clicked(object sender, EventArgs e)
        {
            circle.SwapState();
        }
        private void Rhomb_Clicked(object sender, EventArgs e)
        {
            rhomb.SwapState();
        }
        private void Draw(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            square.MoveRight(g);
            circle.MoveRight(g);
            rhomb.MoveRight(g);
        }
    }
}
