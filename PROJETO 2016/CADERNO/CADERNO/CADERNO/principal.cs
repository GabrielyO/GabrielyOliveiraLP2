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
            panelmat.Visible = true;
            paneling.Visible = false;
            panelpor.Visible = false;
            panelfis.Visible = false;
            panelqui.Visible = false;
            panelsoc.Visible = false;
            panelfil.Visible = false;
            panelbio.Visible = false;
            paneledf.Visible = false;
            panelhis.Visible = false;
            panelgeo.Visible = false;
            paneldes.Visible = false;
        }

        private void INGLÊS_Click(object sender, EventArgs e)
        {
            panelmat.Visible = false;
            paneling.Visible = true;
            panelpor.Visible = false;
            panelfis.Visible = false;
            panelqui.Visible = false;
            panelsoc.Visible = false;
            panelfil.Visible = false;
            panelbio.Visible = false;
            paneledf.Visible = false;
            panelhis.Visible = false;
            panelgeo.Visible = false;
            paneldes.Visible = false;                        
        }

        private void PORTUGUÊS_Click(object sender, EventArgs e)
        {
            panelmat.Visible = false;
            paneling.Visible = false;
            panelpor.Visible = true;
            panelfis.Visible = false;
            panelqui.Visible = false;
            panelsoc.Visible = false;
            panelfil.Visible = false;
            panelbio.Visible = false;
            paneledf.Visible = false;
            panelhis.Visible = false;
            panelgeo.Visible = false;
            paneldes.Visible = false;
        }

        private void FÍSICA_Click(object sender, EventArgs e)
        {
            panelmat.Visible = false;
            paneling.Visible = false;
            panelpor.Visible = false;
            panelfis.Visible = true;
            panelqui.Visible = false;
            panelsoc.Visible = false;
            panelfil.Visible = false;
            panelbio.Visible = false;
            paneledf.Visible = false;
            panelhis.Visible = false;
            panelgeo.Visible = false;
            paneldes.Visible = false;
        }

        private void QUÍMICA_Click(object sender, EventArgs e)
        {
            panelmat.Visible = false;
            paneling.Visible = false;
            panelpor.Visible = false;
            panelfis.Visible = false;
            panelqui.Visible = true;
            panelsoc.Visible = false;
            panelfil.Visible = false;
            panelbio.Visible = false;
            paneledf.Visible = false;
            panelhis.Visible = false;
            panelgeo.Visible = false;
            paneldes.Visible = false;
        }

        private void SOCIOLOGIA_Click(object sender, EventArgs e)
        {
            panelmat.Visible = false;
            paneling.Visible = false;
            panelpor.Visible = false;
            panelfis.Visible = false;
            panelqui.Visible = false;
            panelsoc.Visible = true;
            panelfil.Visible = false;
            panelbio.Visible = false;
            paneledf.Visible = false;
            panelhis.Visible = false;
            panelgeo.Visible = false;
            paneldes.Visible = false;
        }

        private void FILOSOFIA_Click(object sender, EventArgs e)
        {
            panelmat.Visible = false;
            paneling.Visible = false;
            panelpor.Visible = false;
            panelfis.Visible = false;
            panelqui.Visible = false;
            panelsoc.Visible = false;
            panelfil.Visible = true;
            panelbio.Visible = false;
            paneledf.Visible = false;
            panelhis.Visible = false;
            panelgeo.Visible = false;
            paneldes.Visible = false;
        }

        private void BIOLOGIA_Click(object sender, EventArgs e)
        {
            panelmat.Visible = false;
            paneling.Visible = false;
            panelpor.Visible = false;
            panelfis.Visible = false;
            panelqui.Visible = false;
            panelsoc.Visible = false;
            panelfil.Visible = false;
            panelbio.Visible = true;
            paneledf.Visible = false;
            panelhis.Visible = false;
            panelgeo.Visible = false;
            paneldes.Visible = false;
        }

        private void ED_FÍSICA_Click(object sender, EventArgs e)
        {
            panelmat.Visible = false;
            paneling.Visible = false;
            panelpor.Visible = false;
            panelfis.Visible = false;
            panelqui.Visible = false;
            panelsoc.Visible = false;
            panelfil.Visible = false;
            panelbio.Visible = false;
            paneledf.Visible = true;
            panelhis.Visible = false;
            panelgeo.Visible = false;
            paneldes.Visible = false;
        }

        private void HISTÓRIA_Click(object sender, EventArgs e)
        {
            panelmat.Visible = false;
            paneling.Visible = false;
            panelpor.Visible = false;
            panelfis.Visible = false;
            panelqui.Visible = false;
            panelsoc.Visible = false;
            panelfil.Visible = false;
            panelbio.Visible = false;
            paneledf.Visible = false;
            panelhis.Visible = true;
            panelgeo.Visible = false;
            paneldes.Visible = false;
        }

        private void GEOGRAFIA_Click(object sender, EventArgs e)
        {
            panelmat.Visible = false;
            paneling.Visible = false;
            panelpor.Visible = false;
            panelfis.Visible = false;
            panelqui.Visible = false;
            panelsoc.Visible = false;
            panelfil.Visible = false;
            panelbio.Visible = false;
            paneledf.Visible = false;
            panelhis.Visible = false;
            panelgeo.Visible = true;
            paneldes.Visible = false;
        }

        private void DESENHO_Click(object sender, EventArgs e)
        {
            panelmat.Visible = false;
            paneling.Visible = false;
            panelpor.Visible = false;
            panelfis.Visible = false;
            panelqui.Visible = false;
            panelsoc.Visible = false;
            panelfil.Visible = false;
            panelbio.Visible = false;
            paneledf.Visible = false;
            panelhis.Visible = false;
            panelgeo.Visible = false;
            paneldes.Visible = true;
        }

        private void mat1_Click(object sender, EventArgs e)
        {

        }
    }
}
