namespace DrawingApp
{
    public class Rectangle : Shape
    {
        private int x, y, width, height;
        public Rectangle(Pen pen, int x, int y, int width, int height)
        {
            this.pen = pen;
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
        }
        public override void Draw(Graphics g)
        {
            g.DrawRectangle(pen, x, y, width, height);
        }
    }
}