namespace LibraryApp.Data
{
    using LibraryApp.Entities;
    using Microsoft.EntityFrameworkCore;
    public class LibraryAppDbContext: DbContext
    {
        public DbSet<Book> Books => Set<Book>();
        public DbSet<ComicBook> Comics => Set<ComicBook>();
        public DbSet<DVD_Game> DVD_Games => Set<DVD_Game>();
        public DbSet<CompactDiscMusic> CompactDisc => Set<CompactDiscMusic>();
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseInMemoryDatabase("StorageLibraryDb");
        }
    }
}
