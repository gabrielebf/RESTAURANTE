using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante.CAMADAS.MODEL
{
    class CadastroProd
    {
        public int id { get; set; }
        public string tipo { get; set; }
        public float MyProperty { get; set; }
        public float desconto { get; set; }
        public float ano { get; set; }
        public float observacao { get; set; }

    }
}
