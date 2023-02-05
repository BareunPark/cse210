using System;

namespace classes{
    public class Journal
    {
        

        public List<string> responses = new List<string>();



        public string GetChoice()
        {
            bool isChoiceValid = false;
            string choice = "";

            do {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Menu");
                Console.WriteLine("Please Select one of the following options:");
                Console.WriteLine("1. Write Journal");
                Console.WriteLine("2. Display Journal");
                // Console.WriteLine("3. Clear");
                Console.WriteLine("3. Save");
                Console.WriteLine("4. Load");
                Console.WriteLine("5. Quit");
               
                

                Console.ForegroundColor = ConsoleColor.DarkGray;
                choice = Console.ReadLine().Trim();
                Console.ForegroundColor = ConsoleColor.White;
                if (choice == "1" || choice == "2" || choice == "3" || choice == "4" || choice == "5" )
                {
                    isChoiceValid = true;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"\"{choice}\" is not a valid option. Please chose 1 - 5");
                    WiatForKey();
                } 

            }while (!isChoiceValid);
            return choice;
        
        }
       
     
        public void DisplayOutro(){
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Thank you for using the app. Bye.");
            WiatForKey();
        }
        public void DisplayEntry()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n=================Journal=================");
            responses.ForEach(Console.WriteLine);
            Console.WriteLine("\n=========================================");
            WiatForKey();
        }

        public void Write()
        {
             
            RandomPromts todayPromt = new RandomPromts();
            todayPromt.RandomPick();
            DateTime current = DateTime.Now;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"\n<{current}>" + todayPromt.PickedPromt());

            string newLine = Console.ReadLine();
            
            responses.Add($"\n<{current}>" + todayPromt.PickedPromt() + $"\n{newLine}\n");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("The journal has been modified");
            WiatForKey();

        }

        public void WiatForKey()
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("\nPress any Key...");
            Console.ReadKey(true);            
        }
            
        
            
                

    }  
}

