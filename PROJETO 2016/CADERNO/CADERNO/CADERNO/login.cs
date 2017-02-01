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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ENTER_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM aluno WHERE LOGIN = @nome AND SENHA = @senha";
            Conexao conexao = new Conexao();
            conexao.conectar();

            MySqlCommand cmd = new MySqlCommand(query, conexao.conn);

            cmd.Parameters.AddWithValue("@nome", txtaluno.Text);
            cmd.Parameters.AddWithValue("@senha", txtsenha.Text);

            MySqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                Autenticacao.login(dr["LOGIN"].ToString(), dr["SENHA"].ToString());
                principal principal = new principal();
                this.Visible = false;               
                principal.ShowDialog();
            }
            else
            {
                MessageBox.Show("Usuário e/ou senha incorretos");
                txtaluno.Clear();
                txtsenha.Clear();
            }

        }
    }
}
