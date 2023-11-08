using System.ComponentModel.DataAnnotations;

namespace library_system.Models
{
    public class FacultyMember: Member
    {
        [Display(Name="Nome")]
        public string? Fname {get; set;}
        [Display(Name="Corpo Docente")]
        public string? FacultyColl {get; set;}

        public void Checkoutbk(){}
    }
}