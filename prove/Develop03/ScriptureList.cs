using System;
using System.Collections.Generic;

class ScriptureList {
    private List<Scripture> scriptures = new List<Scripture>();

    public void Add(Scripture scripture) {
        scriptures.Add(scripture);
    }

    public void Remove(string reference) {
        int index = scriptures.FindIndex(s => s.Reference == reference);

        if (index == -1) {
            Console.WriteLine("Scripture not found.");
        } else {
            scriptures.RemoveAt(index);
            Console.WriteLine("Scripture removed.");
        }
    }

    public void PrintAll() {
        if (scriptures.Count == 0) {
            Console.WriteLine("No scriptures stored.");
        } else {
            foreach (Scripture scripture in scriptures) {
                scripture.Print();
            }
        }
    }

    public Scripture GetRandom() {
        if (scriptures.Count == 0) {
            Console.WriteLine("No scriptures stored.");
            return null;
        } else {
            Random random = new Random();
            int index = random.Next(scriptures.Count);
            return scriptures[index];
        }
    }
}
