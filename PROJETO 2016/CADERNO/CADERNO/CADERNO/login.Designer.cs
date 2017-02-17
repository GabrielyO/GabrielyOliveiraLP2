namespace CADERNO
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.txtaluno = new System.Windows.Forms.TextBox();
            this.txtsenha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ENTER = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.FECHARPROGRAMA = new System.Windows.Forms.Button();
            this.DELUSER = new System.Windows.Forms.Button();
            this.CADASTRAR = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtaluno
            // 
            this.txtaluno.AccessibleName = "login";
            this.txtaluno.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtaluno.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtaluno.Location = new System.Drawing.Point(321, 102);
            this.txtaluno.Margin = new System.Windows.Forms.Padding(4);
            this.txtaluno.Name = "txtaluno";
            this.txtaluno.Size = new System.Drawing.Size(228, 32);
            this.txtaluno.TabIndex = 0;
            this.txtaluno.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtsenha
            // 
            this.txtsenha.AccessibleName = "senha";
            this.txtsenha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtsenha.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsenha.Location = new System.Drawing.Point(321, 141);
            this.txtsenha.Margin = new System.Windows.Forms.Padding(4);
            this.txtsenha.Name = "txtsenha";
            this.txtsenha.PasswordChar = '*';
            this.txtsenha.Size = new System.Drawing.Size(228, 32);
            this.txtsenha.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Copperplate Gothic Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(199, 102);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 35);
            this.label2.TabIndex = 3;
            this.label2.Text = "USER";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Copperplate Gothic Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(94, 138);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(227, 35);
            this.label3.TabIndex = 4;
            this.label3.Text = "PASSWORD";
            // 
            // ENTER
            // 
            this.ENTER.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ENTER.BackColor = System.Drawing.Color.White;
            this.ENTER.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ENTER.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.ENTER.FlatAppearance.BorderSize = 10;
            this.ENTER.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ENTER.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ENTER.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ENTER.Font = new System.Drawing.Font("Bernard MT Condensed", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ENTER.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.ENTER.Location = new System.Drawing.Point(376, 181);
            this.ENTER.Margin = new System.Windows.Forms.Padding(4);
            this.ENTER.Name = "ENTER";
            this.ENTER.Size = new System.Drawing.Size(117, 51);
            this.ENTER.TabIndex = 5;
            this.ENTER.Text = "ENTRAR";
            this.ENTER.UseVisualStyleBackColor = false;
            this.ENTER.Click += new System.EventHandler(this.ENTER_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.FECHARPROGRAMA);
            this.panel1.Controls.Add(this.DELUSER);
            this.panel1.Controls.Add(this.CADASTRAR);
            this.panel1.Controls.Add(this.ENTER);
            this.panel1.Controls.Add(this.txtaluno);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtsenha);
            this.panel1.Controls.Add(this.label2);
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Location = new System.Drawing.Point(389, 232);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(654, 508);
            this.panel1.TabIndex = 6;
            // 
            // FECHARPROGRAMA
            // 
            this.FECHARPROGRAMA.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FECHARPROGRAMA.BackColor = System.Drawing.Color.White;
            this.FECHARPROGRAMA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FECHARPROGRAMA.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.FECHARPROGRAMA.FlatAppearance.BorderSize = 10;
            this.FECHARPROGRAMA.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.FECHARPROGRAMA.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.FECHARPROGRAMA.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.FECHARPROGRAMA.Font = new System.Drawing.Font("Bernard MT Condensed", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FECHARPROGRAMA.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.FECHARPROGRAMA.Location = new System.Drawing.Point(330, 358);
            this.FECHARPROGRAMA.Margin = new System.Windows.Forms.Padding(4);
            this.FECHARPROGRAMA.Name = "FECHARPROGRAMA";
            this.FECHARPROGRAMA.Size = new System.Drawing.Size(207, 51);
            this.FECHARPROGRAMA.TabIndex = 8;
            this.FECHARPROGRAMA.Text = "FECHAR PROGRAMA";
            this.FECHARPROGRAMA.UseVisualStyleBackColor = false;
            this.FECHARPROGRAMA.Click += new System.EventHandler(this.FECHARPROGRAMA_Click);
            // 
            // DELUSER
            // 
            this.DELUSER.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DELUSER.BackColor = System.Drawing.Color.White;
            this.DELUSER.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DELUSER.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.DELUSER.FlatAppearance.BorderSize = 10;
            this.DELUSER.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.DELUSER.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.DELUSER.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DELUSER.Font = new System.Drawing.Font("Bernard MT Condensed", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DELUSER.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.DELUSER.Location = new System.Drawing.Point(330, 299);
            this.DELUSER.Margin = new System.Windows.Forms.Padding(4);
            this.DELUSER.Name = "DELUSER";
            this.DELUSER.Size = new System.Drawing.Size(207, 51);
            this.DELUSER.TabIndex = 7;
            this.DELUSER.Text = "DELETAR USUÁRIO";
            this.DELUSER.UseVisualStyleBackColor = false;
            this.DELUSER.Click += new System.EventHandler(this.DELUSER_Click);
            // 
            // CADASTRAR
            // 
            this.CADASTRAR.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CADASTRAR.BackColor = System.Drawing.Color.White;
            this.CADASTRAR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CADASTRAR.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.CADASTRAR.FlatAppearance.BorderSize = 10;
            this.CADASTRAR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.CADASTRAR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.CADASTRAR.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CADASTRAR.Font = new System.Drawing.Font("Bernard MT Condensed", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CADASTRAR.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.CADASTRAR.Location = new System.Drawing.Point(330, 240);
            this.CADASTRAR.Margin = new System.Windows.Forms.Padding(4);
            this.CADASTRAR.Name = "CADASTRAR";
            this.CADASTRAR.Size = new System.Drawing.Size(207, 51);
            this.CADASTRAR.TabIndex = 6;
            this.CADASTRAR.Text = "CADASTRAR";
            this.CADASTRAR.UseVisualStyleBackColor = false;
            this.CADASTRAR.Click += new System.EventHandler(this.CADASTRAR_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 75F);
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Location = new System.Drawing.Point(280, 123);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(1173, 113);
            this.label4.TabIndex = 0;
            this.label4.Text = "CADERNO VIRTUAL";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1264, 882);
            this.ControlBox = false;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "login";
            this.Text = "TELA DE LOGIN";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtaluno;
        private System.Windows.Forms.TextBox txtsenha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ENTER;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button CADASTRAR;
        private System.Windows.Forms.Button DELUSER;
        private System.Windows.Forms.Button FECHARPROGRAMA;
    }
}

