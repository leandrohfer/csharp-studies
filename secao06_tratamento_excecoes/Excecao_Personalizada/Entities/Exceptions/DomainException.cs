using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excecao_Personalizada.Entities.Exceptions
{
    class DomainException : ApplicationException
    {
        public DomainException( string message) : base(message)
        {

        }
    }
}
