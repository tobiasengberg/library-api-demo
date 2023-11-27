using API.DTO;
using API.Services;
using Core;
using Infrastructure;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IBooksService _bookService;

        public BooksController(IBooksService bookService) 
        {
            _bookService = bookService;
        }

        [HttpGet]
        public List<BookDTO> GetBooks()
        {
            return _bookService.GetBooks();
        }
    }
}
