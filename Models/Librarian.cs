namespace library_system.Models
{
    public class Librarian
    {
        public string? Name {get; set;}
        public string? Address { get; set;}
        public int Mobileno { get; set;}
        public Alert? Alert { get; set;}
        public List<Member> Members {get;} = new();

        public void UpdateInfo(){}
        public void IssueBooks(){}
        public void MamberInfo(){}
        public void SearchBk(){}
        public void ReturnBk(){}
    }
}