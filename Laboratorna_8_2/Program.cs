using System;

public class Program
{
    public static int CountWordsStartingWithB(string input)
    {
        int count = 0;

        string[] words = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        foreach (string word in words)
        {
            if (word.Length > 0 && (word[0] == 'b' || word[0] == 'B'))
            {
                count++;
            }
        }

        return count;
    }

    static void Main()
    {
        Console.WriteLine("Введіть літерний рядок:");
        string input = Console.ReadLine();

        int result = CountWordsStartingWithB(input);

        Console.WriteLine($"Кількість слів, що починаються з 'b': {result}");
    }
}