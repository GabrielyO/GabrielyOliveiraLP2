using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Quadrado : PoligonoRegular
    {
        public override double Area()
        {
            return tamLado * tamLado;
        }
        public override double Perimetro()
        {
            return 4 * tamLado;
        }

    }
}
