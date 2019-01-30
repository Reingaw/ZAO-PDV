using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZAO_PDV
{
    public class Product
    {
        public void salvar(string description, string category, string manufacturer,
                             float costPrice, float sellPrice, int stock, string codebar)
        {
            try
            {
                SqlCommand comandoSql = new SqlCommand();
                StringBuilder sql = new StringBuilder();

                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    conexao.Open();
                    sql.Append( "INSERT INTO tb_product( product_description, product_category, product_manufacturer, ");
                    sql.Append( "product_cost_price, product_sell_price, product_stock, product_codebar)" );

                    sql.Append( "VALUES (@description, @category, @manufacturer, @costPrice, @sellPrice, @stock, @codebar)" );

                    comandoSql.Parameters.Add(new SqlParameter("@description", description));
                    comandoSql.Parameters.Add(new SqlParameter("@category", category));
                    comandoSql.Parameters.Add(new SqlParameter("@manufacturer", manufacturer));
                    comandoSql.Parameters.Add(new SqlParameter("@costPrice", costPrice));
                    comandoSql.Parameters.Add(new SqlParameter("@sellPrice", sellPrice));
                    comandoSql.Parameters.Add(new SqlParameter("@stock", stock));
                    comandoSql.Parameters.Add(new SqlParameter("@codebar", codebar));

                    comandoSql.CommandText = sql.ToString();
                    comandoSql.Connection = conexao;
                    comandoSql.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {                
                throw new Exception("Erro ao salvar os dados do produto! Se o problema persistir, contate o Administrador do sistema!");
            }
        }

        public DataTable listar(string param)
        {
            try
            {
                SqlCommand comandoSql = new SqlCommand();
                StringBuilder sql = new StringBuilder();
                DataTable dt = new DataTable();

                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    conexao.Open();
                    sql.Append(" SELECT product_description, product_category, product_sell_price, product_stock");
                    sql.Append(" FROM tb_product ");
                    sql.Append(" WHERE (product_codebar = @param OR product_description LIKE @param+ '%')");

                    comandoSql.Parameters.Add(new SqlParameter("@param", param));

                    comandoSql.CommandText = sql.ToString();
                    comandoSql.Connection = conexao;
                    dt.Load(comandoSql.ExecuteReader());

                    return dt;
                }
            }
            catch (Exception)
            {
                throw new Exception("Erro ao listar os dados do produto! Se o problema persistir, contate o Administrador do sistema!");
            }
        }
    }
}
