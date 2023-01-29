using System;

class Journal
{
    
    private string JournalFile = "MyJournal.txt";
    public void Run()
    {
        
        DisplayIntro();
        CreateJournalFile();
        RunMenu();
        DisplayOutro();

    }

    public void RunMenu()
    {
        string choice;
        do
        {
            choice = GetChoice();
            switch (choice)
            {
                case "1":
                    AddEntry();
                    break;
                case "2":
                    DisplayJournalContents();
                    break;
                case "3":
                    ClearFile();
                    break;
                case "4":
                    break;
            }
        } while (choice != "4");
    }

    private string GetChoice()
    {
        bool isChoiceValid = false;
        string choice = "";

        do
        {

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkGray;
            // Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nWhat would you like to do?");
            Console.WriteLine(" > 1 - Add to the journal");
            Console.WriteLine(" > 2 - Read the journal");
            Console.WriteLine(" > 3 - Clear the journal");
            Console.WriteLine(" > 4 - Quit");

            Console.ForegroundColor = ConsoleColor.DarkGray;
            choice = Console.ReadLine().Trim();
            Console.ForegroundColor = ConsoleColor.White;

            if (choice == "1" || choice == "2" || choice == "3" || choice == "4")
            {
                isChoiceValid = true;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"\"{choice}\" is not a valid option. Please chose 1 - 4");
                WaitForKey();
            }
        } while (!isChoiceValid);
        return choice;
    }

    private void CreateJournalFile() {
        // Console.WriteLine($"Does file exist? {System.IO.File.Exists("MyJournal.txt")}");
        if (!File.Exists(JournalFile))
        {
            File.CreateText(JournalFile);
        }
    }

    private void DisplayIntro() {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("Journal App.");
        WaitForKey();
    }

    private void DisplayOutro () {
        
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("Thank You.");
        WaitForKey();
    }

    private void WaitForKey()
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine("\nPress any Key...");
        Console.ReadKey(true);
    }

    private void DisplayJournalContents() {

        Console.ForegroundColor = ConsoleColor.White;
        string journalText = File.ReadAllText(JournalFile);
        Console.WriteLine("\n-------Journal-------");
        Console.WriteLine(journalText);
        Console.WriteLine("---------------------");
        WaitForKey();
    }

    private void ClearFile() {

        Console.ForegroundColor = ConsoleColor.White;
        File.WriteAllText(JournalFile, "");
        Console.WriteLine("\nFile Cleared");
        WaitForKey();
    }

    private void AddEntry () {
        
        RandomPromts todayPromt = new RandomPromts();
        todayPromt.RandomPick();

        
        DateTime current = DateTime.Now;
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine($"\n<{current}>" + todayPromt.PickedPromt());
        
        
        string newLine = Console.ReadLine();
        File.AppendAllText(JournalFile, $"\n<{current}>" + todayPromt.PickedPromt() + $"\n{newLine}\n");
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine("The journal has been modified");
        WaitForKey();

    }

}