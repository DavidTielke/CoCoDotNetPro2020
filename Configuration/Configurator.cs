using System.Collections.Generic;
using DavidTielke.PersonManagerApp.CrossCutting.Configuration.Contract;

namespace DavidTielke.PersonManagerApp.CrossCutting.Configuration
{
    public class Configurator : IConfigurator
    {
        private IDictionary<string, object> _items = new Dictionary<string, object>();

        private string ComposeKey(string category, string key) => $"{category}.{key}";

        public void Set(string category, string key, object value) 
            => _items[ComposeKey(category, key)] = value;

        public TValue Get<TValue>(string category, string key)
            => (TValue) _items[ComposeKey(category, key)];
    }
}