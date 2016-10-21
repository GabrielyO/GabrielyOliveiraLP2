using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace BD2016
{
    class Program
    {
        static void Main(string[] args)
        {
            int id = int.Parse(Console.ReadLine());
            string connStr = "Server=localhost;Database=bd2016;Uid=root;Pwd=";
            MySqlConnection conn = new MySqlConnection(connStr);

            MySqlCommand cmd = new MySqlCommand
            {
                Connection = new MySqlConnection("Server=localhost;Database=bd2016;Uid=root;Pwd="),
                CommandText = String.Format("SELECT P.NOME, P.PREÇO FROM produto P WHERE P.ID = {0};", id)
            };

            // CONSULTA
            cmd.Connection.Open();

            MySqlDataReader r = cmd.ExecuteReader();
            r.Read();
            string nome = r.GetString(0);
            double preco = r.GetDouble(1);
            Console.WriteLine("{0} : {1}", nome, preco);

            cmd.Connection.Close();

        }
    }
}
