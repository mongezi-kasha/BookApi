using BookApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookApi.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class BooksController: ControllerBase
    {
        private Book[] _books = new Book[]
        {
            new Book{BookId = 1, Author ="Mongezi" , Title = "My terrible life stage"}
        };

        [HttpGet]
        public ActionResult <IEnumerable<Book>> GeBooks() 
        { 
            return Ok(_books);
        }
    }
}
