using System;
using classes;

class Program
{
    static void Main(string[] args)
    {
        Journal journal1 = new Journal();
        journal1.GetChoice();
        classes.File file1 = new classes.File();

       string choice;
       do {
            choice = journal1.GetChoice();
            switch (choice){
                case "1":
                    journal1.Write();
                    break;
                case "2":
                    journal1.DisplayEntry();
                    break;
                // case "3":
                // I have tried to make clear the file tap but failed.
                //     break;
                case "3":
                    string textentry = string.Join("|", journal1.responses);
                    file1.WriteFile(textentry);
                    break;
                case "4":
                    file1.LoadFile();
                    break;
                case "5":
                    break;
            } 
            
       } while (choice != "5");
        
       journal1.DisplayOutro(); 
    
    }
    

        
}