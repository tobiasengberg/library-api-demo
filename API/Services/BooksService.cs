using API.DTO;
using Core;
using Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace API.Services
{
    public class BooksService : IBooksService
    {
        private readonly LibraryContext _libraryContext;

        public BooksService(LibraryContext libraryContext)
        {
            _libraryContext = libraryContext;
        }

        public List<BookDTO> GetBooks()
        {
            List<Book> books = _libraryContext.Books
                .Include(b => b.Author)
                .Include(b => b.Publisher)
                .ToList();
            List<BookDTO> booksDTO = new List<BookDTO>();   
            foreach (Book book in books)
            {
                booksDTO.Add(new BookDTO(
                    book.Id, book.Title, book.Year, book.Author.FirstName,
                    book.Author.LastName, book.Publisher.Name, book.Publisher.City));
            }
            return booksDTO;
        }
    }
}
