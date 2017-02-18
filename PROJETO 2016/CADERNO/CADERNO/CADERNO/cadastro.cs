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
    public partial class cadastro : Form
    {
        public cadastro()
        {
            InitializeComponent();
        }

        private void CADASTRARALUNO_Click(object sender, EventArgs e)
        {
            int chamada = 10;
            bool existe = false;

    
            chamada = Convert.ToInt32(NCHAMADACADASTRO.Text);
            List<Aluno> alunos = new List<Aluno>();

            MySqlCommand cmd = new MySqlCommand()
            {
                Connection = new MySqlConnection("Server=localhost;Database=caderno;Uid=root;Pwd="),
                CommandText = "SELECT * FROM aluno;"
            };

            MySqlCommand cmd2 = new MySqlCommand()
            {
                Connection = new MySqlConnection("Server=localhost;Database=caderno;Uid=root;Pwd="),
                CommandText = "INSERT INTO aluno (ID, NOMECOMPLETO, LOGIN, SENHA) VALUES (@id, @nome, @login, @senha);"
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
                if (a.id == chamada)
                {
                    if (chamada == 0)
                    {
                        MessageBox.Show("Não é possível fazer um cadastro vazio.");
                        existe = true;
                        NCHAMADACADASTRO.Clear();
                        LOGINCADASTRO.Clear();
                        SENHACADASTRO.Clear();
                        NOMECADASTRO.Clear();
                        break;
                    }
                    else
                    {
                        MessageBox.Show("Esse número da chamada já existe.");
                        existe = true;
                        NCHAMADACADASTRO.Clear();
                        break;
                    }                    
                }
            }

            if (existe == false)
            {
                cmd2.Parameters.AddWithValue("@nome", NOMECADASTRO.Text);
                cmd2.Parameters.AddWithValue("@login", LOGINCADASTRO.Text);
                cmd2.Parameters.AddWithValue("@senha", SENHACADASTRO.Text);
                cmd2.Parameters.AddWithValue("@id", NCHAMADACADASTRO.Text);

                cmd2.Connection.Open();
                cmd2.ExecuteNonQuery();
                cmd2.Connection.Close();

                MessageBox.Show("Cadastrado com sucesso.");
                login login = new login();
                this.Visible = false;
                login.ShowDialog();
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
