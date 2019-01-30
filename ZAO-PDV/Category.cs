using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZAO_PDV
{
    public class Category
    {
        public void salvar(string category)
        {
            try
            {
                SqlCommand comandoSql = new SqlCommand();
                StringBuilder sql = new StringBuilder();

                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    conexao.Open();
                    sql.Append(" INSERT INTO tb_category (category_name) ");

                    sql.Append(" VALUES (@category) ");

                    comandoSql.Parameters.Add(new SqlParameter("@category", category));

                    comandoSql.CommandText = sql.ToString();
                    comandoSql.Connection = conexao;
                    comandoSql.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
                throw new Exception("Erro ao salvar os dados! Caso o problema persista, contate o Administrador do sistema!");
            }
        }

        public DataTable listar()
        {
            try
            {
                SqlCommand comandoSql = new SqlCommand();
                StringBuilder sql = new StringBuilder();
                DataTable dt = new DataTable();

                using(SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    conexao.Open();
                    sql.Append(" SELECT category_name FROM tb_category");
                    sql.Append(" ORDER BY category_id DESC");

                    comandoSql.CommandText = sql.ToString();
                    comandoSql.Connection = conexao;
                    dt.Load(comandoSql.ExecuteReader());

                    return dt;
                }
            }
            catch (Exception)
            {                
                throw new Exception("Erro ao listar todas as categorias! Caso o problema persista, contate o Administrador do sistema!");
            }
        }
    }
}
