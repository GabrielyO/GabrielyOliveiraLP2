using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Triangulo : PoligonoRegular
    {
        public override double Area()
        {
            return tamLado * tamLado * Math.Sqrt(3) / 4;
        } 
        public override double Perimetro()
        {
            return 3 * tamLado;
        }
    }
}
