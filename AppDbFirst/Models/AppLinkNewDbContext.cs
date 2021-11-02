using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace AppDbFirst.Models
{
    public partial class AppLinkNewDbContext : DbContext
    {
        public AppLinkNewDbContext()
        {
        }
        //Scaffold-DbContext "Server=(localdb)\mssqllocaldb;Database=AppLink.NewDb;Trusted_Connection=True;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models
        public AppLinkNewDbContext(DbContextOptions<AppLinkNewDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Personne> Personnes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=AppLink.NewDb;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Personne>(entity =>
            {
                entity.HasKey(e => e.Num);

                entity.ToTable("personnes");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
