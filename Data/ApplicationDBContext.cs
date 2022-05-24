using EF_test_01.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EF_test_01.Data
{
    public class ApplicationDBContext : DbContext
    {
        //public ApplicationDBContext()
        //{ }
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base (options)
        { }
        public DbSet<Person> People { get; set; }
        //public DbSet<Language> Languages { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            //mb.Entity<PersonLanguage>().HasKey(pl => new { pl.PersonId, pl.LanguageId });

            //mb.Entity<PersonLanguage>()
            //    .HasOne(pl => pl.Person)
            //    .WithMany(l => l.)
            //    .HasForeignKey(pl => pl.PersonId);

            //Seeding some data
            mb.Entity<Person>().HasData(new Person(1, "Josh Gomez", "123 456", "Abu Dabi"));
            mb.Entity<Person>().HasData(new Person(2, "Miguel Alonso", "234 567", "San Jose"));
            mb.Entity<Person>().HasData(new Person(3, "Andreas Kvarnblom", "345 678", "Stockholm"));
            mb.Entity<Person>().HasData(new Person(4, "Tore Kindwall", "456 789", "Stockholm"));
            mb.Entity<Person>().HasData(new Person(5, "Helena Danielsson", "567 890", "Göteborg"));
            mb.Entity<Person>().HasData(new Person(6, "Maria Persson", "678 901", "Alvesta"));
        }
    }
}
