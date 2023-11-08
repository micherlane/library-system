using System.ComponentModel.DataAnnotations;

namespace library_system.Models
{
    public class GeneralBook: Book
    {
        [Display(Name="Gênero")]
        public string? Genre { get; set; }
        [Display(Name="Linguagem")]
        public string? Language { get; set; }
        [Display(Name="Edição")]
        public int? Edition { get; set; }
    }
}