using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using ProjetoCadastro2020.Code.DTO;

namespace ProjetoCadastro2020.Code.DAL {
    class AcessoBancoDados {
        private MySqlConnection conn;
        private DataTable data;
        private MySqlDataAdapter da;
        private MySqlDataReader dr;
        private MySqlCommandBuilder cb;


        private String server = "localhost";
        private String user = "root";
        private String password = "";
        private String database = "bd_cadastros";

        public void Conectar() {


            if (conn != null)
                conn.Close();

            string connStr = String.Format("server={0};user id={1}; password={2}; database={3}; pooling=false", server, user, password, database);
            try {
                conn = new MySqlConnection(connStr);
                conn.Open();
            } catch (MySqlException ex) {

                throw new Exception(ex.Message);
            }
        }
        public void ExecutarComandoSQL(string comandoSql) {
            MySqlCommand comando = new MySqlCommand(comandoSql, conn);
            comando.ExecuteNonQuery();
            conn.Close();
        }
        public DataTable RetDataTable(string sql) {
            data = new DataTable();
            da = new MySqlDataAdapter(sql, conn);
            cb = new MySqlCommandBuilder(da);
            da.Fill(data);

            return data;
        }
        public MySqlDataReader RetDataReader(string sql) {
            MySqlCommand comando = new MySqlCommand(sql, conn);
            MySqlDataReader dr = comando.ExecuteReader();
            dr.Read();
            return dr;
        }
    }
}
