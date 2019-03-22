using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2.Tools.Exeptions
{
   
    class WrongNameException : Exception
    {
        public WrongNameException()
        {
        }

        public WrongNameException(string message) : base(message)
        {
        }

        public WrongNameException(string message, Exception inner) : base(message, inner)
        {
        }
    }
}
