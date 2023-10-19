using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    public class Circle
    {
        private double radius;

        public void SetRadius(double radius)
        {
            if (radius > 0)
            {
                this.radius = radius;
            }
            else
            {
                throw new InvalidRadiusException(radius);
            }
        }

        public override string ToString()
        {
            return "Radius of the circle : " + radius;
        }
    }
}
