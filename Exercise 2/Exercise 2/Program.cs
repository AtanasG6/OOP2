﻿//int a = 1; 
//int b = 2;
//Swap(ref a, ref b);
//Console.WriteLine($"a = {a}; b = {b}");

int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };

int min, avg, max;
ArrStats(arr, out min, out avg, out max);

Console.WriteLine($"Min = {min}. Avg = {avg}. Max = {max}.");

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