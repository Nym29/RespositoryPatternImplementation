using Books.Core;

namespace Books.API.Data
{
	public class HardCodedBooksProvider: IBookProvider
    {
        public List<Book> GetBooks()
        {
            var books = new List<Book>()
            {
                new Book(1, "Atwood, Margaret", "The Testaments", 2019),
                new Book(2, "Butler, Octavia", "Kindred",1979),
                new Book(3, "Pratchett, Terry", "The Fifth Elephant", 1999),
         
            };
            return books;
        }
    }

    public interface IBookProvider
    {
        List<Book> GetBooks();
    }
}

