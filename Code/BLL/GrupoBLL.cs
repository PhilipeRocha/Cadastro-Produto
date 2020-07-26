using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoCadastro2020.Code.DTO;
using ProjetoCadastro2020.Code.DAL;
using System.Data;

namespace ProjetoCadastro2020.Code.BLL {

    class GrupoBLL {

        AcessoBancoDados bd;
        public void InserirGrupo(GrupoDTO dto) {

            try {

                string nomeGrupo = dto.NomeGrupo.Replace("'", "''");
                bd = new AcessoBancoDados();

                bd.Conectar();

                string comando = "INSERT INTO Grupos(NomeGrupo) VALUES('" + nomeGrupo + "')";
                bd.ExecutarComandoSQL(comando);

            } catch (Exception ex) {
                throw new Exception("Erro ao cadastrar o grupo" + ex.Message);

            } finally {
                bd = null;
            }

        }
        public void EditarGrupo(GrupoDTO dto) {
            try {
                string nomeGrupo = dto.NomeGrupo.Replace("'", "''");
                bd = new AcessoBancoDados();

                bd.Conectar();

                string comando = "UPDATE grupos set NomeGrupo = '" + nomeGrupo + "' Where ID =" + dto.Id;
                bd.ExecutarComandoSQL(comando);

            } catch (Exception ex) {
                throw new Exception("Erro ao editar o produto: " + ex.Message);

            } finally {
                bd = null;
            }
        }
        public DataTable SelecionaGrupos() {
            DataTable dtg = new DataTable();
            try {

                bd = new AcessoBancoDados();
                bd.Conectar();

                dtg = bd.RetDataTable("SELECT Id, NomeGrupo FROM grupos");
            } catch (Exception ex) {
                throw new Exception("Erro ao tentar selecionar os grupos: " + ex.Message);

            } finally {
                bd = null;
            }
            return dtg;
        }
    }
}
