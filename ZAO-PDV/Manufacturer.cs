using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZAO_PDV
{
    public class Manufacturer
    {
        public void salvar(string manufacturer)
        {
            try
            {
                SqlCommand comandoSql = new SqlCommand();
                StringBuilder sql = new StringBuilder();

                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    conexao.Open();
                    sql.Append(" INSERT INTO tb_manufacturer(manufacturer_name) ");

                    sql.Append(" VALUES (@manufacturer) ");

                    comandoSql.Parameters.Add(new SqlParameter("@manufacturer", manufacturer));

                    comandoSql.CommandText = sql.ToString();
                    comandoSql.Connection = conexao;
                    comandoSql.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {                
                throw new Exception ("Erro ao salvar os dados! Caso o problema persista, contate o Administrador do sistema!");
            }
        }

        public DataTable listar()
        {
            try
            {
                SqlCommand comandoSql = new SqlCommand();
                StringBuilder sql = new StringBuilder();
                DataTable dt = new DataTable();

                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    conexao.Open();
                    sql.Append(" SELECT manufacturer_name FROM tb_manufacturer");
                    sql.Append(" ORDER BY manufacturer_id DESC");

                    comandoSql.CommandText = sql.ToString();
                    comandoSql.Connection = conexao;
                    dt.Load(comandoSql.ExecuteReader());

                    return dt;
                }
            }
            catch (Exception)
            {
                throw new Exception("Erro ao listar todos os fabricantes! Caso o problema persista, contate o Administrador do sistema!");
            }
        }
    }
}
