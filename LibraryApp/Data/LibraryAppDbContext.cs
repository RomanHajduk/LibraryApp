namespace LibraryApp.Data
{
    using LibraryApp.Entities;
    using Microsoft.EntityFrameworkCore;
    public class RentalShopAppDbContext: DbContext
    {
        public DbSet<Book> Books => Set<Book>();
        public DbSet<PC_Game> DVD_Games => Set<PC_Game>();
        public DbSet<CD_Music> CompactDisc => Set<CD_Music>();
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseInMemoryDatabase("StorageLibraryDb");
        }
    }
}
