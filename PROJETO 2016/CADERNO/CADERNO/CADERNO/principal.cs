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
    public partial class principal : Form
    {
        public principal()
        {
            InitializeComponent();
        }

        private void principal_Load(object sender, EventArgs e)
        {
           
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void ACESSAROUTRACONTA_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            login login = new login();
            login.ShowDialog();          
            
        }      

        private void SAIREFECHARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MATEMÁTICA_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            listBox1.Items.Clear();
            listBox1.Visible = true;
            MySqlCommand cmd = new MySqlCommand()
            {
                Connection = new MySqlConnection("Server=localhost;Database=caderno;Uid=root;Pwd="),
                CommandText = "SELECT NOME FROM materia_especifica WHERE ID_MATERIA = 1;"
            };

            cmd.Connection.Open();
            MySqlDataReader resultado;
            resultado = cmd.ExecuteReader();

            //enquanto leitor lê 
            while (resultado.Read())
            {
                //para cada iteração adiciono o nome ao listbox 
                listBox1.Items.Add(resultado["NOME"].ToString());
            }

            //fecha conexão 
            cmd.Connection.Close();
=======

>>>>>>> 2a1d2057e95ca68ea49dfc8a3c89ca946da29132
        }

        private void INGLÊS_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            listBox1.Items.Clear();
            listBox1.Visible = true;
            MySqlCommand cmd = new MySqlCommand()
            {
                Connection = new MySqlConnection("Server=localhost;Database=caderno;Uid=root;Pwd="),
                CommandText = "SELECT NOME FROM materia_especifica WHERE ID_MATERIA = 2;"
            };

            cmd.Connection.Open();
            MySqlDataReader resultado;
            resultado = cmd.ExecuteReader();

            //enquanto leitor lê 
            while (resultado.Read())
            {
                //para cada iteração adiciono o nome ao listbox 
                listBox1.Items.Add(resultado["NOME"].ToString());
            }

            //fecha conexão 
            cmd.Connection.Close();
=======
>>>>>>> 2a1d2057e95ca68ea49dfc8a3c89ca946da29132

        }

        private void PORTUGUÊS_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            listBox1.Items.Clear();
            listBox1.Visible = true;
            MySqlCommand cmd = new MySqlCommand()
            {
                Connection = new MySqlConnection("Server=localhost;Database=caderno;Uid=root;Pwd="),
                CommandText = "SELECT NOME FROM materia_especifica WHERE ID_MATERIA = 3;"
            };

            cmd.Connection.Open();
            MySqlDataReader resultado;
            resultado = cmd.ExecuteReader();

            //enquanto leitor lê 
            while (resultado.Read())
            {
                //para cada iteração adiciono o nome ao listbox 
                listBox1.Items.Add(resultado["NOME"].ToString());
            }

            //fecha conexão 
            cmd.Connection.Close();
=======

>>>>>>> 2a1d2057e95ca68ea49dfc8a3c89ca946da29132
        }

        private void FÍSICA_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            listBox1.Items.Clear();
            listBox1.Visible = true;
            MySqlCommand cmd = new MySqlCommand()
            {
                Connection = new MySqlConnection("Server=localhost;Database=caderno;Uid=root;Pwd="),
                CommandText = "SELECT NOME FROM materia_especifica WHERE ID_MATERIA = 4;"
            };

            cmd.Connection.Open();
            MySqlDataReader resultado;
            resultado = cmd.ExecuteReader();

            //enquanto leitor lê 
            while (resultado.Read())
            {
                //para cada iteração adiciono o nome ao listbox 
                listBox1.Items.Add(resultado["NOME"].ToString());
            }

            //fecha conexão 
            cmd.Connection.Close();
=======

>>>>>>> 2a1d2057e95ca68ea49dfc8a3c89ca946da29132
        }

        private void QUÍMICA_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            listBox1.Items.Clear();
            listBox1.Visible = true;
            MySqlCommand cmd = new MySqlCommand()
            {
                Connection = new MySqlConnection("Server=localhost;Database=caderno;Uid=root;Pwd="),
                CommandText = "SELECT NOME FROM materia_especifica WHERE ID_MATERIA = 5;"
            };

            cmd.Connection.Open();
            MySqlDataReader resultado;
            resultado = cmd.ExecuteReader();

            //enquanto leitor lê 
            while (resultado.Read())
            {
                //para cada iteração adiciono o nome ao listbox 
                listBox1.Items.Add(resultado["NOME"].ToString());
            }

            //fecha conexão 
            cmd.Connection.Close();
=======

