using Labb4__API.Models;
using Microsoft.EntityFrameworkCore;

namespace Labb4__API.Data
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> option) : base(option)
        {
        }

        public DbSet<Person> Persons { get; set; }
       
        public DbSet <Intrest> Interests { get; set; }

        public DbSet <Link> Links { get; set; }

        public DbSet<PersonInterest> PersonInterests{ get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<Intrest>().HasData(
            new Intrest { Id = 1, Title = "Hockey", Description = "A sport played on ice" },
            new Intrest { Id = 2, Title = "Football", Description = "A sport played with a ball" },
            new Intrest { Id = 3, Title = "Basketball", Description = "A sport played with a ball and hoops" },
            new Intrest { Id = 4, Title = "Handball", Description = "A sport played with a ball and hands" },
            new Intrest { Id = 5, Title = "Baseball", Description = "A sport played with a ball and bat" }
     );

            // Add seed data for the Person entity
                modelBuilder.Entity<Person>().HasData(
                new Person { id = 1, FirstName = "Adam", LastName = "Carlen", Phone = "1234567890" },
                new Person { id = 2, FirstName = "Olof", LastName = "Mellberg", Phone = "0987654321" },
                new Person { id = 3, FirstName = "Johan", LastName = "Krall", Phone = "0702656565" },
                new Person { id = 4, FirstName = "Johanna", LastName = "Melker", Phone = "0702696969" },
                new Person { id = 5, FirstName = "Axel", LastName = "Lexander", Phone = "0340265432" }

            );

            // Add seed data for the Link entity
                modelBuilder.Entity<Link>().HasData(
                new Link { Id = 1, Url = "https://www.nhl.com", InterestId = 1, PersonId = 1 },
                new Link { Id = 2, Url = "https://www.fifa.com", InterestId = 2, PersonId = 2 },
                new Link { Id = 3, Url = "https://www.nba.com", InterestId = 3, PersonId = 1 },
                new Link { Id = 4, Url = "https://www.ihf.info/", InterestId = 4, PersonId = 1 },
                new Link { Id = 5, Url = "https://www.mlb.com/", InterestId = 5, PersonId = 1 }
            );

            // Add seed data for the PersonInterest entity
            modelBuilder.Entity<PersonInterest>().HasData(
                 new PersonInterest { Id = -1, PersonId = 1, InterestId = 1 },
                 new PersonInterest { Id = -2, PersonId = 1, InterestId = 3 },
                 new PersonInterest { Id = -3, PersonId = 2, InterestId = 2 },
                 new PersonInterest { Id = -4, PersonId = 2, InterestId = 4 },
                 new PersonInterest { Id = -5, PersonId = 2, InterestId = 5 },
                 new PersonInterest { Id = -6, PersonId = 3, InterestId = 2 },
                 new PersonInterest { Id = -7, PersonId = 3, InterestId = 1 },
                 new PersonInterest { Id = -8, PersonId = 4, InterestId = 2 },
                 new PersonInterest { Id = -9, PersonId = 4, InterestId = 3 },
                 new PersonInterest { Id = -10, PersonId = 4, InterestId = 1 },
                 new PersonInterest { Id = -11, PersonId = 5, InterestId = 1 },
                 new PersonInterest { Id = -12, PersonId = 5, InterestId = 5 }



            );

        }
    }
}
