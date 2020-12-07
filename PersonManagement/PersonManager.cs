using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DavidTielke.PersonManagerApp.CrossCutting.Configuration.Contract;
using DavidTielke.PersonManagerApp.CrossCutting.DataClasses;
using DavidTielke.PersonManagerApp.Data.DataStoring.Contract;
using DavidTielke.PersonManagerApp.Logic.PersonManagement.Contract;

namespace DavidTielke.PersonManagerApp.Logic.PersonManagement
{
    public class PersonManager : IPersonManager
    {
        private readonly IPersonRepository _repository;
        private readonly int AGETRESHOLD;

        public PersonManager(IPersonRepository repository, 
            IConfigurator config)
        {
            _repository = repository;
            AGETRESHOLD = config.Get<int>("PersonManagement", 
                "AgeTreshold");
        }

        public IQueryable<Person> GetAllAdults()
            => _repository.Query.Where(p => p.Age >= AGETRESHOLD);

        public IQueryable<Person> GetAllChildren() =>
        _repository.Query.Where(p => p.Age < AGETRESHOLD);
    }
}
