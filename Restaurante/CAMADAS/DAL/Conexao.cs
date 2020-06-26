using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante.CAMADAS.DAL
{
    public Conexao
    {
        public static string getConexao()
        {
            return @"Data Source=.\SQLEXPRESS;Initial Catalog=restaurante;Integrated Security=True";
        }
    }
}
