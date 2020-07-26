using ProjetoCadastro2020.Code.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoCadastro2020.Code.BLL;

namespace ProjetoCadastro2020 {
    public partial class CadastroProduto : Form {

        ProdutoDTO ProdutoDTO = new ProdutoDTO();
        ProdutoBLL ProdutoBLL = new ProdutoBLL();

        public CadastroProduto() {
            InitializeComponent();
        }

        private void TextNomeProduto_TextChanged(object sender, EventArgs e) {

        }

        private void BCadastroSalvar_Click(object sender, EventArgs e) {
            ProdutoDTO.Nomeproduto = TextNomeProduto.Text;
            ProdutoDTO.Grupoid = int.Parse(TextGrupoCadastro.Text);
            ProdutoDTO.Descricao = TextDescricao.Text;
            ProdutoDTO.Precovenda = Convert.ToDouble(TextPrecoVenda.Text);
            ProdutoDTO.Precocusto = Convert.ToDouble(TextPrecoCusto.Text);
            ProdutoDTO.Estoque = Convert.ToDouble(TextEstoque.Text);
            ProdutoDTO.Ncm = TextNCM.Text;
            ProdutoDTO.Localizacao = TextLocalizacao.Text;
            ProdutoDTO.Codigobarras = TextCodigoB.Text;
            ProdutoBLL.InserirProduto(ProdutoDTO);
            MessageBox.Show("Produto cadastrado com sucesso!", "Cadastrado com sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LimparTela();
        }
        private void LimparTela() {
            TextNomeProduto.Clear();
            TextGrupoCadastro.Clear();
            TextDescricao.Clear();
            TextPrecoVenda.Clear();
            TextPrecoCusto.Clear();
            TextEstoque.Clear();
            TextNCM.Clear();
            TextLocalizacao.Clear();
            TextCodigoB.Clear();
        }




    }
}
