using System.Text;

public class Program
{
	static Random random = new Random();
	static void Main(string[] args)
	{
		var nums = new int[] { 4, 0, 5, 4, 8 };
		//InsertionSort(nums);
		//Console.WriteLine(string.Join(", ", nums));

		//int target = BinarySearch(nums, 5);
		//Console.WriteLine("Index of 5 is: " + target);

		//BubbleSort(nums);
		//Console.WriteLine(string.Join(", ", nums));

		//int num = int.Parse(Console.ReadLine());
		//Console.WriteLine(IntToRoman(num));

		//string roman = Console.ReadLine();
		//Console.WriteLine(RomanToInt(roman));

		int length = 2; // Променете дължината на низа при нужда
		string result = GenerateStringWithoutDuplicateSubstrings(length);
		Console.WriteLine("Генериран низ без еднакви съседни поднизове:");
		Console.WriteLine(result);
	}

	public static void InsertionSort(int[] arr) 
	{
		for (int i = 1; i < arr.Length; i++)
		{
			int temp = arr[i];
			int j = i - 1;

			while (j >= 0 && arr[j] > temp) 
			{
				arr[j+1] = arr[j];
				j--;
			}

			arr[j + 1] = temp;
		}
	}

	public static int BinarySearch(int[] arr, int value)
	{
		int low = 0;
		int high = arr.Length - 1;

		while (low <= high)
		{
			int middle = (low + high) / 2;
			int target = arr[middle];

			if (value > target)
			{
				low = middle + 1;
			}
			else if (value < target)
			{
				high = middle - 1;
			}
			else
			{
				return middle;
			}
		}

		return -1;
	}

	public static void BubbleSort(int[] arr)
	{
		for (int i = 0; i < arr.Length - 1; i++)
		{
			for (int j = 0; j < arr.Length - i - 1; j++)
			{
				if (arr[j] > arr[j+1])
				{
					int temp = arr[j];
					arr[j] = arr[j+1];
					arr[j+1] = temp;
				}
			}
		}
	}

	public static string IntToRoman(int num)
	{ 
		var romanMap = new Dictionary<string, int>() 
		{
			{ "M", 1000 },
			{ "CM", 900 },
			{ "D", 500 },
			{ "CD", 400 },
			{ "C", 100 },
			{ "XC", 90 },
			{ "L", 50 },
			{ "XL", 40 },
			{ "X", 10 },
			{ "IX", 9 },
			{ "V", 5 },
			{ "IV", 4 },
			{ "I", 1 }
		};

		StringBuilder sb = new StringBuilder();

        foreach (var item in romanMap)
        {
			while (num >=item.Value)
			{
				sb.Append(item.Key);
				num -= item.Value;
			}
        }

		return sb.ToString();
    }

	public static int RomanToInt(string s)
	{
		var romanMap = new Dictionary<char, int>()
		{
				{'I', 1},
				{'V', 5},
				{'X', 10},
				{'L', 50},
				{'C', 100},
				{'D', 500},
				{'M', 1000}
		};

		int result = 0;

		for (int i = 0; i < s.Length - 1; i++)
		{
			int current = romanMap[s[i]]; 
			int next = romanMap[s[i + 1]]; 

			if (current < next)
			{
				result -= current;
			}
			else
			{
				result += current;
			}
		}

		result += romanMap[s[s.Length - 1]]; 
		return result;
	}


	static string GenerateStringWithoutDuplicateSubstrings(int length)
	{
		string alphabet = "abcdefghijklmnopqrstuvwxyz";
		string result;

		do
		{
			result = GenerateString(length, alphabet);
		} while (HasDuplicateSubstrings(result));

		return result;
	}

	static string GenerateString(int length, string alphabet)
	{
		string result = "";

		for (int i = 0; i < length; i++)
		{
			result += alphabet[random.Next(alphabet.Length)];
		}

		return result;
	}

	static bool HasDuplicateSubstrings(string str)
	{
		for (int i = 1; i <= str.Length / 2; i++)
		{
			if (CheckSubstrings(str, i))
			{
				return true;
			}
		}
		return false;
	}

	static bool CheckSubstrings(string str, int length)
	{
		//Формулата str.Length - 2 * length намира началния индекс на предпоследния възможен подниз с дължина length в низа str.
		for (int i = 0; i <= str.Length - 2 * length; i++)
		{
			string substring1 = str.Substring(i, length);
			string substring2 = str.Substring(i + length, length);
			if (substring1 == substring2)
			{
				return true;
			}
		}
		return false;
	}
}


