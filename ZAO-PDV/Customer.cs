using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZAO_PDV
{
    public class Customer
    {
        public void salvar(string phone, string name, string date)
        {
            try 
	        {
                SqlCommand comandoSql = new SqlCommand();
                StringBuilder sql = new StringBuilder();

                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    conexao.Open();
                    sql.Append(" INSERT INTO tb_customer (customer_phone, customer_name, customer_register_date)");
                    
                    sql.Append(" VALUES (@phone, @name, @date)");

                    comandoSql.Parameters.Add(new SqlParameter("@phone", phone));
                    comandoSql.Parameters.Add(new SqlParameter("@name", name));
                    comandoSql.Parameters.Add(new SqlParameter("@date", date));

                    comandoSql.CommandText = sql.ToString();
                    comandoSql.Connection = conexao;
                    comandoSql.ExecuteNonQuery();
                }
            }
	        catch (Exception)
	        {		
		        throw new Exception ("Erro ao salvar os dados na tabela cliente! Caso o problema persista, contate o Administrador do sistema!");
	        }
        }

        public DataTable retornaId(string telefone)
        {
            SqlCommand comandoSql = new SqlCommand();
            StringBuilder sql = new StringBuilder();
            DataTable dadosID = new DataTable();

            using(SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
            {
                try 
	            {	        
		            conexao.Open();
                    sql.Append(" SELECT customer_id FROM tb_customer");
                    sql.Append(" WHERE customer_phone = @phone ");

                    comandoSql.Parameters.Add(new SqlParameter("@phone", telefone));

                    comandoSql.CommandText = sql.ToString();
                    comandoSql.Connection = conexao;
                    dadosID.Load(comandoSql.ExecuteReader());

                    return dadosID;

	            }
	            catch (Exception)
	            {
                    throw new Exception("Erro ao retornar o ID! Caso o problema persista, contate o Administrador do sistema!");
	            }
            }
        }

        public DataTable pesquisarCliente(string param)
        {
            try
            {
                SqlCommand comandoSql = new SqlCommand();
                StringBuilder sql = new StringBuilder();
                DataTable dadosPesquisa = new DataTable();

                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    conexao.Open();
                    sql.Append(" SELECT tb_customer.customer_name, tb_customer.customer_phone,");
                    sql.Append(" tb_adress.adress_street, tb_adress.adress_neigborhood");
                    sql.Append(" FROM (tb_customer INNER JOIN tb_adress ON tb_adress.customer_id = tb_customer.customer_id)");
                    sql.Append(" WHERE (tb_customer.customer_phone = @param OR tb_customer.customer_name LIKE @param+ '%')");
                    sql.Append(" ORDER BY tb_adress.adress_id DESC");

                    comandoSql.Parameters.Add(new SqlParameter("@param", param));

                    comandoSql.CommandText = sql.ToString();
                    comandoSql.Connection = conexao;
                    dadosPesquisa.Load(comandoSql.ExecuteReader());

                    return dadosPesquisa;
                }
            }
            catch (Exception)
            {

                throw new Exception("Erro ao pesquisar os dados! Caso o problema persista, contate o Administrador do sistema!");
            }
        }
    }
}
