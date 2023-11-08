using System.ComponentModel.DataAnnotations;

namespace library_system.Models
{
    public class Librarian
    {
        [Display(Name="Código")]        
        public int Id { get; set; }
        [Display(Name="Nome")]
        public string? Name {get; set;}
        [Display(Name="Endereço")]
        public string? Address { get; set;}
        [Display(Name="Telefone")]
        public int Mobileno { get; set;}
        [Display(Name="Alerta")]
        public Alert? Alert { get; set;}
        [Display(Name="Membros")]
        public List<Member> Members {get;} = new();

        public void UpdateInfo(){}
        public void IssueBooks(){}
        public void MamberInfo(){}
        public void SearchBk(){}
        public void ReturnBk(){}
    }
}