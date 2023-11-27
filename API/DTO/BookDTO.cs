using Core;

namespace API.DTO
{
    public class BookDTO
    {
        public int Id { get; set; }
        public string BookTitle { get; set; }
        public int Year { get; set; }
        public string AuthorFirstName { get; set; }
        public string AuthorLastName { get; set; }
        public string PublisherName { get; set; }
        public string PublisherCity { get; set; }

        public BookDTO(int id, string bookTitle, int year, string authorFirstName, 
            string authorLastName, string publisherName, string publisherCity)
        {
            Id = id;
            BookTitle = bookTitle;
            Year = year;
            AuthorFirstName = authorFirstName; 
            AuthorLastName = authorLastName;
            PublisherName = publisherName;
            PublisherCity = publisherCity;

        }
    }
}
