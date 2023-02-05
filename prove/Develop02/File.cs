using System.IO;

namespace classes{
    public class File 
    {
        public void WriteFile(string text){

            
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("What is the file name? include .txt");
            string _fileName = Console.ReadLine();
            using (StreamWriter outputFile = new StreamWriter(_fileName))
            {

            outputFile.WriteLine(text);
    
            
        
            }
            WiatForKey();
        }   

        public void LoadFile(){
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("What is the filename? Include .txt");
            
            string filename = Console.ReadLine();
            string[] lines = System.IO.File.ReadAllLines(filename);
            
            Console.WriteLine("\n=================Journal=================");
            foreach (string line in lines)
            {
                
                string[] parts = line.Split("|");
                foreach (string part in parts)
                {
                    Console.WriteLine(part);
                }
                
            }
            Console.WriteLine("\n=========================================");
            WiatForKey();
            
        }
        private void WiatForKey()
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("\nPress any Key...");
            Console.ReadKey(true);            
        }
    }
}