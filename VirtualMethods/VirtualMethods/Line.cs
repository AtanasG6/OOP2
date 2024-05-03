namespace VirtualMethods
{
    public class Line : Figure
    {
        public override void Draw()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("I am a line:");
            Console.WriteLine("-----");
            Console.ResetColor();
        }
    }
}
