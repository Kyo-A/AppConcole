using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLink.Models
{
    // gestionnaire d'entite
    public class ModelDbContext : DbContext
    {
        //Tables a mapper
        public DbSet<Personne> Personnes { get; set; }

        //declare la chaine de connexion a la db
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=AppLink.NewDb;integrated security=True;");
        }

    }
}
