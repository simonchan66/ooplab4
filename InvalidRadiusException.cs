using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    public class InvalidRadiusException : Exception
    {
        public InvalidRadiusException() : base("Radius must be greater than zero.") { }

        public InvalidRadiusException(double radius) : base($"Radius value {radius} is not valid. Radius must be greater than zero.") { }
    }
}
