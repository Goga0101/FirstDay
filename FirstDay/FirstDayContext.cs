using FirstDay.Models;
using FirstDay.Poco;
using FirstDay.PocoConfiguration;
using Microsoft.EntityFrameworkCore;
using System;

namespace FirstDay
{
    public class FirstDayContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Gender> Genders { get; set; }

        public FirstDayContext()
        {

        }

        public FirstDayContext(DbContextOptions options) : base(options)
        {

        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new GenderConfiguration());

            modelBuilder.Seed();




        }

    }
}
