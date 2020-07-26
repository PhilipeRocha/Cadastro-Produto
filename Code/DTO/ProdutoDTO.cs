using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCadastro2020.Code.DTO {
    class ProdutoDTO {
        private int id;
        private string nomeproduto;
        private int grupoid;
        private string descricao;
        private double precovenda;
        private double precocusto;
        private double estoque;
        private string ncm;
        private string localizacao;
        private string codigobarras;

        public int Id { get => id; set => id = value; }
        public int Grupoid { get => grupoid; set => grupoid = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public double Precovenda { get => precovenda; set => precovenda = value; }
        public double Precocusto { get => precocusto; set => precocusto = value; }
        public double Estoque { get => estoque; set => estoque = value; }
        public string Ncm { get => ncm; set => ncm = value; }
        public string Localizacao { get => localizacao; set => localizacao = value; }
        public string Codigobarras { get => codigobarras; set => codigobarras = value; }
        public string Nomeproduto { get => nomeproduto; set => nomeproduto = value; }
    }
}
