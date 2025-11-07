using System;

class Task1_Fish
{
    static void Main()
    {
        string[] s = Console.ReadLine().Split();
        int k = int.Parse(s[0]);
        int n = int.Parse(s[1]);
        Console.WriteLine(n / k);
    }
}
