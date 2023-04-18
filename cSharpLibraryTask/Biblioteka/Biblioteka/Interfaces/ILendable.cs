using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteka.Interfaces
{
    public interface ILendable
    {
        Book LendBook(Book book);
        Magazine LendMagazine(Magazine magazine);
    }        
}
