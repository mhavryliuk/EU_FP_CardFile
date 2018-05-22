using System.Data.Entity;

namespace CardFile.Models
{
    public class CardFileContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Copy> Copies { get; set; }
        public DbSet<User> Users { get; set; }
    }
}