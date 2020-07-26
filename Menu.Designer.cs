namespace ProjetoCadastro2020 {
    partial class Menu {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent() {
            this.BProduto = new System.Windows.Forms.Button();
            this.GridProdutos = new System.Windows.Forms.DataGridView();
            this.ProdutosMenu = new System.Windows.Forms.Label();
            this.BGrupo = new System.Windows.Forms.Button();
            this.TituloMenu = new System.Windows.Forms.Label();
            this.BEditarMenu = new System.Windows.Forms.Button();
            this.RecarregarGrid = new System.Windows.Forms.Button();
            this.GridGrupo = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.RecarregarG = new System.Windows.Forms.Button();
            this.EditarGrupo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GridProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridGrupo)).BeginInit();
            this.SuspendLayout();
            // 
            // BProduto
            // 
            this.BProduto.BackColor = System.Drawing.Color.Silver;
            this.BProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BProduto.Location = new System.Drawing.Point(94, 394);
            this.BProduto.Name = "BProduto";
            this.BProduto.Size = new System.Drawing.Size(75, 23);
            this.BProduto.TabIndex = 1;
            this.BProduto.Text = "Criar";
            this.BProduto.UseVisualStyleBackColor = false;
            this.BProduto.Click += new System.EventHandler(this.BProduto_Click);
            // 
            // GridProdutos
            // 
            this.GridProdutos.BackgroundColor = System.Drawing.Color.Silver;
            this.GridProdutos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.GridProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridProdutos.GridColor = System.Drawing.Color.Teal;
            this.GridProdutos.Location = new System.Drawing.Point(12, 47);
            this.GridProdutos.Name = "GridProdutos";
            this.GridProdutos.Size = new System.Drawing.Size(468, 341);
            this.GridProdutos.TabIndex = 8;
            // 
            // ProdutosMenu
            // 
            this.ProdutosMenu.AutoSize = true;
            this.ProdutosMenu.BackColor = System.Drawing.Color.Transparent;
            this.ProdutosMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProdutosMenu.ForeColor = System.Drawing.Color.DarkRed;
            this.ProdutosMenu.Location = new System.Drawing.Point(202, 28);
            this.ProdutosMenu.Name = "ProdutosMenu";
            this.ProdutosMenu.Size = new System.Drawing.Size(74, 16);
            this.ProdutosMenu.TabIndex = 10;
            this.ProdutosMenu.Text = "Produtos:";
            // 
            // BGrupo
            // 
            this.BGrupo.BackColor = System.Drawing.Color.Silver;
            this.BGrupo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BGrupo.Location = new System.Drawing.Point(513, 394);
            this.BGrupo.Name = "BGrupo";
            this.BGrupo.Size = new System.Drawing.Size(75, 23);
            this.BGrupo.TabIndex = 11;
            this.BGrupo.Text = "Criar";
            this.BGrupo.UseVisualStyleBackColor = false;
            this.BGrupo.Click += new System.EventHandler(this.BGrupo_Click);
            // 
            // TituloMenu
            // 
            this.TituloMenu.AutoSize = true;
            this.TituloMenu.BackColor = System.Drawing.Color.Transparent;
            this.TituloMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TituloMenu.ForeColor = System.Drawing.Color.Black;
            this.TituloMenu.Location = new System.Drawing.Point(8, 9);
            this.TituloMenu.Name = "TituloMenu";
            this.TituloMenu.Size = new System.Drawing.Size(225, 20);
            this.TituloMenu.TabIndex = 13;
            this.TituloMenu.Text = "Cadastros Rocha Software";
            // 
            // BEditarMenu
            // 
            this.BEditarMenu.BackColor = System.Drawing.Color.Silver;
            this.BEditarMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BEditarMenu.Location = new System.Drawing.Point(331, 394);
            this.BEditarMenu.Name = "BEditarMenu";
            this.BEditarMenu.Size = new System.Drawing.Size(75, 23);
            this.BEditarMenu.TabIndex = 15;
            this.BEditarMenu.Text = "Editar";
            this.BEditarMenu.UseVisualStyleBackColor = false;
            this.BEditarMenu.Click += new System.EventHandler(this.BEditarMenu_Click);
            // 
            // RecarregarGrid
            // 
            this.RecarregarGrid.BackColor = System.Drawing.Color.Silver;
            this.RecarregarGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RecarregarGrid.Location = new System.Drawing.Point(215, 394);
            this.RecarregarGrid.Name = "RecarregarGrid";
            this.RecarregarGrid.Size = new System.Drawing.Size(75, 23);
            this.RecarregarGrid.TabIndex = 18;
            this.RecarregarGrid.Text = "Recarregar";
            this.RecarregarGrid.UseVisualStyleBackColor = false;
            this.RecarregarGrid.Click += new System.EventHandler(this.RecarregarGrid_Click);
            // 
            // GridGrupo
            // 
            this.GridGrupo.BackgroundColor = System.Drawing.Color.Silver;
            this.GridGrupo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.GridGrupo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridGrupo.GridColor = System.Drawing.Color.Teal;
            this.GridGrupo.Location = new System.Drawing.Point(497, 47);
            this.GridGrupo.Name = "GridGrupo";
            this.GridGrupo.Size = new System.Drawing.Size(278, 341);
            this.GridGrupo.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(604, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 21;
            this.label1.Text = "Grupos:";
            // 
            // RecarregarG
            // 
            this.RecarregarG.BackColor = System.Drawing.Color.Silver;
            this.RecarregarG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RecarregarG.Location = new System.Drawing.Point(700, 394);
            this.RecarregarG.Name = "RecarregarG";
            this.RecarregarG.Size = new System.Drawing.Size(75, 23);
            this.RecarregarG.TabIndex = 22;
            this.RecarregarG.Text = "Recarregar";
            this.RecarregarG.UseVisualStyleBackColor = false;
            this.RecarregarG.Click += new System.EventHandler(this.RecarregarG_Click);
            // 
            // EditarGrupo
            // 
            this.EditarGrupo.BackColor = System.Drawing.Color.Silver;
            this.EditarGrupo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditarGrupo.Location = new System.Drawing.Point(607, 394);
            this.EditarGrupo.Name = "EditarGrupo";
            this.EditarGrupo.Size = new System.Drawing.Size(75, 23);
            this.EditarGrupo.TabIndex = 24;
            this.EditarGrupo.Text = "Editar";
            this.EditarGrupo.UseVisualStyleBackColor = false;
            this.EditarGrupo.Click += new System.EventHandler(this.EditarGrupo_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(787, 438);
            this.Controls.Add(this.EditarGrupo);
            this.Controls.Add(this.RecarregarG);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GridGrupo);
            this.Controls.Add(this.RecarregarGrid);
            this.Controls.Add(this.BEditarMenu);
            this.Controls.Add(this.TituloMenu);
            this.Controls.Add(this.BGrupo);
            this.Controls.Add(this.ProdutosMenu);
            this.Controls.Add(this.GridProdutos);
            this.Controls.Add(this.BProduto);
            this.IsMdiContainer = true;
            this.Name = "Menu";
            this.Text = "Menu Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridGrupo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BProduto;
        private System.Windows.Forms.DataGridView GridProdutos;
        private System.Windows.Forms.Label ProdutosMenu;
        private System.Windows.Forms.Button BGrupo;
        private System.Windows.Forms.Label TituloMenu;
        private System.Windows.Forms.Button BEditarMenu;
        private System.Windows.Forms.Button RecarregarGrid;
        private System.Windows.Forms.DataGridView GridGrupo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button RecarregarG;
        private System.Windows.Forms.Button EditarGrupo;
    }
}

