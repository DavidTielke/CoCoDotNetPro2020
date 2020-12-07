using System;
using System.Linq;
using DavidTielke.PersonManagerApp.CrossCutting.Configuration;
using DavidTielke.PersonManagerApp.CrossCutting.Configuration.Contract;
using DavidTielke.PersonManagerApp.Data.DataStoring;
using DavidTielke.PersonManagerApp.Data.DataStoring.Contract;
using DavidTielke.PersonManagerApp.Logic.PersonManagement;
using DavidTielke.PersonManagerApp.Logic.PersonManagement.Contract;

namespace DavidTielke.PersonManagerApp.UI.ConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            IConfigurator config = new Configurator();
            config.Set("PersonManagement","AgeTreshold",18);
            IPersonRepository repo = new PersonRepository();
            IPersonManager manager = new PersonManager(repo, config);

            var adults = manager.GetAllAdults();
            var children = manager.GetAllChildren();

            Console.WriteLine("### Erwachsene ###");
            adults.ToList().ForEach(a => Console.WriteLine(a.Name));

            Console.WriteLine("### Kinder ###");
            children.ToList().ForEach(c => Console.WriteLine(c.Name));
        }
    }
}
