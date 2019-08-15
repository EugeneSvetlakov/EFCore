using Microsoft.EntityFrameworkCore;
using System;

namespace EFCore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    class User
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public uint Age { get; set; }
    }

    class AppContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB; Database=TestEfDB; Trusted_Connection=True");
        }
    }

}
