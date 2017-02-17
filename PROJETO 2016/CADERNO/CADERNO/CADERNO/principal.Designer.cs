using System.Windows.Forms;

namespace CADERNO
{
    partial class principal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(principal));
            this.menuPrincipal = new System.Windows.Forms.MenuStrip();
            this.MATEMÁTICA = new System.Windows.Forms.ToolStripMenuItem();
            this.INGLÊS = new System.Windows.Forms.ToolStripMenuItem();
            this.PORTUGUÊS = new System.Windows.Forms.ToolStripMenuItem();
            this.FÍSICA = new System.Windows.Forms.ToolStripMenuItem();
            this.QUÍMICA = new System.Windows.Forms.ToolStripMenuItem();
            this.SOCIOLOGIA = new System.Windows.Forms.ToolStripMenuItem();
            this.FILOSOFIA = new System.Windows.Forms.ToolStripMenuItem();
            this.BIOLOGIA = new System.Windows.Forms.ToolStripMenuItem();
            this.ED_FÍSICA = new System.Windows.Forms.ToolStripMenuItem();
            this.HISTÓRIA = new System.Windows.Forms.ToolStripMenuItem();
            this.GEOGRAFIA = new System.Windows.Forms.ToolStripMenuItem();
            this.DESENHO = new System.Windows.Forms.ToolStripMenuItem();
            this.ACESSAROUTRACONTA = new System.Windows.Forms.ToolStripMenuItem();
            this.SAIREFECHAR = new System.Windows.Forms.ToolStripMenuItem();
            this.BottomToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.TopToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.RightToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.LeftToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.ContentPanel = new System.Windows.Forms.ToolStripContentPanel();
            this.b1 = new System.Windows.Forms.Button();
            this.menuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPrincipal
            // 
            this.menuPrincipal.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.menuPrincipal.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuPrincipal.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuPrincipal.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MATEMÁTICA,
            this.INGLÊS,
            this.PORTUGUÊS,
            this.FÍSICA,
            this.QUÍMICA,
            this.SOCIOLOGIA,
            this.FILOSOFIA,
            this.BIOLOGIA,
            this.ED_FÍSICA,
            this.HISTÓRIA,
            this.GEOGRAFIA,
            this.DESENHO,
            this.ACESSAROUTRACONTA,
            this.SAIREFECHAR});
            this.menuPrincipal.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.menuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuPrincipal.Margin = new System.Windows.Forms.Padding(3);
            this.menuPrincipal.Name = "menuPrincipal";
            this.menuPrincipal.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuPrincipal.Size = new System.Drawing.Size(235, 882);
            this.menuPrincipal.Stretch = false;
            this.menuPrincipal.TabIndex = 0;
            this.menuPrincipal.Text = "menuPrincipal";
            this.menuPrincipal.AutoSizeChanged += new System.EventHandler(this.principal_Load);
            this.menuPrincipal.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            this.menuPrincipal.LayoutCompleted += new System.EventHandler(this.principal_Load);
            // 
            // MATEMÁTICA
            // 
            this.MATEMÁTICA.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.MATEMÁTICA.Checked = true;
            this.MATEMÁTICA.CheckState = System.Windows.Forms.CheckState.Checked;
            this.MATEMÁTICA.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MATEMÁTICA.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.MATEMÁTICA.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MATEMÁTICA.Margin = new System.Windows.Forms.Padding(5);
            this.MATEMÁTICA.Name = "MATEMÁTICA";
            this.MATEMÁTICA.Size = new System.Drawing.Size(208, 25);
            this.MATEMÁTICA.Text = "MATEMÁTICA";
            this.MATEMÁTICA.Click += new System.EventHandler(this.MATEMÁTICA_Click);
            // 
            // INGLÊS
            // 
            this.INGLÊS.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.INGLÊS.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.INGLÊS.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.INGLÊS.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.INGLÊS.Margin = new System.Windows.Forms.Padding(5);
            this.INGLÊS.Name = "INGLÊS";
            this.INGLÊS.Size = new System.Drawing.Size(208, 25);
            this.INGLÊS.Text = "INGLÊS";
            this.INGLÊS.Click += new System.EventHandler(this.INGLÊS_Click);
            // 
            // PORTUGUÊS
            // 
            this.PORTUGUÊS.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.PORTUGUÊS.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PORTUGUÊS.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.PORTUGUÊS.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.PORTUGUÊS.Margin = new System.Windows.Forms.Padding(5);
            this.PORTUGUÊS.Name = "PORTUGUÊS";
            this.PORTUGUÊS.Size = new System.Drawing.Size(208, 25);
            this.PORTUGUÊS.Text = "PORTUGUÊS";
            this.PORTUGUÊS.Click += new System.EventHandler(this.PORTUGUÊS_Click);
            // 
            // FÍSICA
            // 
            this.FÍSICA.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.FÍSICA.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FÍSICA.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.FÍSICA.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.FÍSICA.Margin = new System.Windows.Forms.Padding(5);
            this.FÍSICA.Name = "FÍSICA";
            this.FÍSICA.Size = new System.Drawing.Size(208, 25);
            this.FÍSICA.Text = "FÍSICA";
            this.FÍSICA.Click += new System.EventHandler(this.FÍSICA_Click);
            // 
            // QUÍMICA
            // 
            this.QUÍMICA.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.QUÍMICA.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QUÍMICA.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.QUÍMICA.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.QUÍMICA.Margin = new System.Windows.Forms.Padding(5);
            this.QUÍMICA.Name = "QUÍMICA";
            this.QUÍMICA.Size = new System.Drawing.Size(208, 25);
            this.QUÍMICA.Text = "QUÍMICA";
            this.QUÍMICA.Click += new System.EventHandler(this.QUÍMICA_Click);
            // 
            // SOCIOLOGIA
            // 
            this.SOCIOLOGIA.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.SOCIOLOGIA.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SOCIOLOGIA.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.SOCIOLOGIA.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.SOCIOLOGIA.Margin = new System.Windows.Forms.Padding(5);
            this.SOCIOLOGIA.Name = "SOCIOLOGIA";
            this.SOCIOLOGIA.Size = new System.Drawing.Size(208, 25);
            this.SOCIOLOGIA.Text = "SOCIOLOGIA";
            this.SOCIOLOGIA.Click += new System.EventHandler(this.SOCIOLOGIA_Click);
            // 
            // FILOSOFIA
            // 
            this.FILOSOFIA.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.FILOSOFIA.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FILOSOFIA.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.FILOSOFIA.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.FILOSOFIA.Margin = new System.Windows.Forms.Padding(5);
            this.FILOSOFIA.Name = "FILOSOFIA";
            this.FILOSOFIA.Size = new System.Drawing.Size(208, 25);
            this.FILOSOFIA.Text = "FILOSOFIA";
            this.FILOSOFIA.Click += new System.EventHandler(this.FILOSOFIA_Click);
            // 
            // BIOLOGIA
            // 
            this.BIOLOGIA.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BIOLOGIA.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BIOLOGIA.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BIOLOGIA.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BIOLOGIA.Margin = new System.Windows.Forms.Padding(5);
            this.BIOLOGIA.Name = "BIOLOGIA";
            this.BIOLOGIA.Size = new System.Drawing.Size(208, 25);
            this.BIOLOGIA.Text = "BIOLOGIA";
            this.BIOLOGIA.Click += new System.EventHandler(this.BIOLOGIA_Click);
            // 
            // ED_FÍSICA
            // 
            this.ED_FÍSICA.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ED_FÍSICA.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ED_FÍSICA.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ED_FÍSICA.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ED_FÍSICA.Margin = new System.Windows.Forms.Padding(5);
            this.ED_FÍSICA.Name = "ED_FÍSICA";
            this.ED_FÍSICA.Size = new System.Drawing.Size(208, 25);
            this.ED_FÍSICA.Text = "ED FÍSICA";
            this.ED_FÍSICA.Click += new System.EventHandler(this.ED_FÍSICA_Click);
            // 
            // HISTÓRIA
            // 
            this.HISTÓRIA.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.HISTÓRIA.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HISTÓRIA.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.HISTÓRIA.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.HISTÓRIA.Margin = new System.Windows.Forms.Padding(5);
            this.HISTÓRIA.Name = "HISTÓRIA";
            this.HISTÓRIA.Size = new System.Drawing.Size(208, 25);
            this.HISTÓRIA.Text = "HISTÓRIA";
            this.HISTÓRIA.Click += new System.EventHandler(this.HISTÓRIA_Click);
            // 
            // GEOGRAFIA
            // 
            this.GEOGRAFIA.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.GEOGRAFIA.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GEOGRAFIA.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.GEOGRAFIA.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.GEOGRAFIA.Margin = new System.Windows.Forms.Padding(5);
            this.GEOGRAFIA.Name = "GEOGRAFIA";
            this.GEOGRAFIA.Size = new System.Drawing.Size(208, 25);
            this.GEOGRAFIA.Text = "GEOGRAFIA";
            this.GEOGRAFIA.Click += new System.EventHandler(this.GEOGRAFIA_Click);
            // 
            // DESENHO
            // 
            this.DESENHO.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.DESENHO.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DESENHO.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.DESENHO.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.DESENHO.Margin = new System.Windows.Forms.Padding(5);
            this.DESENHO.Name = "DESENHO";
            this.DESENHO.Size = new System.Drawing.Size(208, 25);
            this.DESENHO.Text = "DESENHO";
            this.DESENHO.Click += new System.EventHandler(this.DESENHO_Click);
            // 
            // ACESSAROUTRACONTA
            // 
            this.ACESSAROUTRACONTA.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ACESSAROUTRACONTA.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ACESSAROUTRACONTA.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ACESSAROUTRACONTA.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ACESSAROUTRACONTA.Margin = new System.Windows.Forms.Padding(5);
            this.ACESSAROUTRACONTA.Name = "ACESSAROUTRACONTA";
            this.ACESSAROUTRACONTA.Size = new System.Drawing.Size(208, 25);
            this.ACESSAROUTRACONTA.Text = "ACESSAR OUTRA CONTA";
            this.ACESSAROUTRACONTA.Click += new System.EventHandler(this.ACESSAROUTRACONTA_Click);
            // 
            // SAIREFECHAR
            // 
            this.SAIREFECHAR.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.SAIREFECHAR.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SAIREFECHAR.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.SAIREFECHAR.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.SAIREFECHAR.Margin = new System.Windows.Forms.Padding(5);
            this.SAIREFECHAR.Name = "SAIREFECHAR";
            this.SAIREFECHAR.Size = new System.Drawing.Size(208, 25);
            this.SAIREFECHAR.Text = "SAIR E FECHAR";
            this.SAIREFECHAR.Click += new System.EventHandler(this.SAIREFECHARToolStripMenuItem_Click);
            // 
            // BottomToolStripPanel
            // 
            this.BottomToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.BottomToolStripPanel.Name = "BottomToolStripPanel";
            this.BottomToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.BottomToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.BottomToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // TopToolStripPanel
            // 
            this.TopToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.TopToolStripPanel.Name = "TopToolStripPanel";
            this.TopToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.TopToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.TopToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // RightToolStripPanel
            // 
            this.RightToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.RightToolStripPanel.Name = "RightToolStripPanel";
            this.RightToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.RightToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.RightToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // LeftToolStripPanel
            // 
            this.LeftToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftToolStripPanel.Name = "LeftToolStripPanel";
            this.LeftToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.LeftToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.LeftToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // ContentPanel
            // 
            this.ContentPanel.Size = new System.Drawing.Size(628, 18);
            // 
            // b1
            // 
            this.b1.Location = new System.Drawing.Point(0, 0);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(75, 23);
            this.b1.TabIndex = 0;
            // 
            // principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1604, 882);
            this.Controls.Add(this.menuPrincipal);
            this.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "principal";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "MENU PRINCIPAL";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.principal_Load);
            this.menuPrincipal.ResumeLayout(false);
            this.menuPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripPanel BottomToolStripPanel;
        private System.Windows.Forms.ToolStripPanel TopToolStripPanel;
        private System.Windows.Forms.ToolStripPanel RightToolStripPanel;
        private System.Windows.Forms.ToolStripPanel LeftToolStripPanel;
        private System.Windows.Forms.ToolStripContentPanel ContentPanel;
        private System.Windows.Forms.Button b1;
        public MenuStrip menuPrincipal;
        public ToolStripMenuItem MATEMÁTICA;
        public ToolStripMenuItem INGLÊS;
        public ToolStripMenuItem PORTUGUÊS;
        public ToolStripMenuItem FÍSICA;
        public ToolStripMenuItem QUÍMICA;
        public ToolStripMenuItem SOCIOLOGIA;
        public ToolStripMenuItem FILOSOFIA;
        public ToolStripMenuItem BIOLOGIA;
        public ToolStripMenuItem ED_FÍSICA;
        public ToolStripMenuItem HISTÓRIA;
        public ToolStripMenuItem GEOGRAFIA;
        public ToolStripMenuItem DESENHO;
        public ToolStripMenuItem ACESSAROUTRACONTA;
        public ToolStripMenuItem SAIREFECHAR;
    }
}