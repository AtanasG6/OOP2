namespace Exercise1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World! 2");
            //int num = readNumber();
            //Console.WriteLine($"The sum until {num} is {findSumTillN(num)}.");
            Console.WriteLine("Is 11 prime? " + isPrime(11));
            Console.WriteLine("Is 4 prime? " + isPrime(4));
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

        static bool isPrime(int n)
        {
            if (n < 2)
            {
                return false;
            }

            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}