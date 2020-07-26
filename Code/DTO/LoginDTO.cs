using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCadastro2020.Code.DTO {
    class LoginDTO {
        private string servidor;
        private string senha;
        private string bancoDados;
        private string user;

        public string Servidor { get => Servidor; set => Servidor = value; }
        public string Senha { get => senha; set => senha = value; }
        public string BancoDados { get => bancoDados; set => bancoDados = value; }
        public string User { get => user; set => user = value; }
    }
}
