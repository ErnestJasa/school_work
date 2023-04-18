using System;

namespace Biblioteka
{
    class Program
    {
        static void Main(string[] args)
        {         

            

            Book altoriuSeselis = new Book("156-984-468");
            altoriuSeselis.Title = "Altoriu sesely";
            altoriuSeselis.PageCount = 535;
            altoriuSeselis.PublishedDate = new DateTime(1995, 02, 14);
            altoriuSeselis.Author = 
                new Author() {
                    FirstName = "Tomas", LastName = "Pavardenis"
                };
            altoriuSeselis.Genre = Genre.Thriller;
            altoriuSeselis.IsAvailable = true;

            Book karasIrTaika = new Book("156-984-468645");
            karasIrTaika.Title = "Karas ir taika";
            karasIrTaika.PageCount = 535;
            karasIrTaika.PublishedDate = new DateTime(1992, 05, 13);
            karasIrTaika.Author =
                new Author()
                {
                    FirstName = "Tomas",
                    LastName = "Pavardenis"
                };
            karasIrTaika.Genre = Genre.Dystopian;
            karasIrTaika.IsAvailable = true;

            Library viesojiBiblioteka = new Library(Address.GetCentrineBiblioteka());

            viesojiBiblioteka.AddBook(altoriuSeselis);
            viesojiBiblioteka.AddBook(karasIrTaika);
            viesojiBiblioteka.AddBook(karasIrTaika);

            var availableBooks = viesojiBiblioteka.GetAvailableBookList();

            foreach (var item in availableBooks)
            {
                Console.WriteLine(item.Title);
            }
            //viesojiBiblioteka.BookSearch();

            

            //Book brisiausGalas = new Book();
            //Book girlOnTrain = new Book();
            

        }
    }
}
