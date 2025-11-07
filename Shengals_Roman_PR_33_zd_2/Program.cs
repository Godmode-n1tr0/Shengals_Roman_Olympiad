using System;

class Task2_Palindrome
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            string word = Console.ReadLine();
            word = word.ToUpper();
            string rev = "";
            for (int j = word.Length - 1; j >= 0; j--)
                rev += word[j];
            if (rev == word) Console.WriteLine("YES");
            else Console.WriteLine("NO");
        }
    }
}
