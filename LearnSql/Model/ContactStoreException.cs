using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnSql.Model
{
    public class ContactStoreException : Exception
    {
        public ContactStoreException(string message, Exception innerException) : base(message, innerException)
        {
            
        }
    }
}
