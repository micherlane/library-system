namespace library_system.Models
{
    public class Member
    {
       public int Id { get; set; }
       public string? Mname {get; set;}
       public string? Maddress {get; set;}
       public int Mno {get; set;}
    
       public List<Librarian> Librarians {get; } = new();
       public void Mrequestforbk(){}
       public void Mreturnbk(){}
    }
}