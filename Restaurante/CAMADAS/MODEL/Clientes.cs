using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante.CAMADAS.MODEL
{
    public class Clientes
    {
        public int id { get; set; }
        public string nome { get; set; }
        public DateTime nascimento { get; set; }
        public float telefone { get; set; }
        public string estado { get; set; }
        public string cidade { get; set; }
        public string rua { get; set; }
        public string endereco { get; set; }
        public float numero { get; set; }

    }
}
