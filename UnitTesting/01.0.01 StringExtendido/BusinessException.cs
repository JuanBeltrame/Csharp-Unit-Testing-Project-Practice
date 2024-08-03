using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._0._01_StringExtendido
{
    public class BusinessException : Exception
    {
        public BusinessException(string mensaje) : base(mensaje)
        {

        }
    }
}
