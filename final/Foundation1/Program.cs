using System;

namespace YoutubeTracker
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Video> videos = new List<Video>();
            using (StreamReader sr = new StreamReader("videos.txt"))
            {
                string line;
                Video video = null;

                while((line = sr.ReadLine()) !=null)
                {
                    string[] parts = line.Split("|");

                    if (parts.Length == 3)
                    {
                        if (video != null)
                        {
                            videos.Add(video);
                            
                        }
                        video = new Video(parts[0], parts[1], int.Parse(parts[2]));
                    }
                    else if (parts.Length==2 && video != null)
                    {
                        Comment comment = new Comment(parts[0], parts[1]);
                        video.AddComment(comment);
                    }
                }
                if (video != null)
                {
                    videos.Add(video);
                }
            }

            foreach (Video video in videos)
            {
                Console.WriteLine($"Titile: {video.Title}");
                Console.WriteLine($"Author: {video.Author}");
                Console.WriteLine($"Length: {video.Length}");
                Console.WriteLine($"Number of comments: {video.GetNumCommnets()}");

                foreach (Comment comment in video.Comments)
                {
                    Console.WriteLine($"Comment by {comment.Name} : {comment.Text}");
                }
                Console.WriteLine();
            }
            Console.WriteLine("It is complete.");
            Console.ReadKey();
        }
        
    }

    

}