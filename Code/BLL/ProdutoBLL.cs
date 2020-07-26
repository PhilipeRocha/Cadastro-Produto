using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoCadastro2020.Code.DTO;
using ProjetoCadastro2020.Code.DAL;
using System.Windows.Forms;
using System.Data;

namespace ProjetoCadastro2020.Code.BLL {
    class ProdutoBLL {

        AcessoBancoDados bd;

        public DataTable SelecionaProdutos() {
            DataTable dt = new DataTable();
            try {

                bd = new AcessoBancoDados();
                bd.Conectar();

                dt = bd.RetDataTable("SELECT ID, NomeProduto, GrupoID, Descricao, PVenda, PCusto, Estoque, NCM, Localizacao, CodigoBarras FROM produtos INNER JOIN grupos ON produtos.ID_Produto = Grupos.Id");
            } catch (Exception ex) {
                throw new Exception("Erro ao tentar selecionar os produtos: " + ex.Message);

            } finally {
                bd = null;
            }
            return dt;
        }

        public void InserirProduto(ProdutoDTO dto) {
            try {
                string nomeProduto = dto.Nomeproduto.Replace("'", "''");
                string Descricao = dto.Descricao.Replace("'", "''");
                string Localizacao = dto.Localizacao.Replace("'", "''");
                string NCM = dto.Ncm.Replace("'", "''");
                string CodigoBarras = dto.Codigobarras.Replace("'", "''");
                bd = new AcessoBancoDados();

                bd.Conectar();

                string comando = "INSERT INTO Produtos(NomeProduto, GrupoID, Descricao, PVenda, PCusto, Estoque, NCM, Localizacao, CodigoBarras) VALUES('" + nomeProduto + "','" + dto.Grupoid + "','" + Descricao + "','" + dto.Precovenda + "','" + dto.Precocusto + "','" + dto.Estoque + "','" + NCM + "','" + Localizacao + "','" + CodigoBarras + "')";
                bd.ExecutarComandoSQL(comando);

            } catch (Exception ex) {
                throw new Exception("Erro ao cadastrar o produto: " + ex.Message);

            } finally {
                bd = null;
            }
        }
        public void EditarProduto(ProdutoDTO dto) {
            try {
                string nomeProduto = dto.Nomeproduto.Replace("'", "''");
                string Descricao = dto.Descricao.Replace("'", "''");
                string Localizacao = dto.Localizacao.Replace("'", "''");
                string NCM = dto.Ncm.Replace("'", "''");
                string CodigoBarras = dto.Codigobarras.Replace("'", "''");
                bd = new AcessoBancoDados();

                bd.Conectar();

                string comando = "UPDATE produtos set NomeProduto = '" + nomeProduto + "', GrupoID = '" + dto.Grupoid + "', Descricao = '" + Descricao + "', PVenda = '" + dto.Precovenda + "', PCusto = '" + dto.Precocusto + "', Estoque = '" + dto.Estoque + "', NCM = '" + NCM + "', Localizacao = '" + Localizacao + "', CodigoBarras = '" + CodigoBarras + "' Where ID_Produto =" + dto.Id;
                bd.ExecutarComandoSQL(comando);

            } catch (Exception ex) {
                throw new Exception("Erro ao editar o produto: " + ex.Message);

            } finally {
                bd = null;
            }
        }
        public void ExcluirProduto(string IdProduto) {

            try {
                bd = new AcessoBancoDados();

                bd.Conectar();
                string comando = "DELETE FROM Produtos WHERE Id_Produto =" + IdProduto;
                bd.ExecutarComandoSQL(comando);

            } catch (Exception ex) {
                throw new Exception("Erro ao tentar excluir o produto: " + ex.Message);

            } finally {
                bd = null;
            }
        }
    }
}
