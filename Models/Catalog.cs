
namespace library_system.Models
{
    public class Catalog
    {
        public int Id {get; set;}
        public string? AuthorName {get; set;}
        public int NoOfCopies {get; set;}

        public ICollection<Book> Books { get; } = new List<Book>();

        public void UpdateInfo(){}
        public void Searching(){}
    }
}