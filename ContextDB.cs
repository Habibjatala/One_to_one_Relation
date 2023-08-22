using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace One_to_one_Relation
{
    internal class ContextDB :DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<UserProfile> Profiles { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-459JF8A\\SQLEXPRESS;Initial Catalog=Relation4;Integrated Security=True;TrustServerCertificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<User>()
            //    .HasOne(u => u.Profile)
            //    .WithOne(p => p.User)
            //    .HasForeignKey<UserProfile>(p => p.id);
        }

    }
}
