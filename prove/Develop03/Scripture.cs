using System;

class Scripture {
    public string Text { get; set; }
    public string Reference { get; set; }

    public static Scripture CreateFromInput() {
        Console.Write("Enter scripture reference: ");
        string reference = Console.ReadLine();
        
        Console.Write("Enter scripture text: ");
        string text = Console.ReadLine();

        

        return new Scripture {Reference = reference,  Text = text};
    }

    public void Print() {
        Console.WriteLine("{0} - {1}", Reference, Text);
    }
}
