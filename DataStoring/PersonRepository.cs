using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DavidTielke.PersonManagerApp.CrossCutting.DataClasses;
using DavidTielke.PersonManagerApp.Data.DataStoring.Contract;

namespace DavidTielke.PersonManagerApp.Data.DataStoring
{
    public class PersonRepository : IPersonRepository
    {
        public IQueryable<Person> Query =>
            new List<Person>
            {
                new Person(1, "David",36),
                new Person(2, "Lena", 34),
                new Person(3, "Maximilian", 8),
                new Person(4, "Teddy", 7)
            }.AsQueryable();
    }
}
