using API.DTO;
using Core;

namespace API.Services
{
    public interface IBooksService
    {
        List<BookDTO> GetBooks();
    }
}
