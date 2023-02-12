using System;
using System.Linq;


class Memorization
{
    private static readonly Random random = new Random();

    private ScriptureList scriptures;

    public Memorization(ScriptureList scriptures)
    {
        this.scriptures = scriptures;
    }

    public void Start()
    {
        var scripture = scriptures.GetRandom();

        Console.Clear();
        Console.WriteLine($"{scripture.Reference}: {scripture.Text}");

        string[] words = scripture.Text.Split(' ');
        int[] hiddenIndices = new int[words.Length];
        int hiddenWordCount = 0;

        while (hiddenWordCount < words.Length)
        {
            Console.WriteLine("\nPress enter to hide another word or type 'quit' to end: ");
            string userInput = Console.ReadLine();

            if (userInput.ToLower() == "quit")
            {
                break;
            }

            int randomIndex = random.Next(0, words.Length);

            while (hiddenIndices.Contains(randomIndex))
            {
                randomIndex = random.Next(0, words.Length);
            }

            hiddenIndices[hiddenWordCount] = randomIndex;
            hiddenWordCount++;

            Console.Clear();
            Console.WriteLine(scripture.Reference + ": ");

            for (int i = 0; i < words.Length; i++)
            {
                if (hiddenIndices.Contains(i))
                {
                    Console.Write(new string('_', words[i].Length) + " ");

                }
                else
                {
                    Console.Write(words[i] + " ");
                }
            }
        }

        Console.WriteLine("\nMemory game ended. Well done!");
    }
}

