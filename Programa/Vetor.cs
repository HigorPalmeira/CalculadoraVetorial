using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraVetorial
{
    internal class Vetor
    {
        public double x;
        public double y;
        public double z;

        public Vetor(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public double Modulo()
        {
            return Math.Sqrt(Math.Pow(this.x, 2) + Math.Pow(this.y, 2) + Math.Pow(this.z, 2));
        }

        public Vetor Versor()
        {
            double modulo = this.Modulo();
            return new((this.x / modulo), (this.y / modulo), (this.z / modulo));
        }
    }
}
