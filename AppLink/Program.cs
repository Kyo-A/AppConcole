using AppLink.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace AppLink
{
    class Program
    {
        static void Main(string[] args)
        {
            //// Lambda
            //// Exemple avec parametre d'entree et valeur de retour
            //Func<int, int> Carre = (x) => x * x;
            //Console.WriteLine(Carre(3));

            //Func<int, int> Carre2 = (x) =>
            //{
            //    return x * x;
            //};

            //// Exemple sans valeur de retour
            //Action<string> DireBonjour = (nom) => Console.WriteLine($"Bonjour { nom }");
            //DireBonjour("wick"); // Bonjour wick

            //// Une expression lambda peut utiliser une variable (ou un attribut)
            //// definie dans le contexte englobant(et modifier sa valeur)
            //int i = 2, j = 3;

            //Func<int, int, int> DoSomething = (x, y) =>
            //{
            //    i++;
            //    j++;
            //    return x * i + y * j;
            //};

            //Console.WriteLine(DoSomething(1, 1));

            //List<int> numbers2 = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };

            //foreach (var elt in numbers2)
            //{
            //    Console.WriteLine(elt);
            //}

            //numbers2.ForEach(elt => Console.WriteLine(elt));

            //numbers2.ForEach(Console.WriteLine);

            //numbers2.ForEach(Print);

            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8 };

            //IEnumerable<int> numQuery =               
            //    from num in numbers
            //    where (num % 2) == 0
            //    select num;

            //foreach (int num in numQuery)
            //{
            //    Console.Write("{0} ", num);
            //}

            //IEnumerable<int> numQuery2 = numbers.Where(elt => elt % 2 == 0);

            //foreach (int num in numQuery2)
            //{
            //    Console.Write("{0} ", num);
            //}

            //var numQuery4 =
            //    from num in numbers2
            //    where (num % 2) == 0 && (num > 5 || num < 3)
            //    select num;

            //IEnumerable<int> numQuery5 = numbers2
            //    .Where(elt => elt % 2 == 0 && (elt > 5 || elt < 3));

            //foreach (int num in numQuery5)
            //{
            //    Console.Write("{0} ", num);
            //}

            //// Ecrire une requete Linq qui permet de retourner les longueurs impaires
            //// des chaınes definies dans le tableau fruits.

            //string[] fruits = { "pomme", "banane", "mangue", "abricot", "fraise", "melon" };

            //IEnumerable<string> numQuery6 = fruits.Where((f) => f.Length % 2 != 0);

            //foreach (string fruit in numQuery6)
            //{
            //    Console.Write("{0} ", fruit);
            //}

            //var numQuery7 =
            //   from fruit in fruits
            //   where (fruit.Length % 2) != 0
            //   select fruit;

            //foreach (string fruit in numQuery7)
            //{
            //    Console.Write("{0} ", fruit);
            //}

            //var numbers3 = Enumerable.Range(1, 8);

            //var numQuery8 =
            //    from num in numbers3
            //    where (num % 2) == 0
            //    select num;

            //foreach (var num in numQuery8)
            //{
            //    Console.Write("{0} ", num);
            //}

            //// Ecrire une requete Linq permettant de generer les nombres pairs inferieurs a 20.
            //var numbers4 = Enumerable.Range(1, 20).Reverse();

            //var numQuery9 =
            //    from num in numbers4
            //    where (num % 2) == 0
            //    select num;

            //foreach (var num in numQuery9)
            //{
            //    Console.Write("{0} ", num);
            //}

            //// Pour recuperer les elements distincts d’une sequence
            //int[] notes = { 10, 18, 12, 10, 15, 10, 11 };

            //foreach (var note in notes.Distinct())
            //{
            //    Console.WriteLine(note);
            //}

            //// Recupere le premier element d'une sequence
            //int[] numbers10 = { 1, 2, 3, 4, 5, 6, 7, 8 };

            //var numQuery10 =
            //    from num in numbers10
            //    where (num % 2) == 0 && (num > 5 || num < 3)
            //    select num;

            //var numQuery11 = numbers.Where(elt => (elt % 2) == 0 && (elt > 5|| elt < 3));

            //// Recupere le premier element qui remplit la condition et gere l'exception si 
            //// le premier element est soit null pour les types nullables soit 0 pour les nombres
            //Console.WriteLine(numQuery10.FirstOrDefault());

            //int[] numbers23 = { 1, 2, 3, 4, 5, 6, 7, 8 };

            //var numQuery12 =
            //    from num in numbers23
            //    where (num % 2) == 0 && (num % 5) == 0
            //    select num;

            //var numQuery14 =
            //    from num in numbers23
            //    where (num % 2) == 0
            //    select num;

            //// Pour calculer la somme
            //Console.WriteLine(numQuery14.Sum()); // affiche 20

            //Console.WriteLine(numQuery14.Sum(elt => elt * 2)); // affiche 40

            ////Ecrire une requete Linq qui permet de calculer le total de nombres de
            ////caracteres du tableau fruits.

            //var chars = fruits.SelectMany(s => s.ToCharArray()).Count();

            //Console.WriteLine(chars);

            //var numQuery70 =
            //   from fruit in fruits
            //   select fruit;

            //Console.WriteLine(numQuery70.Sum(elt => elt.Length));

            //// Ecrire une requete Linq qui permet de calculer le total de nombres de
            //// caracteres des elements du tableau fruits ayant un nombre pair de
            //// caracteres.

            //var numQuery71 =
            //   from fruit in fruits
            //   where (fruit.Length % 2) == 0
            //   select fruit;

            //Console.WriteLine(numQuery70.Sum(elt => elt.Length));

            //var chars2 = fruits.Where((f) => f.Length % 2 == 0)
            //    .SelectMany(s => s.ToCharArray()).Count();

            //Console.WriteLine(chars2);

            //// Recupere un seul element qui remplit la condition et gere l'exception si 
            //// l'element est soit null ou contient pluieurs lements
            //Console.WriteLine(numQuery12.SingleOrDefault());

            //// Pour indiquer l’indice d’element a recuperer
            //Console.WriteLine(numQuery14.ElementAtOrDefault(3)); // Affiche 8

            //// Pour indiquer le nombre d’element a garder de la selection
            //foreach (var elt in numQuery14.Take(3))
            //{
            //    Console.WriteLine(elt); // affiche 2 4 6
            //}

            //Console.WriteLine(numQuery14.Take(3).ElementAt(2));

            //// Pour indiquer le nombre d’element a garder de la selection

            //foreach (var elt in numQuery14.Skip(2))
            //{
            //    Console.WriteLine(elt); // affiche 6 8
            //}

            //foreach (var elt in numQuery14.SkipLast(2))
            //{
            //    Console.WriteLine(elt); // affiche 2 4
            //}

            //// Pour indiquer une condition sur les elements a ignorer

            //foreach (var elt in numQuery14.SkipWhile(elt => elt < 3))
            //{
            //    Console.WriteLine(elt); // affiche 4 6 8
            //}

            //// Pour selectionner les elements d’une sequence d’un type donné

            //ArrayList nombres = new ArrayList { 1, "deux", "3", '4', 5, "six" };

            //foreach (var elt in nombres.OfType<string>())
            //{
            //    Console.WriteLine(elt); // affiche deux 3 six
            //}

            //List<Personne> personnes = new List<Personne>()
            //{
            //    new Personne(1, "wick", "john", 500),
            //    new Personne(2, "abruzzi", "john", 700),
            //    new Personne(3, "dalton", "jack", 300),
            //    new Personne(4, "white", "mike", 800),
            //};

            //// afficher les personnes qui ont un budget superieur a 500
            //IEnumerable<Personne> persoQuery =
            //    from perso in personnes
            //    where (perso.Budget > 500)
            //    select perso;

            //// avec les expressions Lambda
            //var persoQuery2 = personnes.Where(elt => elt.Budget > 500);

            //foreach (Personne perso in persoQuery)
            //{
            //    Console.WriteLine(perso);
            //}

            //// selectionner seulement quelques attributs (et les renommer)
            //var persoQuery3 =
            //   from perso in personnes
            //   where (perso.Budget > 500)
            //   select new
            //   {
            //       Name = perso.Nom,
            //       Number = perso.Num
            //   };

            //// avec les expressions Lambda
            //var persoQuery4 = personnes.Where(elt => elt.Budget > 500)
            //    .Select(elt => new
            //    {
            //        Name = elt.Nom,
            //        Number = elt.Num
            //    }
            // );

            //foreach (var perso in persoQuery3)
            //{
            //    Console.WriteLine(perso);
            //}

            //// trier dans l’ordre croissant ou decroissant.
            //IEnumerable<Personne> persoQuery5 =
            //   from perso in personnes
            //   where (perso.Budget >= 500)
            //   orderby perso.Prenom ascending // ou descending
            //   select perso;

            //// avec les expressions Lambda ASC
            //IEnumerable<Personne> persoQuery6 =
            //    personnes.Where(perso => perso.Budget >= 500)
            //    .OrderBy(perso => perso.Prenom);

            //// DESC
            //IEnumerable<Personne> persoQuery7 =
            //    personnes.Where(perso => perso.Budget >= 500)
            //    .OrderByDescending(perso => perso.Prenom);

            //foreach (Personne perso in persoQuery5)
            //{
            //    Console.WriteLine(perso);
            //}

            //// ordonner selon plusieurs colonnes
            //IEnumerable<Personne> persoQuery8 =
            //    from perso in personnes
            //    where (perso.Budget >= 500)
            //    orderby perso.Prenom ascending, perso.Budget descending
            //    select perso;

            // IEnumerable<Personne> persoQuery9 =
            //    personnes.Where(perso => perso.Budget >= 500)
            //    .OrderBy(perso => new { perso.Nom, perso.Prenom})
            //    .ThenByDescending(perso => perso.Budget);

            //foreach (Personne perso in persoQuery8)
            //{
            //    Console.WriteLine(perso);
            //}

            //// group ... by ... into : permet de retourner une sequence
            //// composee de cle(correspondant au critere du groupement) et
            //// valeur(correspondant a l’objet)

            //var persoQuery10 =
            //    from perso in personnes
            //    group perso by perso.Prenom into initial
            //    select initial;

            //// avec les expressions Lambda
            //var persoQuery11 = personnes.GroupBy(perso => perso.Prenom);

            //foreach (IGrouping<string, Personne> elt in persoQuery10)
            //{
            //    Console.WriteLine(elt.Key);
            //    foreach (var perso in elt)
            //    {
            //        Console.WriteLine($" {perso.Prenom}, {perso.Nom}");
            //    }
            //}

            //// join ... on ... equals : permet de faire des jointures entre
            //// deux enumerables

            //List<Personne> sportifs = new List<Personne>()
            //{
            //    new Personne(1, "wick", "john", 500),
            //    new Personne(4, "white", "mike", 800),
            //    new Personne(5, "wolf", "nicolas", 700),
            //    new Personne(6, "hamilton", "bill", 300),
            //};
            //List<Personne> sportifs2 = new List<Personne>()
            //{
            //    new Personne(1, "wick", "john", 500),
            //    new Personne(4, "white", "mike", 800),
            //    new Personne(5, "wolf", "nicolas", 700),
            //    new Personne(6, "hamilton", "bill", 300),
            //};


            //// Si on veut afficher la liste des personnes qui sont dans la liste sportifs ?
            //var persoSportifQuery =
            //    from perso in personnes
            //    join sportif in sportifs
            //    on perso.Num equals sportif.Num
            //    join sportif2 in sportifs2
            //    on perso.Num equals sportif2.Num
            //    select new
            //    {
            //        Name = perso.Nom,
            //        Sport = sportif.Prenom
            //    };

            //// avec les expressions Lambda
            //var persoSportifQuery2 = personnes
            //        .Join(sportifs, a => a.Num, u => u.Num,
            //             (a, u) => new { a, u })
            //       .Join(sportifs2, p => p.a.Num, u2 => u2.Num,
            //             (p, u2) => new { p, u2 });

            //foreach (var elt in persoSportifQuery2)
            //{
            //    Console.WriteLine(elt);
            //}

            using (var db = new ModelDbContext())
            {
                Personne personToSave = new Personne("Wick", "John", 4000);

                // Ajoute une personne
                db.Personnes.Add(personToSave);
                db.SaveChanges();

                var personnesList = from perso in db.Personnes
                                    select perso;

                // affiche une liste de personnes
                foreach (var elt in personnesList)
                {
                    Console.WriteLine(elt.Nom + " " + elt.Prenom);
                }

                Personne personToUpdate = (from perso in db.Personnes
                                 where perso.Num == 1
                                 select perso)
                                 .FirstOrDefault();

                Console.WriteLine(personToUpdate);

                personToUpdate.Nom = "Doe";
                personToUpdate.Prenom = "Marco";

                // Mise a jour d'une personne selon son Id
                db.Entry(personToUpdate).State = EntityState.Modified;
                // db.Personnes.Update(personToUpdate);
                db.SaveChanges();

                Personne personToUpdate2 = (from perso in db.Personnes
                                           where perso.Num == 1
                                           select perso)
                                           .FirstOrDefault();

                Console.WriteLine(personToUpdate2);

                // Supprime une personne
                Personne personToDelete = (from perso in db.Personnes
                                            where perso.Num == 4
                                            select perso)
                                           .FirstOrDefault();

                db.Personnes.Remove(personToDelete);
                db.SaveChanges();

                foreach (var elt in personnesList)
                {
                    Console.WriteLine(elt.Nom + " " + elt.Prenom);
                }

            }

            using (var db = new ModelDbContext())
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

                Personne personneToUpdate = db.Personnes.FirstOrDefault(p => p.Num == 4);

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

            Console.ReadLine();
        }
        public static void Print(int n)
        {
            Console.WriteLine(n);
        }
    }
}
