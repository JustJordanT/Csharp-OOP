using System;

namespace StackOverflow
{
    public class Post
    {
        public string Author = null;
        public string Title = null;
        public string Body = null;
        public DateTime TimeOfCreation = DateTime.Now;
        private int _totalVote = 0;

        // public int Vote;

        public Post(string author, string title, string body) //TODO not sure how to get the DateTime to have a default value.
        {
            Author = author;
            Title = title;
            Body = body;
           
        }

        public Post(string author, string title, string body, DateTime timeOfCreation)
        {
            TimeOfCreation = timeOfCreation;
            // _totalVote = totalVote;

        }

        public int Vote
        {
            get { return _totalVote; }
            private set { _totalVote = value; }
        }

        public int UpVote()
        {
            // Vote++;
            Vote++;
            return 1;
        }

        public int DownVote()
        {
            Vote--;
            return 1;
        }

        public DateTime CreatedOn
        {
            get => TimeOfCreation;
            set
            {
                TimeOfCreation = value;
                var time = DateTime.Now;
            }
        }

        public static void ReadPost()
        {
            Console.WriteLine();
        }
        
        // public string Author { get; set; }
        // public string Title { get; set; }
        // public string Body { get; set; }
        // public DateTime TimeOfCreation
        // {
        //
        //     get { return TimeOfCreation; }
        //     protected set
        //     {
        //         var timeOfCreation = DateTime.Now;
        //     }
        // }
    }
}