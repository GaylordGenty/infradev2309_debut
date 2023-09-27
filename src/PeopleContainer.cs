using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace src
{
    class PeopleContainer : IPersonContainer
    {
        public List<Person> Persons {get; set;}

        public PeopleContainer() 
        { 
            Persons  = new List<Person>();
        }

        public List<Person> SortByFirstName()
        {
            return Persons.OrderBy(p => p.Prenom).ToList();
             
        }

        public List<Person> SortByLastName()
        {
            return Persons.OrderBy(p => p.Nom).ToList();
        }
    }
}
