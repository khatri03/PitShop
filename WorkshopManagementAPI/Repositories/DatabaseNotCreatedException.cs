using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace PitShop.WorkshopManagementAPI.Repositories
{
    public class DatabaseNotCreatedException : Exception
    {
        public DatabaseNotCreatedException()
        {
        }

        public DatabaseNotCreatedException(string message) : base(message)
        {
        }

        public DatabaseNotCreatedException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected DatabaseNotCreatedException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
