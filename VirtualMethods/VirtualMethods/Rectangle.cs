namespace VirtualMethods
{
    public class Rectangle : Figure
    {
        public new void Draw()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("I am a rectangle:");
            Console.WriteLine("-----");
            Console.WriteLine("|   |");
            Console.WriteLine("-----");
            Console.ResetColor();
        }
    }
}
