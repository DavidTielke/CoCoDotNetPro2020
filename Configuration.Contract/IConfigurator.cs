﻿namespace DavidTielke.PersonManagerApp.CrossCutting.Configuration.Contract
{
    public interface IConfigurator
    {
        void Set(string category, string key, object value);
        TValue Get<TValue>(string category, string key);
    }
}