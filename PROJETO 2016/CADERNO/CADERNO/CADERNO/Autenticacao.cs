using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CADERNO
{
    static class Autenticacao
    {
        static string nome;
        static string senha;

        public static void login(string nome1, string senha1)
        {
            nome = nome1;
            senha = senha1;
        }
    }
}
