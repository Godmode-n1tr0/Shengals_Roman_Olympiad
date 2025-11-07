using System;

class Task3_Snowmen
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string[] s = Console.ReadLine().Split();
        long[] d = new long[2 * n];
        for (int i = 0; i < 2 * n; i++) d[i] = long.Parse(s[i]);

        Array.Sort(d); 
        for (int i = 0; i < 2 * n; i += 2)
        {
            Console.WriteLine((i + 2) + " " + (i + 1)); 
        }
    }
}
