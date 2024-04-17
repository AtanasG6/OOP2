//int a = 1; 
//int b = 2;
//Swap(ref a, ref b);
//Console.WriteLine($"a = {a}; b = {b}");

//int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };

//int min, avg, max;
//ArrStats(arr, out min, out avg, out max);

//Console.WriteLine($"Min = {min}. Avg = {avg}. Max = {max}.");
//bool isEven, isOdd;
//int num1 = 10,
//    num2 = 11;

//isEvenOrOdd(num1, out isEven, out isOdd);
//Console.WriteLine($"num1 = {num1}: isEven = {isEven}, isOdd = {isOdd}.");
//isEvenOrOdd(num2, out isEven, out isOdd);
//Console.WriteLine($"num1 = {num2}: isEven = {isEven}, isOdd = {isOdd}.");

//Profile newProfile = new Profile("New Language", "New Theme", "New Font");
//Profile profile = new Profile("Default Language", "Default Theme", "Default Font");
//Console.ForegroundColor = ConsoleColor.Cyan;
//Console.WriteLine($"Current settings: {profile.Language}, {profile.Theme}, {profile.Font}");
//Console.ResetColor();
//UpdateProfileSettings(profile, newProfile);
//Console.ForegroundColor= ConsoleColor.Yellow;
//Console.WriteLine($"Settings update! New settings: {profile.Language}, {profile.Theme}, {profile.Font}");
//Console.ResetColor();


//long factorial;
//int num = 7;
//Factorial(num, out factorial);
//Console.WriteLine($"Factorial of {num} is {factorial}.");

//string[] arr = { "Doe", "Max", "Peter" };

//ReplaceElement(arr, "Max", "Carlos");
//Console.WriteLine(string.Join(", ", arr));

int[] arr = new int[] {1,2,3,4,5,6};
int[] evenArr, oddArr;
SplitArray(arr, out evenArr, out oddArr);

Console.WriteLine(string.Join(", ", evenArr));
Console.WriteLine(string.Join(", ", oddArr));

static void Swap(ref int a, ref int b)
{
    int temp = a;
    a = b;
    b = temp;
}

static void ArrStats(int[] arr, out int min, out int avg, out int max)
{
    min = arr.Min();
    max = arr.Max();
    avg = (int)arr.Average();
}

static void isEvenOrOdd(int num, out bool isEven, out bool isOdd)
{
    if (num % 2 == 0)
    {
        isEven = true;
        isOdd = false;
    }
    else
    {
        isEven = false;
        isOdd = true;
    }
}


static void Factorial(int n, out long factorial)
{
    long result = 1;

    while (n >= 1)
    {
        result *= n;
        n--;
    }

    factorial = result;
}

static void ReplaceElement(string[] array, string symbolToReplace, string newSymbol)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == symbolToReplace)
        {
            array[i] = newSymbol;
        }
    }
}

static void SplitArray(int[] arr, out int[] evenArr, out int[] oddArr)
{
    int countEvenArr = 0, countOddArr = 0;

    foreach (int num in arr)
    {
        if (num % 2 == 0)
        {
            countEvenArr++;
        }
        else if (num % 2 == 1) 
        {
            countOddArr++;
        }
    }

    int[] evenArray = new int[countEvenArr];
    int[] oddArray = new int[countOddArr];

    int j = 0, k = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            evenArray[j] = arr[i];
            j++;
        }
        else if (arr[i] % 2 == 1)
        {
           oddArray[k] = arr[i];
            k++;
        }
    }

    evenArr = evenArray;
    oddArr = oddArray;
}

static void UpdateProfileSettings(Profile oldProfile, Profile newProfile)
{
    oldProfile.Language = newProfile.Language;
    oldProfile.Theme = newProfile.Theme;
    oldProfile.Font = newProfile.Font;
}

class Profile
{
    public string Language { get; set; }
    public string Theme { get; set; }
    public string Font { get; set; }

    public Profile(string language, string theme, string font)
    {
        Language = language;
        Theme = theme; 
        Font = font;
    }
}






