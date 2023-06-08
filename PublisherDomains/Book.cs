using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublisherDomains
{
    public class Book
    {
        public int BookId { get; set; } 
        public string Title { get; set; }   
        public DateTime PublishDate { get; set; }
        public decimal Price { get; set; }  
        public Author Author { get; set; }
    }
}
