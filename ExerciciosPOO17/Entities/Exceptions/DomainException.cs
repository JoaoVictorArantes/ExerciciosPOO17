using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosPOO17.Entities.Exceptions
{
    class DomainException : ApplicationException
    {
        public DomainException(String message) : base(message) { }

    }
}
