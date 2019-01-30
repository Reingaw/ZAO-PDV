using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZAO_PDV
{
    public class Salesperson
    {
        public void salvar(string name, string function)
        {
            SqlCommand comandoSql = new SqlCommand();
            StringBuilder sql = new StringBuilder();

            using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
            {
                try
                {
                    conexao.Open();
                    sql.Append(" INSERT INTO tb_salesperson (salesperson_name, salesperson_function)");
                    sql.Append(" VALUES (@name, @function)");

                    comandoSql.Parameters.Add(new SqlParameter("@name", name));
                    comandoSql.Parameters.Add(new SqlParameter("@function", function));

                    comandoSql.CommandText = sql.ToString();
                    comandoSql.Connection = conexao;
                    comandoSql.ExecuteNonQuery();
                }
                catch (Exception)
                {                    
                    throw new Exception("Erro ao salvar os dados do vendedor! Se o problema persistir, contate o Administrador do sistema!");
                }
            }
        }

        public DataTable listar()
        {
            SqlCommand comandoSql = new SqlCommand();
            StringBuilder sql = new StringBuilder();
            DataTable dt = new DataTable();

            using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
            {
                try
                {
                    conexao.Open();
                    sql.Append(" SELECT salesperson_id, salesperson_name, salesperson_function");
                    sql.Append(" FROM tb_salesperson");
                    sql.Append(" ORDER BY salesperson_id");

                    comandoSql.CommandText = sql.ToString();
                    comandoSql.Connection = conexao;
                    dt.Load(comandoSql.ExecuteReader());

                    return dt;
                }
                catch (Exception)
                {
                    throw new Exception("Erro ao listar os dados do vendedor! Se o problema persistir, contate o Administrador do sistema!");
                }
            }
        }
    }
}
