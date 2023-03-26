namespace YoutubeTracker
{
    class Video
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Length { get; set; }
        public List<Comment> Comments { get; set; }

        public Video(string title, string author, int lenght)
        {
            Title = title;
            Author = author;
            Length = lenght;
            Comments = new List<Comment>();
        }

        public void AddComment(Comment comment)
        {
            Comments.Add(comment);
        }
        public int GetNumCommnets()
        {
            return Comments.Count;
        }
    }

}