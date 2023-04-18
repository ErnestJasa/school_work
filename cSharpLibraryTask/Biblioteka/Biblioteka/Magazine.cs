using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteka
{
    public class Magazine : Publication
    {
        public Magazine(string isbn)
            :base(isbn){}
        public bool IsMagazine => true;
        public bool IsAvailable { get; set; }
    }
}
