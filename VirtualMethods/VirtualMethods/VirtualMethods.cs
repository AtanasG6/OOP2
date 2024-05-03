namespace VirtualMethods
{
    public class VirtualMethods
    {
        public static void Main()
        {
            Figure[] figures =
            {
                new Line(),
                new Circle(),
                new Line(),
                new SpecialFigure(),
                new Line(),
                new Rectangle()
            };

            foreach (var f in figures)
            {
                f.Draw();
                Console.WriteLine();
            }

            Figure rectangle = new Rectangle();
            ((Rectangle)rectangle).Draw();
        }
    }
}
