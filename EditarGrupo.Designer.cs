namespace ProjetoCadastro2020 {
    partial class EditarGrupo {
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
            this.label12 = new System.Windows.Forms.Label();
            this.TextGrupoEditar = new System.Windows.Forms.TextBox();
            this.TextIdGEditar = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.SalvarGrupo = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.GridGrupo = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.GridGrupo)).BeginInit();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(12, 30);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(230, 16);
            this.label12.TabIndex = 59;
            this.label12.Text = "Selecione um grupo para editar:";
            // 
            // TextGrupoEditar
            // 
            this.TextGrupoEditar.BackColor = System.Drawing.Color.LightBlue;
            this.TextGrupoEditar.Location = new System.Drawing.Point(361, 94);
            this.TextGrupoEditar.Name = "TextGrupoEditar";
            this.TextGrupoEditar.Size = new System.Drawing.Size(179, 20);
            this.TextGrupoEditar.TabIndex = 58;
            // 
            // TextIdGEditar
            // 
            this.TextIdGEditar.BackColor = System.Drawing.Color.LightSkyBlue;
            this.TextIdGEditar.Location = new System.Drawing.Point(294, 64);
            this.TextIdGEditar.Name = "TextIdGEditar";
            this.TextIdGEditar.ReadOnly = true;
            this.TextIdGEditar.Size = new System.Drawing.Size(27, 20);
            this.TextIdGEditar.TabIndex = 57;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Gold;
            this.label11.Location = new System.Drawing.Point(358, 53);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 13);
            this.label11.TabIndex = 56;
            this.label11.Text = "Edição Grupo:";
            // 
            // SalvarGrupo
            // 
            this.SalvarGrupo.BackColor = System.Drawing.Color.Silver;
            this.SalvarGrupo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SalvarGrupo.Location = new System.Drawing.Point(394, 136);
            this.SalvarGrupo.Name = "SalvarGrupo";
            this.SalvarGrupo.Size = new System.Drawing.Size(75, 23);
            this.SalvarGrupo.TabIndex = 55;
            this.SalvarGrupo.Text = "Salvar";
            this.SalvarGrupo.UseVisualStyleBackColor = false;
            this.SalvarGrupo.Click += new System.EventHandler(this.SalvarGrupo_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(265, 97);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 13);
            this.label10.TabIndex = 54;
            this.label10.Text = "Nome do grupo:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(264, 67);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(24, 13);
            this.label9.TabIndex = 53;
            this.label9.Text = "ID:";
            // 
            // GridGrupo
            // 
            this.GridGrupo.BackgroundColor = System.Drawing.Color.Silver;
            this.GridGrupo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.GridGrupo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridGrupo.GridColor = System.Drawing.Color.Teal;
            this.GridGrupo.Location = new System.Drawing.Point(12, 53);
            this.GridGrupo.Name = "GridGrupo";
            this.GridGrupo.Size = new System.Drawing.Size(240, 106);
            this.GridGrupo.TabIndex = 52;
            this.GridGrupo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridGrupo_CellContentClick);
            // 
            // EditarGrupo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(552, 191);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.TextGrupoEditar);
            this.Controls.Add(this.TextIdGEditar);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.SalvarGrupo);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.GridGrupo);
            this.Name = "EditarGrupo";
            this.Text = "Editar grupo";
            this.Load += new System.EventHandler(this.EditarGrupo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridGrupo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox TextGrupoEditar;
        private System.Windows.Forms.TextBox TextIdGEditar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button SalvarGrupo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView GridGrupo;
    }
}