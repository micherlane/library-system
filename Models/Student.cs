using System.ComponentModel.DataAnnotations;

namespace library_system.Models
{
    public class Student: Member
    {
        [Display(Name="Nome")]
        public string? SName { get; set;}
        [Display(Name="Estudante")]
        public string? StudentColl { get; set; }

        public void Checkoutbk(){}
    }
}