using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnSql.Model
{
    public class NullContactException : Exception
    {
        public NullContactException(string message) : base(message) //child classda qabul qilingan qiymatni parent classga berib yuborish
        {
            
        }
    }
}
