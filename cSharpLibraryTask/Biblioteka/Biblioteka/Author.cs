using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteka
{
    public class Author
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Nationality { get; set; }
        public List<Book> Books { get; set; }
    }
}
