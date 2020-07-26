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
    public partial class CadastroGrupo : Form {
        GrupoDTO GrupoDTO = new GrupoDTO();
        GrupoBLL GrupoBLL = new GrupoBLL();

        public CadastroGrupo() {
            InitializeComponent();
        }


        private void TextGrupo_TextChanged(object sender, EventArgs e) {

        }

        private void BGrupoSalvar_Click(object sender, EventArgs e) {
            GrupoDTO.NomeGrupo = TextGrupo.Text;
            GrupoBLL.InserirGrupo(GrupoDTO);
            MessageBox.Show("Grupo cadastrado com sucesso!", "Cadastrado com sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
