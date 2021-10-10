using System;

namespace BookLibrary
{
    public class Book
    {
        /// <summary>
        /// Gets or sets the title of the book as a string
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// Gets or sets the name of the Author of the book as a string
        /// </summary>
        public string Author { get; set; }
        /// <summary>
        /// Gets or sets the number of pages in the book as an integer
        /// </summary>
        public int NumberOfPages { get; set; }
        /// <summary>
        /// Gets or sets the ISBN-13 number of the book as a string
        /// </summary>
        public string ISBN13 { get; set; }

        /// <summary>
        /// Represents a book with a unique ISBN-13 number
        /// </summary>
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
