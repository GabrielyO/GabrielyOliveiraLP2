using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            double perimetro, auxPerimetro = 0, auxId = 0;
            int id = 0;
            int N = int.Parse(Console.ReadLine());
            

            for ( int i = 0; i < N; i++)
            {
                Triangulo T = new Triangulo(20 , 30 , 40);
                Console.WriteLine("Digite o Id");
                T.Id = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o CÓDIGO DA COR");
                T.Cor = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o LADO A");
                T.LadoA = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite o LADO B");
                T.LadoB = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite o LADO C");
                T.LadoC = double.Parse(Console.ReadLine());

                perimetro = T.LadoA + T.LadoB + T.LadoC;

                if (perimetro > auxPerimetro)
                {
                    auxPerimetro = perimetro;
                    auxId = T.Id;
                }
            }

            Console.WriteLine("A ID do maior triangulo é = {0}, e o PERIMETRO é = {1}", auxId, auxPerimetro);         

        }
    }
}
