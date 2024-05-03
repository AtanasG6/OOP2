namespace VirtualMethods
{
    public abstract class Figure
    {
        public virtual void Draw()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"I am a figure of unknown kind: {this.GetType().Name}");
            Console.ResetColor();
        }

    }
}
