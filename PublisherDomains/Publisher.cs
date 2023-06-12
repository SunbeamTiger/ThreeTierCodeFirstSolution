using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublisherDomains
{
    public class Publisher
    {
        public Publisher()
        {
            Authors = new List<Author>();
        }
        public int id { get; set; }
        public string PublisherName { get; set; }
        public List<Author> Authors { get; set; }
    }
}
