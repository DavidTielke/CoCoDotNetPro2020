using System;
using System.Linq;
using DavidTielke.PersonManagerApp.CrossCutting.Configuration;
using DavidTielke.PersonManagerApp.CrossCutting.Configuration.Contract;
using DavidTielke.PersonManagerApp.Data.DataStoring;
using DavidTielke.PersonManagerApp.Data.DataStoring.Contract;
using DavidTielke.PersonManagerApp.Logic.PersonManagement;
using DavidTielke.PersonManagerApp.Logic.PersonManagement.Contract;
using Ninject;

namespace DavidTielke.PersonManagerApp.UI.ConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            // Kernel (K)
            var kernel = new StandardKernel();

            // Mappings (M)
            kernel.Bind<IConfigurator>().To<Configurator>().InSingletonScope();
            kernel.Bind<IPersonManager>().To<PersonManager>().InTransientScope();
            kernel.Bind<IPersonRepository>().To<PersonRepository>().InTransientScope();

            // Anwendung (APP)
            var configurator = kernel.Get<IConfigurator>();
            configurator.Set("PersonManagement", "AgeTreshold", 18);

            var manager = kernel.Get<IPersonManager>();

            var adults = manager.GetAllAdults();
            Console.WriteLine("### Erwachsene ###");
            adults.ToList().ForEach(a => Console.WriteLine(a.Name));

            var children = manager.GetAllChildren();
            Console.WriteLine("### Kinder ###");
            children.ToList().ForEach(c => Console.WriteLine(c.Name));
        }

    }
}
