using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CADERNO
{
    public partial class deletarUsuario : Form
    {
        public deletarUsuario()
        {
            InitializeComponent();
        }

        private void DELETAR_Click(object sender, EventArgs e)
        {
            int chamada;
            string senha;
            bool existe = false;
            List<Aluno> alunos = new List<Aluno>();

            chamada = Convert.ToInt32(NDELCADASTRO.Text);
            senha = Convert.ToString(SENHADELCADASTRO.Text);

            MySqlCommand cmd = new MySqlCommand()
            {
                Connection = new MySqlConnection("Server=localhost;Database=caderno;Uid=root;Pwd="),
                CommandText = "SELECT * FROM aluno;"
            };
            MySqlCommand cmd2 = new MySqlCommand()
            {
                Connection = new MySqlConnection("Server=localhost;Database=caderno;Uid=root;Pwd="),
                CommandText = "DELETE FROM aluno WHERE ID = @id AND SENHA = @senha;"
            };

            cmd.Connection.Open();
            MySqlDataReader resultado;
            resultado = cmd.ExecuteReader();

            if (resultado.HasRows)
            {
                while (resultado.Read())
                {
                    Aluno a = new Aluno();
                    a.id = resultado.GetInt32(0);
                    a.nome = resultado.GetString(1);
                    a.login = resultado.GetString(2);
                    a.senha = resultado.GetString(3);
                    alunos.Add(a);
                }
            }
            cmd.Connection.Close();

            foreach (Aluno a in alunos)
            {
                if (chamada == a.id && senha == a.senha)
                {
                    MessageBox.Show("Deletado com sucesso.");
                    existe = true;
                }
            }
            
            if (existe == true)
            {
                cmd2.Parameters.AddWithValue("@id", NDELCADASTRO.Text);
                cmd2.Parameters.AddWithValue("@senha", SENHADELCADASTRO.Text);

                cmd2.Connection.Open();
                cmd2.ExecuteNonQuery();
                cmd2.Connection.Close();

                login login = new login();
                this.Visible = false;
                login.ShowDialog();
            }
            else
            {
                MessageBox.Show("Esse número da chamada não existe ou a senha está incorreta.");
                NDELCADASTRO.Clear();
                SENHADELCADASTRO.Clear();
            }
        }

        private void VOLTAR_Click(object sender, EventArgs e)
        {
            login login = new login();
            this.Visible = false;
            login.ShowDialog();
        }
    }
}
