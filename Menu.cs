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
using ProjetoCadastro2020.Code.DTO;

namespace ProjetoCadastro2020 {
    public partial class Menu : Form {
        GrupoBLL bllGrupo = new GrupoBLL();
        GrupoDTO dtoGrupo = new GrupoDTO();

        ProdutoDTO EditarDTO = new ProdutoDTO();
        ProdutoBLL EditarBLL = new ProdutoBLL();
        public Menu() {
            InitializeComponent();
        }

        //metodo para abrir forms
        private void AbreCadastro(Form form) {
            foreach (Form formCadastro in this.MdiChildren) {
                if (formCadastro.GetType() == form.GetType()) {
                    formCadastro.Focus();
                    return;
                }
            }
            form.ShowDialog();
        }

        private void cadastroGrupoToolStripMenuItem_Click(object sender, EventArgs e) {
        }
        //Cadastro do grupo
        private void BGrupo_Click(object sender, EventArgs e) {
            this.AbreCadastro(new CadastroGrupo());
            
        }

        private void Menu_Load(object sender, EventArgs e) {
            CarregarGrid();
            CarregarGridG();
        }

        //Cadastro Produto
        private void BProduto_Click(object sender, EventArgs e) {
            this.AbreCadastro(new CadastroProduto());
        }

        //Editor produto
        private void BEditarMenu_Click(object sender, EventArgs e) {
            this.AbreCadastro(new Editar());
        }

        //EditorGrupo
        private void EditarGrupo_Click(object sender, EventArgs e) {
            this.AbreCadastro(new EditarGrupo());
        }

        private void RecarregarGrid_Click(object sender, EventArgs e) {
            CarregarGrid();  
        }

        private void CarregarGridG() {
            GridGrupo.DataSource = bllGrupo.SelecionaGrupos();
        }
        private void CarregarGrid() {
            GridProdutos.DataSource = EditarBLL.SelecionaProdutos();
        }

        private void RecarregarG_Click(object sender, EventArgs e) {
            CarregarGridG();
        }
    }
}
