using Books.API.Data;
using Books.Core;
using Microsoft.AspNetCore.Mvc;

namespace Books.API.Controllers;

[ApiController]
[Route("[controller]")]
public class BookController: ControllerBase
{
    private IBookProvider _booksProvider;

    public BookController(IBookProvider booksProvider)
    {
        _booksProvider = booksProvider;
    }

    [HttpGet(Name = "GetBooks")]
    public IEnumerable<Book> Get()
    {
        _booksProvider: new HardCodedBooksProvider();
        return _booksProvider.GetBooks();
    }
    
}

