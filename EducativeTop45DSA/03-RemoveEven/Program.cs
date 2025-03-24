using System;
using System.Collections;
using System.Collections.Generic;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello World");
        var answer1 = removeEven(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, 10);
        var answer2 = removeEven(new int[] { 1, 2, 10, 15, 17, 19, 20, 21 }, 8);

        Console.WriteLine("Answer1");  //1,3,5,7,9
        for (int i = 0; i < answer1.Length; i++)
        {
            Console.WriteLine(answer1[i]);
        }

        Console.WriteLine("Answer2");// 1,15,17,19, 21
        for (int i = 0; i < answer2.Length; i++)
        {
            Console.WriteLine(answer2[i]);
        }

        Console.ReadLine();
    }

    private static int[] removeEven(int[] Arr, int size)
    {
        // Ask if we're doing in-place replacements or wanting to return a new array
        // Preference is to do the later, instead of the former.
        List<int> oddsOnly = new List<int>(size);
        for (int i = 0; i < size; i++)
        {
            if (Arr[i] % 2 != 0)
                oddsOnly.Add(Arr[i]);
        }
        Arr = oddsOnly.ToArray();
        return Arr;
    }
}