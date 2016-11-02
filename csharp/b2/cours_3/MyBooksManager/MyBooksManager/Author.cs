using System;

namespace MyBooksManager
{
    public class Author
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public void ShowDetail()
        {
            Console.WriteLine("Author : " + FirstName + " " + LastName);
        }
    }
}
