using AppDbFirst.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace AppDbFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new AppLinkNewDbContext())
            {
                Personne personne = new Personne("John", "John", 2000);
                db.Personnes.Add(personne);
                db.SaveChanges();

                var personnesList = db.Personnes.ToList();

                personnesList.ForEach((p) => Console.WriteLine(p.Nom + " " + p.Prenom));

                Console.WriteLine("----------------------GET---------------------------- ");

                Personne pers = db.Personnes.FirstOrDefault(p => p.Num == 2);

                Console.WriteLine(pers);

                Console.WriteLine("-----------------------EDIT--------------------------- ");

                Personne personneToUpdate = db.Personnes.FirstOrDefault(p => p.Num == 3);

                personneToUpdate.Budget = 5000;
                personneToUpdate.Nom = "Unom";
                personneToUpdate.Prenom = "Uprenom";

                db.Entry(personneToUpdate).State = EntityState.Modified;
                db.SaveChanges();

                personnesList.ForEach((p) => Console.WriteLine(p.Nom + " " + p.Prenom));

                Console.WriteLine("-----------------------DELETE--------------------------- ");

                Personne personneToDelete = db.Personnes.FirstOrDefault(p => p.Num == 5);

                db.Personnes.Remove(personneToDelete);
                db.SaveChanges();

                personnesList.ForEach((p) => Console.WriteLine(p.Nom + " " + p.Prenom));
            }
        }
    }
}
