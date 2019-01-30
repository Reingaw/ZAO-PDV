using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZAO_PDV
{
    public class User
    {
        public void salvar(string name, string level, string pass)
        {
            SqlCommand comandoSql = new SqlCommand();
            StringBuilder sql = new StringBuilder();

            using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
            {
                conexao.Open();
                sql.Append(" INSERT INTO tb_user (user_name, user_level, user_password)");
                sql.Append(" VALUES (@name, @level, @pass)");

                comandoSql.Parameters.Add(new SqlParameter("@name", name));
                comandoSql.Parameters.Add(new SqlParameter("@level", level));
                comandoSql.Parameters.Add(new SqlParameter("@pass", pass));

                comandoSql.CommandText = sql.ToString();
                comandoSql.Connection = conexao;
                comandoSql.ExecuteNonQuery();
            }
        }
    }
}
