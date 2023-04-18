using Biblioteka.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteka
{
    public class Book : Publication
    {
        public Book(string isbn)
            : base(isbn){}
       
        public Author Author { get; set; }        
        public bool IsAvailable { get; set; }
        public Genre Genre { get; set; }
    }
}
