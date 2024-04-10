namespace Exercise1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World! 2");
            //int num = readNumber();
            //Console.WriteLine($"The sum until {num} is {findSumTillN(num)}.");
            //Console.WriteLine("Is 11 prime? " + isPrime(11));
            //Console.WriteLine("Is 4 prime? " + isPrime(4));
            //Console.WriteLine(findSum(new decimal[] { 180.09m, 277.08m, 1.1m, 1000.1m, 1.1m }));
            Console.WriteLine(arePricesEqual(new decimal[] { 3m }, new decimal[] { 3.25m }));
            Console.WriteLine(isLeap(2024));
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
                    Console.Write("Invalid number! Try again: ");
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

        static decimal findSum(decimal[] arr)
        {
            decimal sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }

            return sum;
        }

        static bool arePricesEqual(decimal[] euroArr, decimal[] usdArr)
        {
         
            decimal[] tempArr1 = new decimal[euroArr.Length];
            decimal[] tempArr2 = new decimal[usdArr.Length];

            for (int i = 0; i < euroArr.Length; i++)
            {
                tempArr1[i] = euroArr[i] * 1.95m;
            }

            for (int i = 0; i < euroArr.Length; i++)
            {
                tempArr2[i] = euroArr[i] * 1.80m;
            }

            for (int i = 0; i < euroArr.Length; i++)
            {
                if (tempArr1[i] != tempArr2[i])
                {
                    return false; 
                }
            }

            return true; 
        }


        static bool isLeap(int year) => (year % 4 == 0) && (year % 100 != 0 || year % 400 == 0);


        static int GetDaysInMonth(int year, int month)
        {
            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    return 31;
                case 4:
                case 6:
                case 9:
                case 11:
                    return 30;
                case 2:
                    return isLeap(year) ? 29 : 28;
                default:
                    throw new ArgumentOutOfRangeException("month", "Month must be in range 1-12.");
            }
        }

    }
}