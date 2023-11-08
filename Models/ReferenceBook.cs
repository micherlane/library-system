using System.ComponentModel.DataAnnotations;

namespace library_system.Models
{
    public class ReferenceBook: Book
    {
        public string? ISBN { get; set; }
        [Display(Name="Categoria")]
        public string? Category { get; set; }
        [Display(Name="Está avaliado para referência?")]
        public bool? IsAvailableForReference { get; set; }
    }
}