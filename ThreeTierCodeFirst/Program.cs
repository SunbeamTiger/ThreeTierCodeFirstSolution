using Microsoft.EntityFrameworkCore;
using PublisherData;
using PublisherDomains;
namespace ThreeTierCodeFirst
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (PubContext _context = new PubContext())
            {
                _context.Database.EnsureCreated();  
            }
            // AddAuthor();
             //AddAuthorandBook();
            getAuthorswithBooks();
            //getauthors();
        }
        public static void AddAuthor()
        {
            var Author = new Author { Firstname = "Dan", Lastname = "Hagen" };
            using var _context = new PubContext();
            _context.Authors.Add(Author);
            _context.SaveChanges(); 
        }
        public static void AddAuthorandBook()
        {
            var author = new Author { Firstname = "Joe", Lastname = "Biden" };
            author.Books.Add(new Book { Title = "Being The Prez", Price = 30, PublishDate = new DateTime(2024, 2, 7) });
            author.Books.Add(new Book { Title = "I forgot the book title", Price = 1, PublishDate = new DateTime(2026, 1, 1) });
            var _context = new PubContext();    
            _context.Authors.Add(author); 
            _context.SaveChanges();   
        }

        public static void getAuthorswithBooks()
        {
            var context = new PubContext();
            var authors = context.Authors.Include(a => a.Books).ToList();
            foreach (var author in authors)
            {
                Console.WriteLine(author.Firstname + " " + author.Lastname);    
                foreach (var book in author.Books)
                {
                    Console.WriteLine(book.Title);
                }
            }
        }
        public static void getauthors()
        {
            var context = new PubContext();
            var authors = context.Authors.ToList();
            foreach ( var author in authors)
            {
                Console.WriteLine(author.Firstname +  ' ' + author.Lastname);   
            }
        }
        }
    }