>>>>>>> 2a1d2057e95ca68ea49dfc8a3c89ca946da29132
        }

        private void SOCIOLOGIA_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            listBox1.Items.Clear();
            listBox1.Visible = true;
            MySqlCommand cmd = new MySqlCommand()
            {
                Connection = new MySqlConnection("Server=localhost;Database=caderno;Uid=root;Pwd="),
                CommandText = "SELECT NOME FROM materia_especifica WHERE ID_MATERIA = 6;"
            };

            cmd.Connection.Open();
            MySqlDataReader resultado;
            resultado = cmd.ExecuteReader();

            //enquanto leitor lê 
            while (resultado.Read())
            {
                //para cada iteração adiciono o nome ao listbox 
                listBox1.Items.Add(resultado["NOME"].ToString());
            }

            //fecha conexão 
            cmd.Connection.Close();
=======

>>>>>>> 2a1d2057e95ca68ea49dfc8a3c89ca946da29132
        }

        private void FILOSOFIA_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            listBox1.Items.Clear();
            listBox1.Visible = true;
            MySqlCommand cmd = new MySqlCommand()
            {
                Connection = new MySqlConnection("Server=localhost;Database=caderno;Uid=root;Pwd="),
                CommandText = "SELECT NOME FROM materia_especifica WHERE ID_MATERIA = 7;"
            };

            cmd.Connection.Open();
            MySqlDataReader resultado;
            resultado = cmd.ExecuteReader();

            //enquanto leitor lê 
            while (resultado.Read())
            {
                //para cada iteração adiciono o nome ao listbox 
                listBox1.Items.Add(resultado["NOME"].ToString());
            }

            //fecha conexão 
            cmd.Connection.Close();
=======

>>>>>>> 2a1d2057e95ca68ea49dfc8a3c89ca946da29132
        }

        private void BIOLOGIA_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            listBox1.Items.Clear();
            listBox1.Visible = true;
            MySqlCommand cmd = new MySqlCommand()
            {
                Connection = new MySqlConnection("Server=localhost;Database=caderno;Uid=root;Pwd="),
                CommandText = "SELECT NOME FROM materia_especifica WHERE ID_MATERIA = 8;"
            };

            cmd.Connection.Open();
            MySqlDataReader resultado;
            resultado = cmd.ExecuteReader();

            //enquanto leitor lê 
            while (resultado.Read())
            {
                //para cada iteração adiciono o nome ao listbox 
                listBox1.Items.Add(resultado["NOME"].ToString());
            }

            //fecha conexão 
            cmd.Connection.Close();
=======

>>>>>>> 2a1d2057e95ca68ea49dfc8a3c89ca946da29132
        }

        private void ED_FÍSICA_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            listBox1.Items.Clear();
            listBox1.Visible = true;
            MySqlCommand cmd = new MySqlCommand()
            {
                Connection = new MySqlConnection("Server=localhost;Database=caderno;Uid=root;Pwd="),
                CommandText = "SELECT NOME FROM materia_especifica WHERE ID_MATERIA = 9;"
            };

            cmd.Connection.Open();
            MySqlDataReader resultado;
            resultado = cmd.ExecuteReader();

            //enquanto leitor lê 
            while (resultado.Read())
            {
                //para cada iteração adiciono o nome ao listbox 
                listBox1.Items.Add(resultado["NOME"].ToString());
            }

            //fecha conexão 
            cmd.Connection.Close();
=======

>>>>>>> 2a1d2057e95ca68ea49dfc8a3c89ca946da29132
        }

        private void HISTÓRIA_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            listBox1.Items.Clear();
            listBox1.Visible = true;
            MySqlCommand cmd = new MySqlCommand()
            {
                Connection = new MySqlConnection("Server=localhost;Database=caderno;Uid=root;Pwd="),
                CommandText = "SELECT NOME FROM materia_especifica WHERE ID_MATERIA = 10;"
            };

            cmd.Connection.Open();
            MySqlDataReader resultado;
            resultado = cmd.ExecuteReader();

            //enquanto leitor lê 
            while (resultado.Read())
            {
                //para cada iteração adiciono o nome ao listbox 
                listBox1.Items.Add(resultado["NOME"].ToString());
            }

            //fecha conexão 
            cmd.Connection.Close();
=======

