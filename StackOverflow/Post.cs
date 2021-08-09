using System;

namespace StackOverflow
{
    public class Post
    {
        public string Author;
        public string Title;
        public string Body;
        public DateTime TimeOfCreation;
        
    }
        // public int Vote;

        public void MyPost(string author, string title, string body) //TODO not sure how to get the DateTime to have a default value.
        {
            Author = author;
            Title = title;
            Body = body;
        }

        public void MyPost(string author, string title, string body, , DateTime
        {
            var vote = new Vote();

        }




        public DateTime CreatedOn
        {
            get { return TimeOfCreation; }
            set
            {
                TimeOfCreation = value;
                var time = DateTime.Now;
            }
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