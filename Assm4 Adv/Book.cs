using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assm4_Adv
{

    public class Book
    {
        public string ISBN { get; set; }
        public string PublicationDate { get; set; }
        public string Title { get; set; }

        public Book(string isbn, string publicationDate, string title)
        {
            ISBN = isbn;
            PublicationDate = publicationDate;
            Title = title;
        }

        public string GetISBN()
        {
            return ISBN;
        }

        public string GetPublicationDate()
        {
            return PublicationDate;
        }

        public override string ToString()
        {
            return $"{Title} (ISBN: {ISBN}, Published: {PublicationDate})";
        }

        // Delegate Definition
        public delegate string BookDelegate(Book book);

        // Static Methods for BookFunctions
        public static string GetISBN(Book book)
        {
            return book.ISBN;
        }

        public static string GetPublicationDate(Book book)
        {
            return book.PublicationDate;
        }

        // BookProcessor Class within Book Class
        public class BookProcessor
        {
            private List<Book> books;

            public BookProcessor(List<Book> books)
            {
                this.books = books;
            }

            public void ProcessBooks(Func<Book, string> bookFunction)
            {
                foreach (var book in books)
                {
                    string result = bookFunction(book);
                    Console.WriteLine(result);
                }
            }

            // Overloaded method to support user-defined delegate
            public void ProcessBooks(BookDelegate bookFunction)
            {
                foreach (var book in books)
                {
                    string result = bookFunction(book);
                    Console.WriteLine(result);
                }
            }
        }
    }
}
