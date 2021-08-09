using System;

namespace Library
{
    public class Book
    {

        public string title;
        public string author;
        public int pages;

        
        
        //This is a constructor
        public Book()
        {
            //Expression
        }

        //This is a constructor
        public Book(string aTitle, string aAuthor, int aPages)
        {
            title = aTitle;
            author = aAuthor;
            pages = aPages;

        }
    }
}