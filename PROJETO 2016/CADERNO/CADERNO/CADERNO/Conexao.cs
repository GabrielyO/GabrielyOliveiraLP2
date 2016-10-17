using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace CADERNO
{
    class Conexao
    {
        public MySqlConnection conn = new MySqlConnection();

        public void conectar()
        {
            conn.ConnectionString = "Server=localhost;Database=caderno;Uid=root;Pwd=;";
            conn.Open();
        }

        public void desconectar()
        {
            conn.Close();
        }
    }
}
