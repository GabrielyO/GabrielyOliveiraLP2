using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List <Carro> carros = new List<Carro>();
            string placaAux;
            bool achou = false;
            int i = 0;
            
            for (i = 0; i < n; i++)
            {
                Carro c = new Carro();
                c.Placa = Console.ReadLine();
                c.Ano = int.Parse(Console.ReadLine());
                c.Modelo = Console.ReadLine();                 
                carros.Add(c);
            }
            Console.Clear();

            Console.WriteLine("Digite uma PLACA");
            placaAux = Console.ReadLine();
            Console.Clear();
            
            for (i = 0; i < n; i++)
            {
                if (placaAux == carros[i].Placa)
                {
                    achou = true;
                    break;
                }
                else
                    achou = false;   
            }
            if (achou == true)
            {
                Console.WriteLine("Placa = " + carros[i].Placa);
                Console.WriteLine("Ano = " + carros[i].Ano);
                Console.WriteLine("Modelo = " + carros[i].Modelo);
            }
            else
                Console.WriteLine("Placa não encontrada");
              
                                                                                                                                                                        
        }
    }
}
