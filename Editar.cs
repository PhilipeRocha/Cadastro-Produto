using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoCadastro2020.Code.DTO;
using ProjetoCadastro2020.Code.BLL;

namespace ProjetoCadastro2020 {
    public partial class Editar : Form {

        ProdutoDTO EditarDTO = new ProdutoDTO();
        ProdutoBLL EditarBLL = new ProdutoBLL();

        GrupoDTO GrupoDTO = new GrupoDTO();
        GrupoBLL GrupoBLL = new GrupoBLL();
        public Editar() {
            InitializeComponent();
        }

        private void GridProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            TextId.Text = GridProdutos.Rows[e.RowIndex].Cells[0].Value.ToString();
            TextNomeProduto.Text = GridProdutos.Rows[e.RowIndex].Cells[1].Value.ToString();
            TextGrupoCadastro.Text = GridProdutos.Rows[e.RowIndex].Cells[2].Value.ToString();
            TextDescricao.Text = GridProdutos.Rows[e.RowIndex].Cells[3].Value.ToString();
            TextPrecoVenda.Text = GridProdutos.Rows[e.RowIndex].Cells[4].Value.ToString();
            TextPrecoCusto.Text = GridProdutos.Rows[e.RowIndex].Cells[5].Value.ToString();
            TextEstoque.Text = GridProdutos.Rows[e.RowIndex].Cells[6].Value.ToString();
            TextNCM.Text = GridProdutos.Rows[e.RowIndex].Cells[7].Value.ToString();
            TextLocalizacao.Text = GridProdutos.Rows[e.RowIndex].Cells[8].Value.ToString();
            TextCodigoB.Text = GridProdutos.Rows[e.RowIndex].Cells[9].Value.ToString();

        }

        private void BSalvarEditar_Click(object sender, EventArgs e) {
            try {
                EditarDTO.Id = int.Parse(TextId.Text);
                EditarDTO.Nomeproduto = TextNomeProduto.Text;
                EditarDTO.Grupoid = int.Parse(TextGrupoCadastro.Text);
                EditarDTO.Descricao = TextDescricao.Text;
                EditarDTO.Precovenda = Convert.ToDouble(TextPrecoVenda.Text);
                EditarDTO.Precocusto = Convert.ToDouble(TextPrecoCusto.Text);
                EditarDTO.Estoque = Convert.ToDouble(TextEstoque.Text);
                EditarDTO.Ncm = TextNCM.Text;
                EditarDTO.Localizacao = TextLocalizacao.Text;
                EditarDTO.Codigobarras = TextCodigoB.Text;


                EditarBLL.EditarProduto(EditarDTO);
                MessageBox.Show("Produto editado com sucesso!", "Edição concluída", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimparTela();
                CarregarGrid();
            } catch (Exception ex) {
                MessageBox.Show("Você não selecionou nada para atualizar, tente clicar em algum registro", "Erro ao salvar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw new Exception("Você não selecionou nada para atualizar, tente clicar em algum registro " + ex.Message);
            }



        }

        private void BExcluirEditar_Click(object sender, EventArgs e) {

            var Resultado = MessageBox.Show("Certeza que deseja excluir?", "Exclusão do Produto", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (Resultado == System.Windows.Forms.DialogResult.Yes) {
                EditarBLL.ExcluirProduto(TextId.Text);
                MessageBox.Show("Removido com sucesso", "Remoção completa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void Editar_Load(object sender, EventArgs e) {
            CarregarGrid();
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
            TextId.Clear();
        }

        private void CarregarGrid() {
            GridProdutos.DataSource = EditarBLL.SelecionaProdutos();
        }
    }   
}
