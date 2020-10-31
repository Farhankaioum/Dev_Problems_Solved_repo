using System;
using System.Collections.Generic;
using System.Text;

namespace LendingLibrary.Framework.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Writer { get; set; }
        public string Edition { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int AvailableItem { get; set; }
        public int PendingPerson { get; set; }

        public List<Book> Books { get; set; }

        public Book()
        {
            Books = new List<Book>
            {
                new Book{ Id = 1, Title = "C#", Writer="John smith", Edition="2nd", ReleaseDate = DateTime.Now, AvailableItem = 2, PendingPerson=0 },
                new Book{ Id = 2, Title = "Intermediate C#", Writer="Tim Corey", Edition="2nd", ReleaseDate = DateTime.Now , AvailableItem = 2, PendingPerson=0 },
                new Book{ Id = 3, Title = "Advanced C#", Writer="Mosh Hamedani", Edition="2nd", ReleaseDate = DateTime.Now, AvailableItem = 2 , PendingPerson=0 },
                new Book{ Id = 4, Title = "Database", Writer="Steaf Rolling", Edition="2nd", ReleaseDate = DateTime.Now, AvailableItem = 2, PendingPerson=0  },
                new Book{ Id = 5, Title = "MVC", Writer="John smith", Edition="2nd", ReleaseDate = DateTime.Now, AvailableItem = 2, PendingPerson=0  }
            };
        }

        public void AddBooks(Book book)
        {
            var id = Books.Count + 1;
            book.Id = id;
            Books.Add(book);
        }
    }
}
