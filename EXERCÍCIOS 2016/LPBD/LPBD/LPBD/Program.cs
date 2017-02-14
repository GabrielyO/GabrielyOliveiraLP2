using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using LPBD;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Pessoa p = new Pessoa();
            //p.nome = Console.ReadLine();
            //p.altura = double.Parse(Console.ReadLine());

            //Cadastrar(p);
            //ExibirTudo();
            
            limpar(9);
            ExibirTudoComList();

            /*

            //Execução

            cmd.Connection.Open();
            int qtd = Convert.ToInt32(cmd.ExecuteScalar());
            cmd.Connection.Close();

            Console.WriteLine(qtd);

            

            cmd.CommandText = "SELECT nome FROM Pessoa WHERE altura = (SELECT Max(altura) FROM Pessoa);";
            cmd.Connection.Open();
            resultado = cmd.ExecuteReader();
            resultado.Read();
            string maisAlta = resultado.GetString(0);
            cmd.Connection.Close();
            Console.WriteLine("A pessoa mais alta é {0}", maisAlta);
            */
        }

        static void Cadastrar(Pessoa p)
        {
            MySqlCommand cmd = new MySqlCommand()
            {
                Connection = new MySqlConnection("Server=localhost;Database=lp;Uid=root;Pwd="),
                CommandText = "INSERT INTO pessoa (NOME, ALTURA) VALUES (@nome, @altura);"
            };

            cmd.Parameters.AddWithValue("@nome", p.nome);
            cmd.Parameters.AddWithValue("@altura", p.altura);

            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }
        static void ExibirTudoComList()
        {
            List<Pessoa> pessoas = new List<Pessoa>();

            MySqlCommand cmd = new MySqlCommand()
            {
                Connection = new MySqlConnection("Server=localhost;Database=lp;Uid=root;Pwd="),
                CommandText = "SELECT * FROM pessoa;"
            };

            cmd.Connection.Open();
            MySqlDataReader resultado;
            resultado = cmd.ExecuteReader();

            if (resultado.HasRows)
            {
                while (resultado.Read())
                {
                    Pessoa p = new Pessoa();
                    p.id = resultado.GetInt32(0);
                    p.nome = resultado.GetString(1);
                    p.altura = resultado.GetDouble(2);
                    pessoas.Add(p);
                }
            }

            foreach (Pessoa p in pessoas)
            {
                Console.WriteLine("Id: {0} Nome: {1} Altura: {2}", p.id, p.nome, p.altura);
            }
            cmd.Connection.Close();

        }
        static void ExibirTudo()
        {
            MySqlCommand cmd = new MySqlCommand()
            {
                Connection = new MySqlConnection("Server=localhost;Database=lp;Uid=root; Pwd="),
                CommandText = "SELECT * FROM Pessoa;"
            };
            cmd.Connection.Open();
            MySqlDataReader resultado;
            resultado = cmd.ExecuteReader();
            if (resultado.HasRows)
            {
                while (resultado.Read())
                {
                    int id = resultado.GetInt32(0);
                    string nome = resultado.GetString(1);
                    double altura = resultado.GetDouble(2);
                    Console.WriteLine("Id: {0} Nome: {1} Altura: {2}", id, nome, altura);
                }
            }
            cmd.Connection.Close();
        }
        static void limpar(int id)
        {
            MySqlCommand cmd = new MySqlCommand()
            {
                Connection = new MySqlConnection("Server=localhost;Database=lp;Uid=root;Pwd="),
                CommandText = "DELETE FROM pessoa WHERE ID = @id;"
            };

            cmd.Parameters.AddWithValue("@id", id);

            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }

    }
}