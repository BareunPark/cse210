using System;

class RandomPromts
{
    string rndPromt;
    
    string[] promts = 
    {"Who was the most intersting person I interacted with today?", 
    "What was the best part of my day?",
    "How did I see the hand of the Loard in my life today?",
    "What was the strongest emotion I felt today?",
    "If I had one thing I could do over today, what would it be?"
    };
    public void RandomPick()
    {
        Random rnd = new Random();
        int a = rnd.Next(promts.Length);
        
        this.rndPromt = promts[a];
        
    }

    public string PickedPromt()
    {
        return this.rndPromt;
    }
}

