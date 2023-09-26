using System;

public class Person {

    public string Nom {get;set};
    public string Prenom {get;set};

    public Person(string nom, string prenom) {
        Nom = nom;
        Prenom = prenom;
        
    }
}

public static void Main() {

    Person person1 = new Person(nom, prenom)

    Console.WriteLine("Entrez votre noms")
    person1.Nom = Console.Readline()

    Console.WriteLine("Entrez votre prénoms")
    person1.Prenom = Console.Readline()

    Console.WriteLine("Nom : "+ person1.Nom +"\nPrénom :"+ person1.Prenom)
    
}
       







    