using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace src
{
    interface IPersonContainer
    {
        List<Person> SortByLastName();
        List<Person> SortByFirstName();
    }
}
