using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2.Tools.Exeptions
{
 
    class LateBirthdayException : Exception
    {
        public LateBirthdayException()
        {
        }

        public LateBirthdayException(string message) : base(message)
        {
        }

        public LateBirthdayException(string message, Exception inner) : base(message, inner)
        {
        }
    }
}
