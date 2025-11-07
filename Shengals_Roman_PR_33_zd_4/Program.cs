using System;

class Task4_Note
{
    static void Main()
    {
        Console.ReadLine(); 
        string note = Console.ReadLine();
        string paper = Console.ReadLine();

        string[] noteWords = note.Split(' ');
        string[] paperWords = paper.Split(' ');

        for (int i = 0; i < noteWords.Length; i++)
        {
            bool found = false;
            for (int j = 0; j < paperWords.Length; j++)
            {
                if (noteWords[i] == paperWords[j])
                {
                    paperWords[j] = ""; 
                    found = true;
                    break;
                }
            }
            if (!found)
            {
                Console.WriteLine(noteWords[i]);
                return;
            }
        }
        Console.WriteLine("GOOD NOTE");
    }
}
