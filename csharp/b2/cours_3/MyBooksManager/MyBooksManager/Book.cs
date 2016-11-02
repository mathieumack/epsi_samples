using System;

namespace MyBooksManager
{
    public class Book
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public Author Author { get; set; }

        public bool IsFavorite { get; set; }

        public void ShowDetail()
        {
            Console.WriteLine("Title : " + Title);
            if(Author != null)
                Author.ShowDetail();
            else
                Console.WriteLine("No author.");

            bool quit = false;
            while (!quit)
            {
                Console.WriteLine("What do you want to do on the book ? (type 'help' to show possibilities)");
                string action = Console.ReadLine();
                if (action == "help")
                    ShowMenu();
                else if (action == "update")
                    UpdateAuthor();
                else if (action == "end")
                    quit = true;
            }
        }

        public void ShowMenu()
        {
            Console.WriteLine("type 'update' to change the author.");
            Console.WriteLine("type 'end' to return to home.");
        }

        public void UpdateAuthor()
        {
            if (Author == null)
            {
                Author = new Author();
            }

            Console.WriteLine("Please enter first name :");
            string firstName = Console.ReadLine();
            while(string.IsNullOrWhiteSpace(firstName))
            {
                Console.WriteLine("Please provide a valid first name (not null or empty) :");
                firstName = Console.ReadLine();
            }
            Console.WriteLine("Please enter last name :");
            string lastName = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(lastName))
            {
                Console.WriteLine("Please provide a valid last name (not null or empty) :");
                lastName = Console.ReadLine();
            }

            Author.FirstName = firstName;
            Author.LastName = lastName;

            Console.WriteLine("Saved Ok.");
        }
    }
}
