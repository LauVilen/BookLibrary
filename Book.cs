using System;

namespace BookLibrary
{
    /// <summary>
    /// Represents a book with a unique ISBN-13 number
    /// </summary>
    public class Book
    {
        /// Gets or sets the ISBN-13 number of the book as a string
        /// </summary>
        public string ISBN13 { get; set; }
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
        

        /// <summary>
        /// Creates an instance of a book with an empty constructor
        /// </summary>
        public Book()
        {
            
        }

        /// <summary>
        /// Creates an instance of a book with four parameters to set Title, Author, Number of Pages and the ISBN number
        /// </summary>
        /// <param name="isbn13"></param>
        /// <param name="title"></param>
        /// <param name="author"></param>
        /// <param name="numberOfPages"></param>
        public Book(string isbn13, string title, string author, int numberOfPages)
        {
            ISBN13 = isbn13;
            Title = title;
            Author = author;
            NumberOfPages = numberOfPages;
        }
    }
}
