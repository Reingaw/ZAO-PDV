using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZAO_PDV
{
    public class Adress
    {
        public void salvar(string street, string number, string neigborhood, string complement,
                            string reference, string observation, int id)
        {
            try
            {
                SqlCommand comandoSql = new SqlCommand();
                StringBuilder sql = new StringBuilder();

                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    conexao.Open();
                    sql.Append(" INSERT INTO tb_adress(adress_street, adress_number, adress_neigborhood, ");
                    sql.Append(" adress_complement, adress_reference, adress_observation, customer_id) ");
                    sql.Append(" VALUES (@street, @number, @neigborhood, @complement,");
                    sql.Append(" @reference, @observation, @id) ");
                                        

                    comandoSql.Parameters.Add(new SqlParameter("@street", street));
                    comandoSql.Parameters.Add(new SqlParameter("@number", number));
                    comandoSql.Parameters.Add(new SqlParameter("@neigborhood", neigborhood));
                    comandoSql.Parameters.Add(new SqlParameter("@complement", complement));
                    comandoSql.Parameters.Add(new SqlParameter("@reference", reference));
                    comandoSql.Parameters.Add(new SqlParameter("@observation", observation));
                    comandoSql.Parameters.Add(new SqlParameter("@id", id));

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
    }
}
