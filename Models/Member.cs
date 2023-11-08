using System.ComponentModel.DataAnnotations;

namespace library_system.Models
{
    public class Member
    {
       [Display(Name="Código")]
       public int Id { get; set; }
       [Display(Name="Nome")]
       public string? Mname {get; set;}
       [Display(Name="Endereço")]
       public string? Maddress {get; set;}
       [Display(Name="Número")]
       public int Mno {get; set;}
       [Display(Name="Bibliotecários")]
       public List<Librarian> Librarians {get; } = new();
       public void Mrequestforbk(){}
       public void Mreturnbk(){}
    }
}