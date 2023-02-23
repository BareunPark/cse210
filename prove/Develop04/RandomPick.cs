public class RandomPick{
    // This was for random pick. I tried to make sure no random prompts/questions are selected until they have all been used at least once in that session. 
    // string random;
    // string [] text;

    // public string RandomPickRun(string filePath)
    // {
    //     TextRead(filePath);


    //     RandomString();
    //     return random;
        
    // }
    // private void TextRead(string filePath)
    // {
    //     using(StreamReader reader = new StreamReader(filePath))
    //     {
    //         string line;
    //         List<string> lines = new List<string>();
    //         while((line = reader.ReadLine()) !=null)
    //         {
    //             lines.Add(line);
    //         }
    //         text = lines.ToArray();
    //     }
    // }
    
    // private void RandomString()
    // {
    //     Random rnd = new Random();
    //     int a = rnd.Next(text.Length);
    //     this.random = text[a];
    // }

    private List<string> usedTexts;
    private string[] text;

    public string RandomPickRun(string filePath)
    {
        TextRead(filePath);
        Shuffle(text);

        if (usedTexts == null)
        {
            usedTexts = new List<string>();

            foreach (string t in text)
            {
                if(!usedTexts.Contains(t))
                {
                    usedTexts.Add(t);
                    return t;
                }
            }
        }

        usedTexts.Clear();
        Shuffle(text);
        usedTexts.Add(text[0]);
        return text[0];

    }

    private void TextRead(string filePath)
    {
        using(StreamReader reader = new StreamReader(filePath))
        {
            string line;
            List<string> lines = new List<string>();
            while((line = reader.ReadLine()) !=null)
            {
                lines.Add(line);
            }
            text = lines.ToArray();
        }
    }

    private void Shuffle<T>(T[] array)
    {
        Random rnd = new Random();
        for (int i = array.Length - 1; i > 0; i--)
        {
            int j = rnd.Next(i + 1);
            T temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
    }
}