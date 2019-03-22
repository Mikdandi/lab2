using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2.Tools.Exeptions
{

    class WrongEmailException : Exception
    {
        public WrongEmailException()
        {
        }

        public WrongEmailException(string message) : base(message)
        {
        }

        public WrongEmailException(string message, Exception inner) : base(message, inner)
        {
        }
    }
}
