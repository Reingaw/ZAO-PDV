using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZAO_PDV
{
     public class Sales
    {
         public DataTable salesperson(string param)
         {
             SqlCommand comandoSql = new SqlCommand();
             StringBuilder sql = new StringBuilder();
             DataTable dt = new DataTable();

             using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
             {
                 try
                 {
                     conexao.Open();
                     sql.Append(" SELECT salesperson_name FROM tb_salesperson ");
                     sql.Append(" WHERE salesperson_id = @param ");

                     comandoSql.Parameters.Add(new SqlParameter("@param", param));

                     comandoSql.CommandText = sql.ToString();
                     comandoSql.Connection = conexao;
                     dt.Load(comandoSql.ExecuteReader());

                     return dt;
                 }
                 catch (Exception)
                 {                     
                     throw new Exception("Não foi possivel consultar o vendedor! Caso o problema persista, contate o Administrador do sistema!");
                 }
             }
         }

         public DataTable customer(string param)
         {
             SqlCommand comandoSql = new SqlCommand();
             StringBuilder sql = new StringBuilder();
             DataTable dt = new DataTable();

             using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
             {
                 try
                 {
                     conexao.Open();
                     sql.Append(" SELECT tb_customer.customer_name, tb_customer.customer_phone, tb_adress.adress_street, tb_adress.adress_number,");
                     sql.Append(" tb_adress.adress_neigborhood, tb_adress.adress_complement, tb_adress.adress_reference, tb_adress.adress_observation");
                     sql.Append(" FROM (tb_customer INNER JOIN tb_adress ON tb_customer.customer_id = tb_adress.customer_id)");
                     sql.Append(" WHERE (tb_customer.customer_phone = @param OR tb_customer.customer_name LIKE +@param+ '%')");

                     comandoSql.Parameters.Add(new SqlParameter("@param", param));

                     comandoSql.CommandText = sql.ToString();
                     comandoSql.Connection = conexao;
                     dt.Load(comandoSql.ExecuteReader());

                     return dt;
                 }
                 catch (Exception)
                 {
                     throw new Exception("Não foi possivel consultar o cliente! Caso o problema persista, contate o Administrador do sistema!");
                 }
             }
         }
    }
}
