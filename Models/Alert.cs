namespace library_system.Models
{
    public class Alert
    {
    
        public int Id { get; set; }
        public DateTime Issuedate {get; set;}
        public string? Bookname { get; set;}
        public DateTime ReturnDate { get; set; }
        public int Fine { get; set; }
        public int LibrarianId {get; set;}
        public Librarian Librarian {get; set;} = null!;

        public void FineCall(){}
        public void ViewAlert(){}
        public void SendToLibrarian(){}
        public void DeleteAlrtByNo(){}
    }
}