using System;
using System.Collections.Generic;
using src;

namespace src
{
    class Program
    {
        public static void Main()
        {
            PeopleContainer pContainer = new PeopleContainer();

            Person person1 = new Person();

            Console.WriteLine("Entrez votre noms");
            person1.Nom = Console.ReadLine();

            Console.WriteLine("Entrez votre prénoms");
            person1.Prenom = Console.ReadLine();

            pContainer.Persons.Add(person1);

            Console.WriteLine("Nom : " + person1.Nom + "\nPrénom :" + person1.Prenom);

            Console.WriteLine(pContainer.Persons.Count);

        }
    }
}

       







    