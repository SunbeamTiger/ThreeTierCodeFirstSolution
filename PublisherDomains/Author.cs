using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublisherDomains
{
    public class Author
    {
        public Author() 
        {
            Books = new List<Book>();   
        } 
        public int id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public List<Book> Books { get; set; }

    }
}
