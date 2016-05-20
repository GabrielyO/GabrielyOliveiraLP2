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
            string palavra, chute;
            char letra;
            char[] mostrar = new char[20];
            int maxErros = 0;
            bool ganhou = false, chuteCerto = false ;

            palavra = Console.ReadLine();
            Console.Clear();
            for (int i = 0; i < palavra.Length; i++)
            {
                mostrar[i] = '-';
                Console.Write(" " + mostrar[i] + " ");                
            }
            while ( maxErros < 7 && !ganhou)
            {
                letra = char.Parse(Console.ReadLine());
                for (int k = 0; k < palavra.Length; k++)
                {
                    if (letra == palavra[k])
                        mostrar[k] = letra;
                    if (letra == '*')
                    {
                        Console.WriteLine("Você tem direito à apenas um chute");
                        chute = Console.ReadLine();
                        if (chute == palavra)
                        {
                            ganhou = true;
                            chuteCerto = true;
                            break;
                        }                            
                        else
                        {
                            ganhou = false;
                            maxErros = 7;
                            break;
                        }                            
                    }
                }
                if (chuteCerto == true)
                    break;
                maxErros++;
                Console.Clear();
                if ( maxErros < 7 )
                    for (int i = 0; i < palavra.Length; i++)
                        Console.Write(" " + mostrar[i] + " ");
             
                for (int i = 0; i < palavra.Length; i++)
                {
                    if (mostrar[i] == '-')
                    {
                        ganhou = false;
                        break;
                    }
                    else
                        ganhou = true;
                }                    
            }           

            if (ganhou == true)
                Console.WriteLine("Você ganhou");
            else
                Console.WriteLine("Você perdeu, a palavra era {0}", palavra);
                
        }
    }
}
