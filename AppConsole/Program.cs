using AppConsole.Exceptions;
using AppConsole.Interfaces;
using AppConsole.Models;
using System;
using System.Collections;
using System.Collections.Generic;

namespace AppConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Employe.nbrEmployes);

            Employe e1 = new Employe()
                {
                    Matricule = 1,
                    Nom = "Wick",
                    Prenom = "John",
                    DateNaissance = new DateTime(1999, 8, 8),
                    DateEmbauche = new DateTime(2020, 2, 3),
                    Salaire = 2000
                };

            e1.AfficheEmploye();

            Console.WriteLine(Employe.nbrEmployes);

            Employe e2 = new Employe(2, "Doe", "John", new DateTime(1999, 8, 8), new DateTime(2020, 2, 3), 2000);
             e2.AfficheEmploye();

            Console.WriteLine(Employe.nbrEmployes);

            //Console.WriteLine($"Je suis l'employe {e1.Nom} {e1.Prenom} {e1.DateNaissance}");
            //Console.WriteLine($"Je suis l'employe {e2.Nom} {e2.Prenom} {e2.DateNaissance}");

            Voiture v1 = new Voiture(1, "205GTI", 10000);
            Console.WriteLine(v1);
            v1.Demarrer();
            v1.Accelerer();

            Camion c1 = new Camion(1, "Caterpillar", 50000);
            Console.WriteLine(c1);
            c1.Demarrer();
            c1.Accelerer();

            // Ecrire les classe Personne, Employé, Chef et Directeur.
            // créez un programme de test qui comporte tableau de huit personnes avec cinq employés, deux chefs et un directeur
            // (8 références de la classe Personne dans lesquelles ranger 5 instances de la classe Employé, 2 de la classe Chef et 1 de la classe Directeur).
            // Affichez l'ensemble des éléments du tableau à l'aide de for.

            // Une classe Personne qui comporte trois champs privés, nom, prénom et date de naissance.
            // Cette classe comporte un constructeur pour permettre d'initialiser les données.
            // Elle comporte également une méthode polymorphe Afficher pour afficher les données de chaque personne.

            // Une classe Employé qui dérive de la classe Personne, avec en plus un champ Salaire accompagné
            // de sa propriété, un constructeur et la redéfinition de la méthode Afficher.

            // Une classe Chef qui dérive de la classe Employé, avec en plus un champ Service accompagné
            // de sa propriété, un constructeur et la redéfinition de la méthode Afficher.

            // Une classe Directeur qui dérive de la classe Chef, avec en plus un champ Société accompagné
            // de sa propriété, un constructeur et la redéfinition de la méthode Afficher.

            Personne p = new Personne();
            p.Nom = "wick";
            p.Prenom = "john";

            p.direBonjour();

            Personne p2 = new Personne("bob", "mike");

            Personne etu1 = new Etudiant("Bob", "Mike", 1200);

            etu1.direBonjour();

            Etudiant etu2 = new Etudiant("Bob", "Mike2", 450);

            etu2.direBonjour();

            p2.sayHello();

            ListePersonnes mesAmis = new ListePersonnes(2);
            mesAmis[0] = p;
            mesAmis[1] = p2;

            foreach (Personne perso in mesAmis)
            {
                perso.direBonjour();
            }

            for (int i = 0; i < mesAmis.NbrPersonnes; i++)
            {
                Console.WriteLine("Amis {0} est {1} {2}", i,
                mesAmis[i].Prenom, mesAmis[i].Nom);
            }

            foreach (int i in Power(2, 8))
            {
                Console.Write("{0} ", i); // 2 4 8 16 32 64 128 256
            }

            Livre livre = new Livre();
            livre.titre = "Programmation C#";
            livre.isbn = "1111111111";
            livre.nbrPages = 1000;
            livre.AfficherDetails();

            Livre livre2 = livre;
            livre2.titre = "Struct C#";
            livre2.isbn = "222222222";
            livre2.nbrPages = 200;

            Livre livre3 = livre2;
            livre2.titre = "Struct Cobol";
            livre2.isbn = "444444444";
            livre2.nbrPages = 6000;

            Console.WriteLine("\n***livre***");
            livre.AfficherDetails();
            Console.WriteLine("\n***livre2***");
            livre2.AfficherDetails();
            Console.WriteLine("\n***livre3***");
            livre3.AfficherDetails();

            // Permutation valeur
            int n = 2;
            int m = 5;
            Permutation(ref n, ref m);
            Console.WriteLine($" Apres permutation, n = {n}");
            Console.WriteLine($" Apres permutation, m = {m}");

            int x, y;
            FindMinMax(2, 3, out x, out y);
            Console.WriteLine($" le max de 2 et 3 est = {x}");
            Console.WriteLine($" le min de 2 et 3 est = {y}");

            int h = FindMaxFromNValue(2, 8, 5);
            Console.WriteLine($"Le max est : { h }");

            int g = FindMaxFromNValue(1, 7, 8, 2);
            Console.WriteLine($"Le max est : { g }");

            // Collections

            Queue languages = new Queue(); // FIFO
            languages.Enqueue("Java");
            languages.Enqueue("C#");
            languages.Enqueue("Python");
            languages.Enqueue("C++");

            foreach (object o in languages)
            {
                Console.WriteLine(o);
            }

            Stack languages3 = new Stack(); // LIFO(Last In First Out)
            languages3.Push("Java");
            languages3.Push("C#");
            languages3.Push("Python");
            languages3.Push("C++");

            foreach (var o in languages3)
            {
                Console.WriteLine(o);
            }

            Stack<string> languages7 = new Stack<string>();
            languages7.Push("Java");
            languages7.Push("C#");
            languages7.Push("Python");
            languages7.Push("C++");

            foreach (string language in languages7)
            {
                Console.WriteLine(language);
            }

            SortedList languages2 = new SortedList();
            languages2.Add(1, "Java");
            languages2.Add(2, "C#");
            languages2.Add(3, "Python");
            languages2.Add(4, "C++");

            foreach (DictionaryEntry language in languages2)
            {
                Console.WriteLine("Clé: {0}, Valeur: {1}", language.Key, language.Value);
            }

            SortedList<int, string> languages9 = new SortedList<int, string>();
            languages9.Add(1, "Java");
            languages9.Add(2, "C#");
            languages9.Add(3, "Python");
            languages9.Add(4, "C++");

            foreach (KeyValuePair<int, string> language in languages9)
            {
                Console.WriteLine("Clé: {0}, Valeur: {1}", language.Key, language.Value);
            }

            Queue<string> languages8 = new Queue<string>();
            languages8.Enqueue("Java");
            languages8.Enqueue("C#");
            languages8.Enqueue("Python");
            languages8.Enqueue("C++");

            foreach (string language in languages8)
            {
                Console.WriteLine(language);
            }

            List<Personne> personnes = new()
            {
                new Personne("NOM1", "PRENOM1"),
                new Personne("NOM2", "PRENOM2"),
                new Personne("NOM3", "PRENOM3")
            };

            personnes.ForEach((p) => Console.WriteLine(p));

            foreach (var personne in personnes)
            {
                Console.WriteLine(personne.Nom);
            }

            List<int> numbers2 = new List<int>();
            numbers2.Add(10);
            numbers2.Add(20);
            numbers2.Add(30);
            numbers2.Add(40);

            foreach (int nbr in numbers2)
            {
                Console.WriteLine(nbr);
            }

            ArrayList numbers = new ArrayList();
            numbers.Add(1);       //int
            numbers.Add(1.9803);  //float
            numbers.Add("one");   //string
            numbers.Add('o');     //char

            foreach (object nbr in numbers)
            {
                Console.Write("{0} ", nbr);
            }

            Hashtable languages5 = new Hashtable();
            languages5.Add(1, "Java");
            languages5.Add(2, "C#");
            languages5.Add(3, "Python");
            languages5.Add(4, "C++");

            foreach (DictionaryEntry language in languages5)
            {
                Console.WriteLine("Clé: {0}, Valeur: {1}", language.Key, language.Value);
            }

            Dictionary<int, string> languages6 = new Dictionary<int, string>();

            languages6.Add(1, "Java");
            languages6.Add(2, "C#");
            languages6.Add(3, "Python");
            languages6.Add(4, "C++");

            foreach (KeyValuePair<int, string> language in languages6)
            {
                Console.WriteLine("Clé: {0}, Valeur: {1}", language.Key, language.Value);
            }
            Console.WriteLine(languages6[1]);

            // Utilisation d'un tuple qui nous permet de retourner plus d'une valeur en retour d'une methode

            Program program = new Program();
            var p1 = program.getPersonne2();

            string nom = p1.nom;
            string prenom = p1.prenom;

            Console.WriteLine("Nom: {0}, Prenom: {1}", nom, prenom);

            Console.WriteLine(Sports.Tennis);

            Sports sport = Sports.Foot;
            Console.WriteLine(sport);

            // Creation d'un ValueTuple
            // A la difference d'un tuple, un ValueTuple accepte plus de 8 elements
            var t = (1, 2, 3, 4, 5, 6, 7, 8, 9);
            Console.WriteLine(t.Item9);

            (int note1, int note2, int note3) notes = (10, 20, 13);
            Console.WriteLine(notes.note1);

            Console.WriteLine(notes.Item1);


            //Exercice
            //Dans cet exercice, vous devez créer une petite grille d’arrivés dans un Dictionary, c’est à dire que chaque position sera associée à un nom de joueur.

            //1.Créer un Dictionary contenant des clés de type Integer et des valeurs de type String.
            //2.Ajouter les éléments suivants: (1, “Player 5”), (2, “Player 1”), (3, “Player 3”), (4, “Player 2”) and(5, “Player 4”).Ceci compte pour les positions finales de la course.
            //3.Afficher le nombre total de joueurs dans la console.
            //4.interchanger le Player 5 qui est à la position 1 par le Player 4 qui est à la position 5.
            //5.Afficher tout les joueurs et leur position respective dans la console.
            //6.Supprimer toutes les données du Dictionary.

           //1. Création du Dictionary
           Hashtable Positions = new()
            {
                //2. Ajout des valeurs
                { 1, "Player 5" },
                { 2, "Player 1" },
                { 3, "Player 3" },
                { 4, "Player 2" },
                { 5, "Player 4" }
            };

            //3. Affichage du nombre de participants
            Console.WriteLine("There are {0} positions in the grid.", Positions.Count);

            //4. Remplacement du joueur à la position 1 par celui à la position 5
            Positions.Remove(1);
            Positions.Remove(5);

            Positions.Add(1, "Player 4");
            Positions.Add(5, "Player 5");

            //5. Affichage des joueurs et de leur position
            for (int Index = 1; Index <= Positions.Count; Index++)
                Console.WriteLine("{0} arrived at position {1} ", Positions[Index], Index);

            //6. Suppression de toutes les valeurs dans le Dictionary
            Positions.Clear();

            DireBonjour("Wick"); // affiche Bonjour Wick

            // Use Delegate

            PremierDelegate d;
            //d = new PremierDelegate(DireBonjour);

            //d = DireBonjour;

            d = delegate (string nom) {
                DireBonjour(nom);
            };

            d("Bob");

            Calcul calcul;
            calcul = Somme;
            calcul = calcul + Produit + Division + Soustraction;
            calcul(7, 5);

            // Pour connaitre le nombre de methodes abonnées ä notre delegue
            Console.WriteLine(calcul.GetInvocationList().Length);

            Calcul calcul2 = Division;
            calcul2 = calcul2 + Soustraction;
            calcul2(5, 5);

            MonEvent = Somme;
            MonEvent += Produit;

            MonTrigger();

            int a = 5, b = 0;
            try
            {
                Console.WriteLine(a / b);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception : Division par zero ");
                //return;
            }
            Console.WriteLine("Fin de calcul");

            Adresse adresse = null;
            try
            {
                adresse = new Adresse("PARADIS", "Marseille", "1300");
            }
            catch (Exception e) when
            (e is IncorrectCodePostalException || e is IncorrectStreetNameException)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Instruction executee systematiquement");
            }

            Console.Out.WriteLine("Compte 1: ");
            string cin, nomm, prenomm, tel;
            Console.Out.Write("Donner Le CIN: ");
            cin = Console.In.ReadLine();
            Console.Out.Write("Donner Le Nom: ");
            nomm = Console.In.ReadLine();
            Console.Out.Write("Donner Le Prénom: ");
            prenomm = Console.In.ReadLine();
            Console.Out.Write("Donner Le numéro de télephone: ");
            tel = Console.In.ReadLine();

            Compte C1 = new Compte(new Client(cin, nomm, prenomm, tel));
            Console.Out.WriteLine("Détails du compte: ");
            C1.Afficher();

            double montant;
            Console.Out.Write("Donner le montant à déposer: ");
            montant = double.Parse(Console.In.ReadLine());
            C1.Crediter(montant);
            C1.Afficher();

            Console.Out.Write("Donner le montant à retirer: ");
            montant = double.Parse(Console.In.ReadLine());
            C1.Debiter(montant);
            C1.Afficher();

            Console.Out.WriteLine("\n\nCompte 2: ");
            Console.Out.Write("Donner Le CIN: ");
            cin = Console.In.ReadLine();
            Console.Out.Write("Donner Le Nom: ");
            nom = Console.In.ReadLine();
            Console.Out.Write("Donner Le Prénom: ");
            prenom = Console.In.ReadLine();
            Console.Out.Write("Donner Le numéro de télephone: ");
            tel = Console.In.ReadLine();

            Compte C2 = new Compte(new Client(cin, nom, prenom, tel));
            Console.Out.WriteLine("Détails du compte: ");
            C2.Afficher();

            Console.Out.WriteLine("Crediter le compte 2 à partir du compte 1");
            Console.Out.Write("Donner le montant à déposer: ");
            montant = double.Parse(Console.In.ReadLine());
            C2.Crediter(C1, montant);

            Console.Out.WriteLine("Débiter le compte 1 et créditer le compte 2");
            Console.Out.Write("Donner le montant à retirer: ");
            montant = double.Parse(Console.In.ReadLine());
            C1.Debiter(C2, montant);

            C1.Afficher();
            C2.Afficher();

            Compte.Nombre_Comptes();

            Console.ReadLine();          
        }

        public static void Somme(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        public static void Produit(int a, int b)
        {
            Console.WriteLine(a * b);
        }
        public static void Soustraction(int a, int b)
        {
            Console.WriteLine(a - b);
        }
        public static void Division(int a, int b)
        {
            Console.WriteLine(a / b);
        }

        public delegate void Calcul(int x, int y);

        private Tuple<string, string> getPersonne()
        {
            return new Tuple<string, string>("Wick", "John");
        }

        private (string nom ,string prenom) getPersonne2()
        {
            return ("Doe", "John");
        }

        public static int FindMaxFromNValue(params int[] list)
        {
            int max = list[0];
            for (int i = 1; i < list.Length; i++)
            {
                if (list[i] > max)
                    max = list[i];
            }
            return max;
        }

        public static void FindMinMax(int i, int j, out int max, out int min)
        {
            max = i > j ? i : j;
            min = i < j ? i : j;
        }

        // Methode qui retourne tous les exposants de x jusqu'a n
        public static IEnumerable<int> Power(int x, int n)
        {
            int result = 1;
            for (int i = 0; i < n; i++)
            {
                result = result * x;
                // yield permet de retourner plusieurs elements un par un
                yield return result;
            }
        }

        // Utiliser ref pour travailler sur la valeur originelle
        public static void Permutation(ref int i, ref int j)
        {
            int aux = i;
            i = j;
            j = aux;
        }

        // En C#, un délégué représente un pointeur sur méthode.
        // Un délégué est un type qui représente des références aux méthodes avec une liste
        // de paramètres et un type de retour particuliers. Lorsque vous instanciez un délégué,
        // vous pouvez associer son instance à toute méthode ayant une signature et un type de retour compatibles.

        public static void DireBonjour(string nom)
        {
            Console.WriteLine($"Bonjour {nom}");
        }

        public delegate void PremierDelegate(string s);

        public static event Calcul MonEvent;

        public static void MonTrigger()
        {
            MonEvent(7, 5);
        }
    }
}

