namespace ProjetoCadastro2020 {
    partial class CadastroProduto {
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
            this.EnredoNomeProduto = new System.Windows.Forms.Label();
            this.TextNomeProduto = new System.Windows.Forms.TextBox();
            this.BCadastroSalvar = new System.Windows.Forms.Button();
            this.EnredoGrupoNoProduto = new System.Windows.Forms.Label();
            this.TextGrupoCadastro = new System.Windows.Forms.TextBox();
            this.TituloCadastroProduto = new System.Windows.Forms.Label();
            this.TextDescricao = new System.Windows.Forms.TextBox();
            this.TextPrecoVenda = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TextLocalizacao = new System.Windows.Forms.TextBox();
            this.TextNCM = new System.Windows.Forms.TextBox();
            this.TextEstoque = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TextPrecoCusto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TextCodigoB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // EnredoNomeProduto
            // 
            this.EnredoNomeProduto.AutoSize = true;
            this.EnredoNomeProduto.BackColor = System.Drawing.Color.Transparent;
            this.EnredoNomeProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnredoNomeProduto.Location = new System.Drawing.Point(50, 98);
            this.EnredoNomeProduto.Name = "EnredoNomeProduto";
            this.EnredoNomeProduto.Size = new System.Drawing.Size(108, 13);
            this.EnredoNomeProduto.TabIndex = 0;
            this.EnredoNomeProduto.Text = "Nome do produto:";
            // 
            // TextNomeProduto
            // 
            this.TextNomeProduto.BackColor = System.Drawing.Color.LightBlue;
            this.TextNomeProduto.Location = new System.Drawing.Point(158, 95);
            this.TextNomeProduto.Name = "TextNomeProduto";
            this.TextNomeProduto.Size = new System.Drawing.Size(310, 20);
            this.TextNomeProduto.TabIndex = 1;
            this.TextNomeProduto.TextChanged += new System.EventHandler(this.TextNomeProduto_TextChanged);
            // 
            // BCadastroSalvar
            // 
            this.BCadastroSalvar.BackColor = System.Drawing.Color.Silver;
            this.BCadastroSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BCadastroSalvar.Location = new System.Drawing.Point(219, 379);
            this.BCadastroSalvar.Name = "BCadastroSalvar";
            this.BCadastroSalvar.Size = new System.Drawing.Size(75, 23);
            this.BCadastroSalvar.TabIndex = 2;
            this.BCadastroSalvar.Text = "Salvar";
            this.BCadastroSalvar.UseVisualStyleBackColor = false;
            this.BCadastroSalvar.Click += new System.EventHandler(this.BCadastroSalvar_Click);
            // 
            // EnredoGrupoNoProduto
            // 
            this.EnredoGrupoNoProduto.AutoSize = true;
            this.EnredoGrupoNoProduto.BackColor = System.Drawing.Color.Transparent;
            this.EnredoGrupoNoProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnredoGrupoNoProduto.Location = new System.Drawing.Point(96, 121);
            this.EnredoGrupoNoProduto.Name = "EnredoGrupoNoProduto";
            this.EnredoGrupoNoProduto.Size = new System.Drawing.Size(62, 13);
            this.EnredoGrupoNoProduto.TabIndex = 3;
            this.EnredoGrupoNoProduto.Text = "Grupo ID:";
            // 
            // TextGrupoCadastro
            // 
            this.TextGrupoCadastro.BackColor = System.Drawing.Color.LightBlue;
            this.TextGrupoCadastro.Location = new System.Drawing.Point(158, 118);
            this.TextGrupoCadastro.Name = "TextGrupoCadastro";
            this.TextGrupoCadastro.Size = new System.Drawing.Size(63, 20);
            this.TextGrupoCadastro.TabIndex = 4;
            // 
            // TituloCadastroProduto
            // 
            this.TituloCadastroProduto.AutoSize = true;
            this.TituloCadastroProduto.BackColor = System.Drawing.Color.Transparent;
            this.TituloCadastroProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TituloCadastroProduto.ForeColor = System.Drawing.Color.Gold;
            this.TituloCadastroProduto.Location = new System.Drawing.Point(12, 26);
            this.TituloCadastroProduto.Name = "TituloCadastroProduto";
            this.TituloCadastroProduto.Size = new System.Drawing.Size(282, 13);
            this.TituloCadastroProduto.TabIndex = 5;
            this.TituloCadastroProduto.Text = "Preencha os campos para cadastrar um produto:";
            // 
            // TextDescricao
            // 
            this.TextDescricao.BackColor = System.Drawing.Color.LightBlue;
            this.TextDescricao.Location = new System.Drawing.Point(158, 144);
            this.TextDescricao.Name = "TextDescricao";
            this.TextDescricao.Size = new System.Drawing.Size(356, 20);
            this.TextDescricao.TabIndex = 6;
            // 
            // TextPrecoVenda
            // 
            this.TextPrecoVenda.BackColor = System.Drawing.Color.LightBlue;
            this.TextPrecoVenda.Location = new System.Drawing.Point(158, 172);
            this.TextPrecoVenda.Name = "TextPrecoVenda";
            this.TextPrecoVenda.Size = new System.Drawing.Size(182, 20);
            this.TextPrecoVenda.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(90, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Descrição:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(74, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Preço Venda:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(79, 282);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Localização:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(120, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "NCM:";
            // 
            // TextLocalizacao
            // 
            this.TextLocalizacao.BackColor = System.Drawing.Color.LightBlue;
            this.TextLocalizacao.Location = new System.Drawing.Point(157, 279);
            this.TextLocalizacao.Name = "TextLocalizacao";
            this.TextLocalizacao.Size = new System.Drawing.Size(357, 20);
            this.TextLocalizacao.TabIndex = 17;
            // 
            // TextNCM
            // 
            this.TextNCM.BackColor = System.Drawing.Color.LightBlue;
            this.TextNCM.Location = new System.Drawing.Point(157, 251);
            this.TextNCM.Name = "TextNCM";
            this.TextNCM.Size = new System.Drawing.Size(207, 20);
            this.TextNCM.TabIndex = 16;
            // 
            // TextEstoque
            // 
            this.TextEstoque.BackColor = System.Drawing.Color.LightBlue;
            this.TextEstoque.Location = new System.Drawing.Point(157, 224);
            this.TextEstoque.Name = "TextEstoque";
            this.TextEstoque.Size = new System.Drawing.Size(207, 20);
            this.TextEstoque.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(101, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Estoque:";
            // 
            // TextPrecoCusto
            // 
            this.TextPrecoCusto.BackColor = System.Drawing.Color.LightBlue;
            this.TextPrecoCusto.Location = new System.Drawing.Point(157, 199);
            this.TextPrecoCusto.Name = "TextPrecoCusto";
            this.TextPrecoCusto.Size = new System.Drawing.Size(183, 20);
            this.TextPrecoCusto.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(78, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Preço Custo:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(51, 311);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Código de barras:";
            // 
            // TextCodigoB
            // 
            this.TextCodigoB.BackColor = System.Drawing.Color.LightBlue;
            this.TextCodigoB.Location = new System.Drawing.Point(157, 308);
            this.TextCodigoB.Name = "TextCodigoB";
            this.TextCodigoB.Size = new System.Drawing.Size(207, 20);
            this.TextCodigoB.TabIndex = 20;
            // 
            // CadastroProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(550, 419);
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
            this.Controls.Add(this.TituloCadastroProduto);
            this.Controls.Add(this.TextGrupoCadastro);
            this.Controls.Add(this.EnredoGrupoNoProduto);
            this.Controls.Add(this.BCadastroSalvar);
            this.Controls.Add(this.TextNomeProduto);
            this.Controls.Add(this.EnredoNomeProduto);
            this.Name = "CadastroProduto";
            this.Text = "Cadastro de Produto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label EnredoNomeProduto;
        private System.Windows.Forms.TextBox TextNomeProduto;
        private System.Windows.Forms.Button BCadastroSalvar;
        private System.Windows.Forms.Label EnredoGrupoNoProduto;
        private System.Windows.Forms.TextBox TextGrupoCadastro;
        private System.Windows.Forms.Label TituloCadastroProduto;
        private System.Windows.Forms.TextBox TextDescricao;
        private System.Windows.Forms.TextBox TextPrecoVenda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TextLocalizacao;
        private System.Windows.Forms.TextBox TextNCM;
        private System.Windows.Forms.TextBox TextEstoque;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TextPrecoCusto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TextCodigoB;
    }
}