using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteka
{
    public abstract class Publication
    {
        public Publication(string isbn)
        {
            ISBN = isbn;
        }
        public string Title { get; set; }
        public string Description { get; set; }
        private string ISBN { get; set; }
        public int PageCount { get; set; }
        public DateTime PublishedDate { get; set; }

        public string GetIsbn()
        {
            return ISBN;
        }
    }
}
