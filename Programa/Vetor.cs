using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraVetorial
{
    internal class Vetor
    {
        public int x;
        public int y;
        public int z;

        public Vetor(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public double Modulo()
        {
            return Math.Sqrt(Math.Pow(this.x, 2) + Math.Pow(this.y, 2) + Math.Pow(this.z, 2));
        }
    }
}
