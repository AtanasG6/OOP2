using System;
using System.Windows.Forms;

namespace DrawingApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Pen p = new Pen(Color.Magenta, 5);
        private bool drawLine = false;
        private bool drawRectangle = false;
        private List<Shape> shapes = new List<Shape>();
        private Random random = new Random();

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = pnl.CreateGraphics();
            foreach (Shape shape in shapes)
            {
                shape.Draw(g);
            }
        }

        private void drawLineBtn_Click(object sender, EventArgs e)
        {
            shapes.Add(new Line(p, random.Next(0, pnl.Width - 50), random.Next(0, pnl.Height - 50), random.Next(0, pnl.Width - 50), random.Next(0, pnl.Height - 50)));
            Invalidate();
        }

        private void drawRectangleBtn_Click(object sender, EventArgs e)
        {
            var x = random.Next(0, pnl.Width);
            var y = random.Next(0, pnl.Height);
            shapes.Add(new Rectangle(p, x, y, random.Next(0, pnl.Width - x - 1), random.Next(0, pnl.Height - y - 1)));
            Invalidate();
        }

        private void ColorPickerBtn_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                p.Color = colorDialog.Color;
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            shapes.Clear();
            pnl.Invalidate();
        }
    }
}