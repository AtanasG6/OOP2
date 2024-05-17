namespace DrawingApp
{
    public class Line : Shape
    {
        private int x1, y1, x2, y2;
        public Line(Pen pen, int x1, int y1, int x2, int y2)
        {
            this.pen = pen;
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
        }
        public override void Draw(Graphics g)
        {
            g.DrawLine(pen, x1, y1, x2, y2);
        }
    }
}