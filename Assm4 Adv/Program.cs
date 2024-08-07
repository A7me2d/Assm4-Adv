using System.Diagnostics;

namespace Assm4_Adv
{
    internal class Program
    {
        #region Part01 1-Creating a User-Defined Delegate

        public delegate string BookDelegate(Book book);

        #endregion

        static void Main(string[] args)
        {

            #region Past01

            #region 2-Using Built-in Delegates
            //    List<Book> books = new List<Book>
            //{
            //    new Book("978-3-16-148410-0", "2021-01-01", "Book One"),
            //    new Book("978-1-4028-9462-6", "2022-05-15", "Book Two"),
            //    new Book("978-0-545-01022-1", "2023-07-20", "Book Three")
            // };
            //    Book.BookProcessor processor = new Book.BookProcessor(books);

            #endregion

            #region 3-Using User Defined Delegate
            //Book.BookDelegate isbnDelegate = Book.GetISBN;
            //processor.ProcessBooks(isbnDelegate);
            #endregion


            #region 4-Using Built-in Delegate
            //Func<Book, string> publicationDateDelegate = Book.GetPublicationDate;
            //processor.ProcessBooks(publicationDateDelegate);
            #endregion

            #region Using Anonymous Method
            //processor.ProcessBooks(delegate (Book b) {
            //    return b.GetISBN();
            //});
            #endregion

            #region Using Lambda Expression
            //processor.ProcessBooks(b => b.GetPublicationDate());

            #endregion

            #endregion

            #region Part02

            //MyList<Book> bookList = new MyList<Book>();

            //bookList.Add(new Book("978-3-16-148410-0", "2021-01-01", "Book One"));
            //bookList.Add(new Book("978-1-4028-9462-6", "2022-05-15", "Book Two"));
            //bookList.Add(new Book("978-0-545-01022-1", "2023-07-20", "Book Three"));

            #region Exist
            //bool exists = bookList.Exists(b => b.Title == "Book Two");
            //Console.WriteLine($"Book Two exists: {exists}");

            #endregion

            #region Find
            //Book foundBook = bookList.Find(b => b.Title == "Book One");
            //Console.WriteLine($"Found Book: {foundBook}");
            #endregion


            #region Find All
            //List<Book> foundBooks = bookList.FindAll(b => b.Title.Contains("Book"));
            //Console.WriteLine("Books containing 'Book' in the title:");
            //foundBooks.ForEach(b => Console.WriteLine(b));

            #endregion


            #region Find index
            //int index = bookList.FindIndex(b => b.Title == "Book Three");
            //Console.WriteLine($"Index of Book Three: {index}");

            #endregion


            #region Find Last Index
            //int lastIndex = bookList.FindLastIndex(b => b.Title.Contains("Book"));
            //Console.WriteLine($"Last index of a book containing 'Book' in the title: {lastIndex}");

            #endregion

            #region Foreach
            //Console.WriteLine("All books:");
            //bookList.ForEach(b => Console.WriteLine(b));
            #endregion

            #region TrueForAll
            //bool allBooksHaveTitle = bookList.TrueForAll(b => b.Title.Contains("Book"));
            //Console.WriteLine($"All books have 'Book' in the title: {allBooksHaveTitle}");
            #endregion


            #endregion

        }
    }
}
