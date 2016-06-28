using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coordenadas
{
    class Program
    {
        static void Main(string[] args)
        {
            double sx = 0, sy = 0, x, y, xm, ym;

            int N = int.Parse(Console.ReadLine());

            List<Ponto> pontos = new List<Ponto>();
            for (int i = 0; i < N; i++)
            {                
                x = double.Parse(Console.ReadLine());
                y = double.Parse(Console.ReadLine());
                Console.Beep();
                Ponto p = new Ponto(x,y);
                pontos.Add(p);                
                Console.Clear();
            }
            for (int i = 0; i < pontos.Count; i++)
            {
                sx += pontos[i].x;
                sy += pontos[i].y;
            }
            xm = sx / N;
            ym = sy / N;
            Console.WriteLine("O ponto médio é ({0} , {1})", xm, ym);       

        }
    }
}
