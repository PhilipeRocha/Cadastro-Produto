using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCadastro2020.Code.DTO {
    class GrupoDTO {
        private int id;
        private string nomeGrupo;

        public int Id { get => id; set => id = value; }
        public string NomeGrupo { get => nomeGrupo; set => nomeGrupo = value; }
    }
}
