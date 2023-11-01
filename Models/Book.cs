namespace library_system.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string? AuthorName { get; set;}
        public string? BookName { get; set; }

        public int CatalogId {get; set;}
        public Catalog Catalog {get; set;} = null!;
        public void RemoveFirmCatalog(){}
        public void AddToCatalog(){}
    }
}