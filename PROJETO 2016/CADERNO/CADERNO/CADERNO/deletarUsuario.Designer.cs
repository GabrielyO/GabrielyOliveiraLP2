namespace CADERNO
{
    partial class deletarUsuario
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
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NDELCADASTRO = new System.Windows.Forms.TextBox();
            this.SENHADELCADASTRO = new System.Windows.Forms.TextBox();
            this.DELETAR = new System.Windows.Forms.Button();
            this.panelDELETAR = new System.Windows.Forms.Panel();
            this.VOLTAR = new System.Windows.Forms.Button();
            this.panelDELETAR.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("BatangChe", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(14, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 32);
            this.label1.TabIndex = 14;
            this.label1.Text = "NÚMERO NA CHAMADA";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("BatangChe", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(31, 37);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(287, 32);
            this.label4.TabIndex = 16;
            this.label4.Text = "SENHA DO USUÁRIO";
            // 
            // NDELCADASTRO
            // 
            this.NDELCADASTRO.AccessibleName = "NCHAMADA";
            this.NDELCADASTRO.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.NDELCADASTRO.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NDELCADASTRO.Location = new System.Drawing.Point(325, 0);
            this.NDELCADASTRO.Name = "NDELCADASTRO";
            this.NDELCADASTRO.Size = new System.Drawing.Size(131, 31);
            this.NDELCADASTRO.TabIndex = 17;
            // 
            // SENHADELCADASTRO
            // 
            this.SENHADELCADASTRO.AccessibleName = "SENHATXT";
            this.SENHADELCADASTRO.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SENHADELCADASTRO.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SENHADELCADASTRO.Location = new System.Drawing.Point(325, 37);
            this.SENHADELCADASTRO.Name = "SENHADELCADASTRO";
            this.SENHADELCADASTRO.PasswordChar = '*';
            this.SENHADELCADASTRO.Size = new System.Drawing.Size(224, 31);
            this.SENHADELCADASTRO.TabIndex = 18;
            // 
            // DELETAR
            // 
            this.DELETAR.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DELETAR.BackColor = System.Drawing.Color.White;
            this.DELETAR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DELETAR.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.DELETAR.FlatAppearance.BorderSize = 10;
            this.DELETAR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.DELETAR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.DELETAR.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DELETAR.Font = new System.Drawing.Font("Bernard MT Condensed", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DELETAR.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.DELETAR.Location = new System.Drawing.Point(241, 103);
            this.DELETAR.Margin = new System.Windows.Forms.Padding(4);
            this.DELETAR.Name = "DELETAR";
            this.DELETAR.Size = new System.Drawing.Size(183, 51);
            this.DELETAR.TabIndex = 19;
            this.DELETAR.Text = "DELETAR USUÁRIO";
            this.DELETAR.UseVisualStyleBackColor = false;
            this.DELETAR.Click += new System.EventHandler(this.DELETAR_Click);
            // 
            // panelDELETAR
            // 
            this.panelDELETAR.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDELETAR.AutoScroll = true;
            this.panelDELETAR.AutoSize = true;
            this.panelDELETAR.Controls.Add(this.VOLTAR);
            this.panelDELETAR.Controls.Add(this.DELETAR);
            this.panelDELETAR.Controls.Add(this.SENHADELCADASTRO);
            this.panelDELETAR.Controls.Add(this.NDELCADASTRO);
            this.panelDELETAR.Controls.Add(this.label4);
            this.panelDELETAR.Controls.Add(this.label1);
            this.panelDELETAR.Location = new System.Drawing.Point(200, 200);
            this.panelDELETAR.Name = "panelDELETAR";
            this.panelDELETAR.Size = new System.Drawing.Size(653, 261);
            this.panelDELETAR.TabIndex = 20;
            // 
            // VOLTAR
            // 
            this.VOLTAR.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.VOLTAR.BackColor = System.Drawing.Color.White;
            this.VOLTAR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.VOLTAR.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.VOLTAR.FlatAppearance.BorderSize = 10;
            this.VOLTAR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.VOLTAR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.VOLTAR.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.VOLTAR.Font = new System.Drawing.Font("Bernard MT Condensed", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VOLTAR.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.VOLTAR.Location = new System.Drawing.Point(432, 103);
            this.VOLTAR.Margin = new System.Windows.Forms.Padding(4);
            this.VOLTAR.Name = "VOLTAR";
            this.VOLTAR.Size = new System.Drawing.Size(117, 51);
            this.VOLTAR.TabIndex = 20;
            this.VOLTAR.Text = "VOLTAR";
            this.VOLTAR.UseVisualStyleBackColor = false;
            this.VOLTAR.Click += new System.EventHandler(this.VOLTAR_Click);
            // 
            // deletarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(936, 396);
            this.ControlBox = false;
            this.Controls.Add(this.panelDELETAR);
            this.Name = "deletarUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "deletarUsuario";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelDELETAR.ResumeLayout(false);
            this.panelDELETAR.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox NDELCADASTRO;
        private System.Windows.Forms.TextBox SENHADELCADASTRO;
        private System.Windows.Forms.Button DELETAR;
        private System.Windows.Forms.Panel panelDELETAR;
        private System.Windows.Forms.Button VOLTAR;
    }
}