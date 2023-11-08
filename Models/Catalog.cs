using System.ComponentModel.DataAnnotations;

namespace library_system.Models
{
    public class Catalog
    {
        [Display(Name="Código")]
        public int Id {get; set;}
        [Display(Name="Nome do Autor")]
        public string? AuthorName {get; set;}
        [Display(Name="Número de Códpias")]
        public int NoOfCopies {get; set;}
        [Display(Name="Livros")]
        public ICollection<Book> Books { get; } = new List<Book>();

        public void UpdateInfo(){}
        public void Searching(){}
    }
}