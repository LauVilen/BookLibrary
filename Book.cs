using System;

namespace BookLibrary
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int NumberOfPages { get; set; }
        public string ISBN13 { get; set; }

        public Book()
        {
            
        }

        public Book(string title, string author, int numberOfPages, string isbn13)
        {
            Title = title;
            Author = author;
            NumberOfPages = numberOfPages;
            ISBN13 = isbn13;
        }
    }
}
