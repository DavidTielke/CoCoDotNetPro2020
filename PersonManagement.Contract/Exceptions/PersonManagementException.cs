using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace DavidTielke.PersonManagerApp.Logic.PersonManagement.Contract.Exceptions
{
    [Serializable]
    public class PersonManagerException : Exception
    {
        public PersonManagerException()
        {
        }

        public PersonManagerException(string message) : base(message)
        {
        }

        public PersonManagerException(string message, Exception inner) : base(message, inner)
        {
        }

        protected PersonManagerException(
            SerializationInfo info,
            StreamingContext context) : base(info, context)
        {
        }
    }
}
