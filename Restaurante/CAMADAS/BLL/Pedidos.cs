using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante.CAMADAS.BLL
{
    public class Pedidos
    {
        public List<MODEL.Pedidos> Select()
        {
            DAL.Pedidos dalPed = new DAL.Pedidos();
            return dalPed.Select();
        }

        public void Insert(MODEL.Pedidos pedidos)
        {
            DAL.Pedidos dalPed = new DAL.Pedidos();

            if (pedidos.pedido != String.Empty)
                dalPed.Insert(pedidos);
        }

        public void Update(MODEL.Pedidos pedidos)
        {
            DAL.Pedidos dalPed = new DAL.Pedidos();
            dalPed.Update(pedidos);
        }

        public void Delete(int idPedidos)
        {
            DAL.Pedidos dalPed = new DAL.Pedidos();
            dalPed.Delete(idPedidos);
        }
    }
}
