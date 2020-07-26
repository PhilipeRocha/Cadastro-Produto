namespace ProjetoCadastro2020 {
    partial class Editar {
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
            this.TituloExcluir = new System.Windows.Forms.Label();
            this.BSalvarEditar = new System.Windows.Forms.Button();
            this.BExcluirEditar = new System.Windows.Forms.Button();
            this.GridProdutos = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.TextCodigoB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TextLocalizacao = new System.Windows.Forms.TextBox();
            this.TextNCM = new System.Windows.Forms.TextBox();
            this.TextEstoque = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TextPrecoCusto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TextPrecoVenda = new System.Windows.Forms.TextBox();
            this.TextDescricao = new System.Windows.Forms.TextBox();
            this.TextGrupoCadastro = new System.Windows.Forms.TextBox();
            this.EnredoGrupoNoProduto = new System.Windows.Forms.Label();
            this.TextNomeProduto = new System.Windows.Forms.TextBox();
            this.EnredoNomeProduto = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.IdEnredo = new System.Windows.Forms.Label();
            this.TextId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.GridProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // TituloExcluir
            // 
            this.TituloExcluir.AutoSize = true;
            this.TituloExcluir.BackColor = System.Drawing.Color.Transparent;
            this.TituloExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TituloExcluir.ForeColor = System.Drawing.Color.Black;
            this.TituloExcluir.Location = new System.Drawing.Point(12, 29);
            this.TituloExcluir.Name = "TituloExcluir";
            this.TituloExcluir.Size = new System.Drawing.Size(243, 16);
            this.TituloExcluir.TabIndex = 13;
            this.TituloExcluir.Text = "Selecione um produto para editar:";
            // 
            // BSalvarEditar
            // 
            this.BSalvarEditar.BackColor = System.Drawing.Color.Silver;
            this.BSalvarEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BSalvarEditar.Location = new System.Drawing.Point(327, 369);
            this.BSalvarEditar.Name = "BSalvarEditar";
            this.BSalvarEditar.Size = new System.Drawing.Size(75, 23);
            this.BSalvarEditar.TabIndex = 14;
            this.BSalvarEditar.Text = "Salvar";
            this.BSalvarEditar.UseVisualStyleBackColor = false;
            this.BSalvarEditar.Click += new System.EventHandler(this.BSalvarEditar_Click);
            // 
            // BExcluirEditar
            // 
            this.BExcluirEditar.BackColor = System.Drawing.Color.Silver;
            this.BExcluirEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BExcluirEditar.Location = new System.Drawing.Point(458, 369);
            this.BExcluirEditar.Name = "BExcluirEditar";
            this.BExcluirEditar.Size = new System.Drawing.Size(75, 23);
            this.BExcluirEditar.TabIndex = 16;
            this.BExcluirEditar.Text = "Excluir";
            this.BExcluirEditar.UseVisualStyleBackColor = false;
            this.BExcluirEditar.Click += new System.EventHandler(this.BExcluirEditar_Click);
            // 
            // GridProdutos
            // 
            this.GridProdutos.BackgroundColor = System.Drawing.Color.Silver;
            this.GridProdutos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.GridProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridProdutos.GridColor = System.Drawing.Color.Teal;
            this.GridProdutos.Location = new System.Drawing.Point(15, 62);
            this.GridProdutos.Name = "GridProdutos";
            this.GridProdutos.Size = new System.Drawing.Size(240, 330);
            this.GridProdutos.TabIndex = 17;
            this.GridProdutos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridProdutos_CellContentClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(265, 330);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 13);
            this.label7.TabIndex = 39;
            this.label7.Text = "Código de barras:";
            // 
            // TextCodigoB
            // 
            this.TextCodigoB.BackColor = System.Drawing.Color.LightBlue;
            this.TextCodigoB.Location = new System.Drawing.Point(373, 327);
            this.TextCodigoB.Name = "TextCodigoB";
            this.TextCodigoB.Size = new System.Drawing.Size(193, 20);
            this.TextCodigoB.TabIndex = 38;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(265, 301);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 37;
            this.label3.Text = "Localização:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(265, 273);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 36;
            this.label4.Text = "NCM:";
            // 
            // TextLocalizacao
            // 
            this.TextLocalizacao.BackColor = System.Drawing.Color.LightBlue;
            this.TextLocalizacao.Location = new System.Drawing.Point(343, 298);
            this.TextLocalizacao.Name = "TextLocalizacao";
            this.TextLocalizacao.Size = new System.Drawing.Size(223, 20);
            this.TextLocalizacao.TabIndex = 35;
            // 
            // TextNCM
            // 
            this.TextNCM.BackColor = System.Drawing.Color.LightBlue;
            this.TextNCM.Location = new System.Drawing.Point(308, 270);
            this.TextNCM.Name = "TextNCM";
            this.TextNCM.Size = new System.Drawing.Size(258, 20);
            this.TextNCM.TabIndex = 34;
            // 
            // TextEstoque
            // 
            this.TextEstoque.BackColor = System.Drawing.Color.LightBlue;
            this.TextEstoque.Location = new System.Drawing.Point(327, 243);
            this.TextEstoque.Name = "TextEstoque";
            this.TextEstoque.Size = new System.Drawing.Size(115, 20);
            this.TextEstoque.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(264, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "Estoque:";
            // 
            // TextPrecoCusto
            // 
            this.TextPrecoCusto.BackColor = System.Drawing.Color.LightBlue;
            this.TextPrecoCusto.Location = new System.Drawing.Point(350, 218);
            this.TextPrecoCusto.Name = "TextPrecoCusto";
            this.TextPrecoCusto.Size = new System.Drawing.Size(183, 20);
            this.TextPrecoCusto.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(264, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "Preço Custo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(265, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Preço Venda:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(265, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Descrição:";
            // 
            // TextPrecoVenda
            // 
            this.TextPrecoVenda.BackColor = System.Drawing.Color.LightBlue;
            this.TextPrecoVenda.Location = new System.Drawing.Point(350, 191);
            this.TextPrecoVenda.Name = "TextPrecoVenda";
            this.TextPrecoVenda.Size = new System.Drawing.Size(183, 20);
            this.TextPrecoVenda.TabIndex = 27;
            // 
            // TextDescricao
            // 
            this.TextDescricao.BackColor = System.Drawing.Color.LightBlue;
            this.TextDescricao.Location = new System.Drawing.Point(333, 163);
            this.TextDescricao.Name = "TextDescricao";
            this.TextDescricao.Size = new System.Drawing.Size(233, 20);
            this.TextDescricao.TabIndex = 26;
            // 
            // TextGrupoCadastro
            // 
            this.TextGrupoCadastro.BackColor = System.Drawing.Color.LightBlue;
            this.TextGrupoCadastro.Location = new System.Drawing.Point(333, 136);
            this.TextGrupoCadastro.Name = "TextGrupoCadastro";
            this.TextGrupoCadastro.Size = new System.Drawing.Size(35, 20);
            this.TextGrupoCadastro.TabIndex = 25;
            // 
            // EnredoGrupoNoProduto
            // 
            this.EnredoGrupoNoProduto.AutoSize = true;
            this.EnredoGrupoNoProduto.BackColor = System.Drawing.Color.Transparent;
            this.EnredoGrupoNoProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnredoGrupoNoProduto.Location = new System.Drawing.Point(265, 139);
            this.EnredoGrupoNoProduto.Name = "EnredoGrupoNoProduto";
            this.EnredoGrupoNoProduto.Size = new System.Drawing.Size(62, 13);
            this.EnredoGrupoNoProduto.TabIndex = 24;
            this.EnredoGrupoNoProduto.Text = "Grupo ID:";
            // 
            // TextNomeProduto
            // 
            this.TextNomeProduto.BackColor = System.Drawing.Color.LightBlue;
            this.TextNomeProduto.Location = new System.Drawing.Point(377, 114);
            this.TextNomeProduto.Name = "TextNomeProduto";
            this.TextNomeProduto.Size = new System.Drawing.Size(189, 20);
            this.TextNomeProduto.TabIndex = 23;
            // 
            // EnredoNomeProduto
            // 
            this.EnredoNomeProduto.AutoSize = true;
            this.EnredoNomeProduto.BackColor = System.Drawing.Color.Transparent;
            this.EnredoNomeProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnredoNomeProduto.Location = new System.Drawing.Point(265, 117);
            this.EnredoNomeProduto.Name = "EnredoNomeProduto";
            this.EnredoNomeProduto.Size = new System.Drawing.Size(108, 13);
            this.EnredoNomeProduto.TabIndex = 22;
            this.EnredoNomeProduto.Text = "Nome do produto:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Gold;
            this.label8.Location = new System.Drawing.Point(358, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 13);
            this.label8.TabIndex = 40;
            this.label8.Text = "Edição Produto:";
            // 
            // IdEnredo
            // 
            this.IdEnredo.AutoSize = true;
            this.IdEnredo.BackColor = System.Drawing.Color.Transparent;
            this.IdEnredo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdEnredo.Location = new System.Drawing.Point(265, 92);
            this.IdEnredo.Name = "IdEnredo";
            this.IdEnredo.Size = new System.Drawing.Size(24, 13);
            this.IdEnredo.TabIndex = 41;
            this.IdEnredo.Text = "ID:";
            // 
            // TextId
            // 
            this.TextId.BackColor = System.Drawing.Color.LightSkyBlue;
            this.TextId.Location = new System.Drawing.Point(294, 89);
            this.TextId.Name = "TextId";
            this.TextId.ReadOnly = true;
            this.TextId.Size = new System.Drawing.Size(27, 20);
            this.TextId.TabIndex = 42;
            // 
            // Editar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(578, 417);
            this.Controls.Add(this.TextId);
            this.Controls.Add(this.IdEnredo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TextCodigoB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TextLocalizacao);
            this.Controls.Add(this.TextNCM);
            this.Controls.Add(this.TextEstoque);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TextPrecoCusto);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextPrecoVenda);
            this.Controls.Add(this.TextDescricao);
            this.Controls.Add(this.TextGrupoCadastro);
            this.Controls.Add(this.EnredoGrupoNoProduto);
            this.Controls.Add(this.TextNomeProduto);
            this.Controls.Add(this.EnredoNomeProduto);
            this.Controls.Add(this.GridProdutos);
            this.Controls.Add(this.BExcluirEditar);
            this.Controls.Add(this.BSalvarEditar);
            this.Controls.Add(this.TituloExcluir);
            this.Name = "Editar";
            this.Text = "Editar";
            this.Load += new System.EventHandler(this.Editar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridProdutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TituloExcluir;
        private System.Windows.Forms.Button BSalvarEditar;
        private System.Windows.Forms.Button BExcluirEditar;
        private System.Windows.Forms.DataGridView GridProdutos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TextCodigoB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TextLocalizacao;
        private System.Windows.Forms.TextBox TextNCM;
        private System.Windows.Forms.TextBox TextEstoque;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TextPrecoCusto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextPrecoVenda;
        private System.Windows.Forms.TextBox TextDescricao;
        private System.Windows.Forms.TextBox TextGrupoCadastro;
        private System.Windows.Forms.Label EnredoGrupoNoProduto;
        private System.Windows.Forms.TextBox TextNomeProduto;
        private System.Windows.Forms.Label EnredoNomeProduto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label IdEnredo;
        private System.Windows.Forms.TextBox TextId;
    }
}