using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseException.Entities.Exceptions
{
    internal class DominionException : ApplicationException
    {
        public DominionException(string message) : base(message) 
        {
        }
    }
}
