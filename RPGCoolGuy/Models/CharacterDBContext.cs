﻿using Microsoft.EntityFrameworkCore;

namespace RPGCoolGuy.Models
{
    public class CharacterDBContext : DbContext
    {
        public CharacterDBContext 
            (DbContextOptions<CharacterDBContext> options) : base(options)
        {

        }
        public DbSet<Character> Characters { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Character>().HasData(
                new Character
                {
                    Id = 1,
                    Name = "Dave",
                    Attack = 20,
                    Defense = 20,
                    HP = 5,
                },
                new Character
                {
                    Id = 2,
                    Name = "Tony",
                    Attack = 30,
                    Defense = 30,
                    HP = 1
                },
                new Character
                {
                    Id = 3,
                    Name = "Peter Griffin",
                    Attack = 99,
                    Defense = 99,
                    HP = 9999
                });
        }
    }
}
