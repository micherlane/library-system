using Microsoft.EntityFrameworkCore;

namespace library_system.Models
{
    public class MyDbContext: DbContext
    {
       public MyDbContext(DbContextOptions<MyDbContext> options) : base(options){}
        public DbSet<Alert> Alert { get; set; }
        public DbSet<Book> Book { get; set; }
        public DbSet<Catalog> Catalog { get; set; }
        public DbSet<FacultyMember> FacultyMember { get; set; }
        public DbSet<GeneralBook> GeneralBook { get; set; }
        public DbSet<Librarian> Librarian { get; set; }
        public DbSet<Member> Member { get; set; }
        public DbSet<ReferenceBook> ReferenceBook { get; set; }
        public DbSet<Student> Student { get; set; }
    }
}