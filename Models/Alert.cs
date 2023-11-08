using System.ComponentModel.DataAnnotations;

namespace library_system.Models
{
    public class Alert
    {
    
        [Display(Name="Código")]
        public int Id { get; set; }
        [Display(Name="Data de Emissão")]
        public DateTime Issuedate {get; set;}
        [Display(Name="Nome do Livro")]
        public string? Bookname { get; set;}
        [Display(Name="Data de Retorno")]
        public DateTime ReturnDate { get; set; }
        [Display(Name="Multa")]
        public int Fine { get; set; }
        [Display(Name = "Código Bibliotecário")]
        public int LibrarianId {get; set;}
        [Display(Name="Bibliotecário")]
        public Librarian Librarian {get; set;} = null!;

        public void FineCall(){}
        public void ViewAlert(){}
        public void SendToLibrarian(){}
        public void DeleteAlrtByNo(){}
    }
}