>>>>>>> 2a1d2057e95ca68ea49dfc8a3c89ca946da29132
        }

        private void GEOGRAFIA_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            listBox1.Items.Clear();
            listBox1.Visible = true;
            MySqlCommand cmd = new MySqlCommand()
            {
                Connection = new MySqlConnection("Server=localhost;Database=caderno;Uid=root;Pwd="),
                CommandText = "SELECT NOME FROM materia_especifica WHERE ID_MATERIA = 11;"
            };

            cmd.Connection.Open();
            MySqlDataReader resultado;
            resultado = cmd.ExecuteReader();

            //enquanto leitor lê 
            while (resultado.Read())
            {
                //para cada iteração adiciono o nome ao listbox 
                listBox1.Items.Add(resultado["NOME"].ToString());
            }

            //fecha conexão 
            cmd.Connection.Close();
        }

        private void DESENHO_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Visible = true;
            MySqlCommand cmd = new MySqlCommand()
            {
                Connection = new MySqlConnection("Server=localhost;Database=caderno;Uid=root;Pwd="),
                CommandText = "SELECT NOME FROM materia_especifica WHERE ID_MATERIA = 12;"
            };

            cmd.Connection.Open();
            MySqlDataReader resultado;
            resultado = cmd.ExecuteReader();

            //enquanto leitor lê 
            while (resultado.Read())
            {
                //para cada iteração adiciono o nome ao listbox 
                listBox1.Items.Add(resultado["NOME"].ToString());
            }

            //fecha conexão 
            cmd.Connection.Close();
        }

        private void principal_Click(object sender, EventArgs e)
        {
        }

        private void listBox1_Click(object sender, EventArgs e)
        {

        }

        private void principal_DoubleClick(object sender, EventArgs e)
        {
        }

        private void BUSCAR_Click(object sender, EventArgs e)
        {
            resultadotxt.Clear();
            MySqlCommand cmd = new MySqlCommand()
            {
                Connection = new MySqlConnection("Server=localhost;Database=caderno;Uid=root;Pwd="),
                CommandText = "SELECT CONTEUDO FROM materia_especifica WHERE NOME = @nome;"
            };

            cmd.Connection.Open();
            MySqlDataReader resultado;
            cmd.Parameters.AddWithValue("@nome", BUSCATXT.Text);

            resultado = cmd.ExecuteReader();

            if(resultado.Read())
            {
                resultadotxt.Text = resultado.GetValue(0).ToString();
            }
            else
            {
                BUSCATXT.Clear();
            }            

            cmd.Connection.Close();

        }

        private void ANO1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Visible = true;
            MySqlCommand cmd = new MySqlCommand()
            {
                Connection = new MySqlConnection("Server=localhost;Database=caderno;Uid=root;Pwd="),
                CommandText = "SELECT NOME FROM materia_especifica WHERE ID_ANO = 1 ORDER BY NOME ASC;"
            };

            cmd.Connection.Open();
            MySqlDataReader resultado;
            resultado = cmd.ExecuteReader();

            //enquanto leitor lê 
            while (resultado.Read())
            {
                //para cada iteração adiciono o nome ao listbox 
                listBox1.Items.Add(resultado["NOME"].ToString());
            }

            //fecha conexão 
            cmd.Connection.Close();
        }

        private void ANO2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Visible = true;
            MySqlCommand cmd = new MySqlCommand()
            {
                Connection = new MySqlConnection("Server=localhost;Database=caderno;Uid=root;Pwd="),
                CommandText = "SELECT NOME FROM materia_especifica WHERE ID_ANO = 2 ORDER BY NOME ASC;"
            };

            cmd.Connection.Open();
            MySqlDataReader resultado;
            resultado = cmd.ExecuteReader();

            //enquanto leitor lê 
            while (resultado.Read())
            {
                //para cada iteração adiciono o nome ao listbox 
                listBox1.Items.Add(resultado["NOME"].ToString());
            }

            //fecha conexão 
            cmd.Connection.Close();
        }

        private void ANO3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Visible = true;
            MySqlCommand cmd = new MySqlCommand()
            {
                Connection = new MySqlConnection("Server=localhost;Database=caderno;Uid=root;Pwd="),
                CommandText = "SELECT NOME FROM materia_especifica WHERE ID_ANO = 3 ORDER BY NOME ASC;"
            };

            cmd.Connection.Open();
            MySqlDataReader resultado;
            resultado = cmd.ExecuteReader();

            //enquanto leitor lê 
            while (resultado.Read())
            {
                //para cada iteração adiciono o nome ao listbox 
                listBox1.Items.Add(resultado["NOME"].ToString());
            }

            //fecha conexão 
            cmd.Connection.Close();
        }
=======

        }

        private void DESENHO_Click(object sender, EventArgs e)
        {

        }
                  
>>>>>>> 2a1d2057e95ca68ea49dfc8a3c89ca946da29132
    }
}
