using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace DavidTielke.PersonManagerApp.Logic.PersonManagement.Contract.Exceptions
{
    [Serializable]
    public class DataStoringException : Exception
    {
        public DataStoringException()
        {
        }

        public DataStoringException(string message) : base(message)
        {
        }

        public DataStoringException(string message, Exception inner) : base(message, inner)
        {
        }

        protected DataStoringException(
            SerializationInfo info,
            StreamingContext context) : base(info, context)
        {
        }
    }
}
