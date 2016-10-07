using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Circulo : FormaGeometrica
    {
        public double raio { get; set; }
        public override double Area()
        {
            return Math.PI * raio * raio;
        }
        public override double Perimetro()
        {
            return 2 * Math.PI * raio;
        }
    }
}
