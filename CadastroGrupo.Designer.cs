namespace ProjetoCadastro2020 {
    partial class CadastroGrupo {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.BGrupoSalvar = new System.Windows.Forms.Button();
            this.EnredoCadastroGrupo = new System.Windows.Forms.Label();
            this.TextGrupo = new System.Windows.Forms.TextBox();
            this.TituloCadastroGrupo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BGrupoSalvar
            // 
            this.BGrupoSalvar.BackColor = System.Drawing.Color.Silver;
            this.BGrupoSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BGrupoSalvar.Location = new System.Drawing.Point(119, 213);
            this.BGrupoSalvar.Name = "BGrupoSalvar";
            this.BGrupoSalvar.Size = new System.Drawing.Size(75, 23);
            this.BGrupoSalvar.TabIndex = 0;
            this.BGrupoSalvar.Text = "Salvar";
            this.BGrupoSalvar.UseVisualStyleBackColor = false;
            this.BGrupoSalvar.Click += new System.EventHandler(this.BGrupoSalvar_Click);
            // 
            // EnredoCadastroGrupo
            // 
            this.EnredoCadastroGrupo.AutoSize = true;
            this.EnredoCadastroGrupo.BackColor = System.Drawing.Color.Transparent;
            this.EnredoCadastroGrupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnredoCadastroGrupo.Location = new System.Drawing.Point(12, 107);
            this.EnredoCadastroGrupo.Name = "EnredoCadastroGrupo";
            this.EnredoCadastroGrupo.Size = new System.Drawing.Size(99, 13);
            this.EnredoCadastroGrupo.TabIndex = 1;
            this.EnredoCadastroGrupo.Text = "Nome do Grupo:";
            // 
            // TextGrupo
            // 
            this.TextGrupo.BackColor = System.Drawing.Color.LightBlue;
            this.TextGrupo.Location = new System.Drawing.Point(112, 104);
            this.TextGrupo.Name = "TextGrupo";
            this.TextGrupo.Size = new System.Drawing.Size(175, 20);
            this.TextGrupo.TabIndex = 4;
            this.TextGrupo.TextChanged += new System.EventHandler(this.TextGrupo_TextChanged);
            // 
            // TituloCadastroGrupo
            // 
            this.TituloCadastroGrupo.AutoSize = true;
            this.TituloCadastroGrupo.BackColor = System.Drawing.Color.Transparent;
            this.TituloCadastroGrupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TituloCadastroGrupo.ForeColor = System.Drawing.Color.Gold;
            this.TituloCadastroGrupo.Location = new System.Drawing.Point(21, 54);
            this.TituloCadastroGrupo.Name = "TituloCadastroGrupo";
            this.TituloCadastroGrupo.Size = new System.Drawing.Size(158, 13);
            this.TituloCadastroGrupo.TabIndex = 5;
            this.TituloCadastroGrupo.Text = "Preencha o campo abaixo:";
            // 
            // CadastroGrupo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(326, 248);
            this.Controls.Add(this.TituloCadastroGrupo);
            this.Controls.Add(this.TextGrupo);
            this.Controls.Add(this.EnredoCadastroGrupo);
            this.Controls.Add(this.BGrupoSalvar);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "CadastroGrupo";
            this.Text = "CadastroGrupo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BGrupoSalvar;
        private System.Windows.Forms.Label EnredoCadastroGrupo;
        private System.Windows.Forms.TextBox TextGrupo;
        private System.Windows.Forms.Label TituloCadastroGrupo;
    }
}