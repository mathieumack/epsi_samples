using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBooksManager
{
    public class BookManager
    {
        private Book CurrentBook { get; set; }
        private List<Book> Books { get; set; }

        public BookManager()
        {
            Books = new List<Book>();
        }

        public void StartManager()
        {
            Console.WriteLine("Welcome !");
            bool quit = false;
            while (!quit)
            {
                Console.WriteLine("What do you want to do ? (type 'help' to show possibilities)");
                string action = Console.ReadLine();
                if (action == "help")
                    ShowMenu();
                else if (action == "show")
                    ShowBooks();
                else if (action == "detail")
                    SelectBook();
                else if (action == "new")
                    CreateBook();
                else if (action == "exit")
                    quit = true;
            }
        }

        private void ShowMenu()
        {
            Console.WriteLine("type 'show' to show all books.");
            Console.WriteLine("type 'detail' to open a book.");
            Console.WriteLine("type 'new' to create a book.");
            Console.WriteLine("type 'exit' to quit the application.");
        }

        private void ShowBooks()
        {
            if (Books.Any())
            {
                Console.WriteLine("Your books : ");
                foreach (Book book in Books)
                {
                    Console.WriteLine(" (" + book.Id + ") - " + book.Title);
                }
            }
            else
                Console.WriteLine("There is no books.");
        }

        private void SelectBook()
        {
            Console.WriteLine("Enter the id of the book :");

            int number = 0;
            while(!int.TryParse(Console.ReadLine(), out number))
                Console.WriteLine("Invalid number, please set a valid number :");

            // We check that the number exists :
            if (!Books.Any(e => e.Id == number))
            {
                Console.WriteLine("No books finded with the id " + number);
            }
            else
            {
                CurrentBook = Books.First(e => e.Id == number);
                CurrentBook.ShowMenu();
            }
        }

        private void CreateBook()
        {
            Console.WriteLine("Please enter the title :");
            string title = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(title))
            {
                Console.WriteLine("Please provide a valid title (not null or empty) :");
                title = Console.ReadLine();
            }


            try
            {
                // Do some code
            }
            catch
            {
                // Manage exception
            }
            finally
            {
                // Do some code even if an exception is throwed
            }
        }

        private Book CreateNewBook(string title)
        {
            Book newBook = new Book();
            newBook.Title = title;
            if (Books.Any())
                newBook.Id = Books.Max(e => e.Id) + 1;
            else
                newBook.Id = 1;
            return newBook;
        }
    }
}
