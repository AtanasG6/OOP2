﻿//int a = 1; 
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

Profile newProfile = new Profile("New Language", "New Theme", "New Font");
Profile profile = new Profile("Default Language", "Default Theme", "Default Font");

UpdateProfileSettings(profile, newProfile);

Console.WriteLine($"{profile.Language}, {profile.Theme}, {profile.Font}");

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
