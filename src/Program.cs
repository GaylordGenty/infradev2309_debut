using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using src;

namespace src
{
    class Program
    {
        public static void creatPerson(string nom, string prenom, PeopleContainer pC)
        {

            Person person = new Person();

            person.Prenom = prenom;
            person.Nom = nom;

            pC.Persons.Add(person);
        }


        public static void Main()
        {
            PeopleContainer pContainer = new PeopleContainer();
            Person person;
                     

            person = new Person();

            creatPerson("Bébou", "Badabou", pContainer);
            creatPerson("Stylo", "Quatrecouleur", pContainer);
            creatPerson("Sax", "Hubert", pContainer);


            bool b = true;
            string s;

            do
            {
                Console.WriteLine("voulez vous ajouter un nouvel utilisateur? oui/non ");
                s = Console.ReadLine();
                if (s == "oui")
                {
                    person = new Person();
                    Console.WriteLine("Entrez votre nom");
                    person.Nom = Console.ReadLine();
                    Console.WriteLine("Entrez votre prénom");
                    person.Prenom = Console.ReadLine();
                    pContainer.Persons.Add(person);
                }
                else
                {
                    Console.WriteLine("Good Bye Marylou!");
                    foreach(Person p in pContainer.Persons)
                    {
                        Console.WriteLine(p.Prenom + " " + p.Nom);
                    }
                    b = false;
                }
            }
            while (b);
        }
        
    }
}









