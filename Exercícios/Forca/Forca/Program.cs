using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forca
{
    class Program
    {
        static void Main(string[] args)
        {
            string palavra, letra;
            char[] mostrar = new char[20];
            int j = 0;

            palavra = Console.ReadLine();
            for (int i = 0; i < palavra.Length; i++)
            {
                mostrar[i] = '-';
                Console.Write(" " + mostrar[i] + " ");                
            }
                
        }
    }
}
