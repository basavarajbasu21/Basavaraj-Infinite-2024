using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
    class Book
    {
        public string BookName { get; }
        public string AuthorName { get; }

        public Book(string bookName, string authorName)
        {
            BookName = bookName;
            AuthorName = authorName;
        }

        public void Display()
        {
            Console.WriteLine($"Book Name: {BookName}\nAuthor Name: {AuthorName}\n");
            Console.ReadLine();
        }
    }

    class BookShelf
    {
        private Book[] books;

        public BookShelf()
        {
            books = new Book[5];
        }

        public Book this[int index]
        {
            get
            {
                if (index < 0 || index >= books.Length)
                {
                    throw new IndexOutOfRangeException("Index is out of range.");
                }
                return books[index];
            }
            set
            {
                if (index < 0 || index >= books.Length)
                {
                    throw new IndexOutOfRangeException("Index is out of range.");
                }
                books[index] = value;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            BookShelf shelf = new BookShelf();

            // Assigning values to the books using indexer
            shelf[0] = new Book("Malgudi Days", "R.K. Narayan");
            shelf[1] = new Book("Bhagavad Gita", "S. Radhakrishnan");
            shelf[2] = new Book("By God’s Decree", "Kapil Dev");
            shelf[3] = new Book("Ignited Minds", "A.P.J. Abdul Kalam");
            shelf[4] = new Book("Wings of fire", "A.P.J. Abdul Kalam");

            // Displaying the details of each book
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Book at index {i}:");
                shelf[i].Display();
            }
        }
    }
}
