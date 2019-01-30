using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZAO_PDV
{
    public class Conexao
    {
        private static string conexao = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=zaopdv;Integrated Security=True";
        public static string stringConexao
        {
            get { return conexao; }
        }
    }
}
