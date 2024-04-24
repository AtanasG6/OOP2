namespace Exercise_3
{
    public class MyRectangle
    {
        public Point PointA { get; set; }
        public Point PointB { get; set; }

        public double Perimeter 
        {
            get { return CalcPerimeter(); }
            private set { } 
        }

        public double Face
        {
            get { return CalcFace(); }
            private set { }
        }

        public MyRectangle(Point pointA, Point pointB)
        {
            PointA = pointA;

            PointB = pointB;
        }

        private double CalcPerimeter()
        {
            double dx = Math.Abs(PointA.X - PointB.X);
            double dy = Math.Abs(PointA.Y - PointB.Y);
            double perimeter = 2 * (dx + dy);
            return Math.Round(perimeter, 2);
        }

        private double CalcFace()
        {
            double dx = Math.Abs(PointA.X - PointB.X);
            double dy = Math.Abs(PointA.Y - PointB.Y);

            double face = dx * dy;
            return Math.Round(face, 2);
        }
    }
}
