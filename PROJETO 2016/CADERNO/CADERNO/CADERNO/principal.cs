using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        }

        private void INGLÊS_Click(object sender, EventArgs e)
        {

        }

        private void PORTUGUÊS_Click(object sender, EventArgs e)
        {

        }

        private void FÍSICA_Click(object sender, EventArgs e)
        {

        }

        private void QUÍMICA_Click(object sender, EventArgs e)
        {

        }

        private void SOCIOLOGIA_Click(object sender, EventArgs e)
        {

        }

        private void FILOSOFIA_Click(object sender, EventArgs e)
        {

        }

        private void BIOLOGIA_Click(object sender, EventArgs e)
        {

        }

        private void ED_FÍSICA_Click(object sender, EventArgs e)
        {

        }

        private void HISTÓRIA_Click(object sender, EventArgs e)
        {

        }

        private void GEOGRAFIA_Click(object sender, EventArgs e)
        {

        }

        private void DESENHO_Click(object sender, EventArgs e)
        {

        }
                  
    }
}
