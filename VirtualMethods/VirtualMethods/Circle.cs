namespace VirtualMethods
{
    public class Circle : Figure
    {
        public override void Draw()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("I am a circle:");
            Console.WriteLine(" --- ");
            Console.WriteLine("|   |");
            Console.WriteLine(" --- ");
            Console.ResetColor();
        }
    }
}
