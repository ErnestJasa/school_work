using Biblioteka.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Biblioteka
{
    public class Library: ILendable
    {
        public Library(Address address)
        {
            Address = address;
            Books = new List<Book>();
            Magazines = new List<Magazine>();
        }
        public Address Address { get; set; }
        private List<Book> Books { get; set; }
        public List<Magazine> Magazines { get; set; }

        public void AddBook(Book book)
        {
            bool bookExists = false;
            foreach(var item in Books)
            {
                if(item.GetIsbn() == book.GetIsbn())
                {
                    bookExists = true;
                }
            }
            if (!bookExists)
            {
                Books.Add(book);
            }            
        }
        public IEnumerable<Book> GetAvailableBookList()
        {
            var availableBooks = Books.Where(book => book.IsAvailable);       // Padaro available knygu List
            //foreach (var item in availableBooks)
            //{
            //    Console.WriteLine(item.Title);
            //}
            return availableBooks;


            //var availableBooks = from book in Books
            //                     where book.IsAvailable
            //                     select book;                   // Padaro ta pati kas auksciau tik kitaip         


            //foreach(var book in Books)
            //{
            //    if (book.IsAvailable)
            //    {
            //        Console.WriteLine(book.Title);
            //    }
                
            //}
        }

        public Book LendBook(Book book)
        {
            return Books.Where(b => b.GetIsbn() == book.GetIsbn()).Where(x=>x.IsAvailable).First();

            //foreach (var item in Books)
            //{
            //    if (item.GetIsbn() == book.GetIsbn() && item.IsAvailable)
            //    {
            //        return item;
            //    }                
            //}
            //return null;
        }

        public bool DoesBookExist(string isbn)
        {
            return Books.Any(book => book.GetIsbn() == isbn);
        }







        public Magazine LendMagazine(Magazine magazine)
        {
            foreach (var item in Magazines)
            {
                if (item.GetIsbn() == magazine.GetIsbn() && item.IsAvailable)
                {
                    return item;
                }
            }
            return null;
        }
        public void BookSearch()
        {
            Console.WriteLine("Iveskite ieskomos knygos pavadinima: ");
           string bookTitle = Console.ReadLine();
            foreach (var book in Books)
            {
                if (bookTitle == book.Title)
                {
                    Console.WriteLine("Knyga " + book.Title + " yra");                    
                }              
            }

        }
    }    
}
