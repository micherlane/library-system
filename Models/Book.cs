using System.ComponentModel.DataAnnotations;

namespace library_system.Models
{
    public class Book
    {
        [Display(Name="Código")]
        public int Id { get; set; }
        [Display(Name="Nome do Autor")]
        public string? AuthorName { get; set;}
        [Display(Name="Nome do Livro")]
        public string? BookName { get; set; }
        [Display(Name="Código Catálogo")]
        public int CatalogId {get; set;}
        [Display(Name="Cátalogo")]
        public Catalog Catalog {get; set;} = null!;
        public void RemoveFirmCatalog(){}
        public void AddToCatalog(){}
    }
}