namespace Exercise1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World! 2");
            int num = readNumber();
            Console.WriteLine($"The sum until {num} is {findSumTillN(num)}.");
        }

        static int readNumber()
        {
            int num;
            Console.Write("Enter a whole positive (>0) number: ");
            do
            {
                num = int.Parse(Console.ReadLine());
                if (num<=0)
                {
                    Console.Write("Invalid num! Try again: ");
                }
            }while (num<=0);

            return num;
        }

        static int findSumTillN(int n)
        {
            int sum = 0;

            for (int i = 1; i <= n; i++)
            {
                sum += i;
            }

            return sum;
        }
    }
}