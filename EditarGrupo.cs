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
    public partial class EditarGrupo : Form {

        GrupoBLL GrupoBLL = new GrupoBLL();
        GrupoDTO GrupoDTO = new GrupoDTO();
        public EditarGrupo() {
            InitializeComponent();
        }

        private void SalvarGrupo_Click(object sender, EventArgs e) {
            try {
                GrupoDTO.Id = int.Parse(TextIdGEditar.Text);
                GrupoDTO.NomeGrupo = TextGrupoEditar.Text;

                GrupoBLL.EditarGrupo(GrupoDTO);
                MessageBox.Show("Grupo editado com sucesso!", "Edição concluída", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimparTelaGrupo();
                CarregarGridG();
            } catch (Exception ex) {
                MessageBox.Show("Você não selecionou nada para atualizar, tente clicar em algum registro", "Erro ao salvar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw new Exception("Você não selecionou nada para atualizar, tente clicar em algum registro " + ex.Message);
            }
        }

        private void EditarGrupo_Load(object sender, EventArgs e) {
            CarregarGridG();
        }
        private void CarregarGridG() {
            GridGrupo.DataSource = GrupoBLL.SelecionaGrupos();
        }

        private void GridGrupo_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            TextIdGEditar.Text = GridGrupo.Rows[e.RowIndex].Cells[0].Value.ToString();
            TextGrupoEditar.Text = GridGrupo.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void LimparTelaGrupo() {
            TextIdGEditar.Clear();
            TextGrupoEditar.Clear();
        }
    }
}
