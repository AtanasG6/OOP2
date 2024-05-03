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
                new Line()
            };

            foreach (var f in figures)
            {
                f.Draw();
                Console.WriteLine();
            }

            //Figure circle = new Circle();
            //circle.Draw();
        }
    }
}
