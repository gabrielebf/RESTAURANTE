using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante.CAMADAS.MODEL
{
    public class Pedidos
    {
        public int id { get; set; }
        public string descricao { get; set; }
        public string pedido { get; set; }
        public string bebidas { get; set; }
        public string endereco { get; set; }
        public float valor { get; set; }
        public int quantidade { get; set; }
        public int clienteId { get; set; }

    }
}
