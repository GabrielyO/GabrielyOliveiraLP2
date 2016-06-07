using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Triangulo
    {
        private double _ladoA;
        public double LadoA
        {
            get { return _ladoA; }
            set
            {
                if (value > 0)
                    _ladoA = value;
            }
        }
        private double _ladoB;
        public double LadoB
        {
            get { return _ladoB; }
            set
            {
                if (value > 0)
                    _ladoB = value;
            }
        }
        private double _ladoC;
        public double LadoC
        {
            get { return _ladoC; }
            set
            {
                if (value > 0)
                    _ladoC= value;
            }
        }
        public int Id {get; set;}
        private int _cor;
        public int Cor
        {
            get { return _cor; }
            set
            {
                if (value >= 0 && value <= (Math.Pow(2, 24) - 1))
                    _cor = value;
            }
        }

        public Triangulo(int LadoA, int LadoB, int LadoC)
        {
            if ( LadoA > 0 && LadoB > 0 && LadoC > 0)
                if ( (LadoA + LadoB) < LadoC || (LadoB + LadoC) < LadoA || (LadoA + LadoC) < LadoB )
                {
                    this.LadoA = LadoA;
                    this.LadoB = LadoB;
                    this.LadoC = LadoC;
                }         
        }
    }
}
