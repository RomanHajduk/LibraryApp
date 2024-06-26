﻿namespace LibraryApp.Data
{
    using LibraryApp.Entities;
    using Microsoft.EntityFrameworkCore;
    public class RentalShopAppDbContext: DbContext
    {
        public DbSet<Book> Books => Set<Book>();
        public DbSet<PCGame> PCGames => Set<PCGame>();
        public DbSet<CDMusic> CDsMusic => Set<CDMusic>();
        public DbSet<Client> Clients => Set<Client>();
        public DbSet<Employee> Employees => Set<Employee>();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseInMemoryDatabase("StorageLibraryDb");
        }
    }
}
