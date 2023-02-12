using System;

class Program {
    static void Main(string[] args) {
        AppControl appControl = new AppControl();
        appControl.Run();
    }
}

class AppControl {
    private ScriptureList scriptures = new ScriptureList();
    private Memorization memorization;

    public AppControl() {
        memorization = new Memorization(scriptures);
    }

    public void Run() {
        while (true) {
            Console.WriteLine("Select an option:");
            Console.WriteLine("1. Store a scripture");
            Console.WriteLine("2. Store multiple scriptures");
            Console.WriteLine("3. List of scriptures");
            Console.WriteLine("4. Remove a scripture");
            Console.WriteLine("5. Memorization");
            Console.WriteLine("6. Quit");

            int option = int.Parse(Console.ReadLine());

            switch (option) {
                case 1:
                    scriptures.Add(Scripture.CreateFromInput());
                    Console.WriteLine("Scripture stored.");
                    break;
                case 2:
                    while (true) {
                        Scripture scripture = Scripture.CreateFromInput();

                        if (string.IsNullOrEmpty(scripture.Text) || string.IsNullOrEmpty(scripture.Reference)) {
                            break;
                        }

                        scriptures.Add(scripture);
                        Console.WriteLine("Scripture stored.");
                    }
                    break;
                case 3:
                    scriptures.PrintAll();
                    break;
                case 4:
                    Console.Write("Enter scripture reference to remove: ");
                    string reference = Console.ReadLine();
                    scriptures.Remove(reference);
                    break;
                case 5:
                    memorization.Start();
                    break;
                case 6:
                    return;
                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }

            Console.WriteLine();
        }
    }
}
