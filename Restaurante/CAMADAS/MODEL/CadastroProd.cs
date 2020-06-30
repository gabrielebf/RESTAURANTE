using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante.CAMADAS.MODEL
{
    public class CadastroProd
    {
        public int id { get; set; }
        public string tipo { get; set; }
        public float preco { get; set; }
        //public float desconto { get; set; }
        public string observacao { get; set; }
        public int categoriaId { get; set; }

    }
}
