using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante.CAMADAS.BLL
{
    public class Clientes
    {
        public List<MODEL.Clientes> Select()
        {
            DAL.Clientes dalCli = new DAL.Clientes();
            return dalCli.Select();
        }

        public MODEL.Clientes SelectByID(int id)
        {
            DAL.Clientes dalCli = new DAL.Clientes();
            return dalCli.SelectByID(id);
        }

        public MODEL.Clientes SelectByNome(string nome)
        {
            DAL.Clientes dalCli = new DAL.Clientes();
            return dalCli.SelectByNome(nome);
        }

        public void Insert(MODEL.Clientes clientes)
        {
            DAL.Clientes dalCli = new DAL.Clientes();
            if (clientes.nome != String.Empty)
                dalCli.Insert(clientes);
        }

        public void Update(MODEL.Clientes clientes)
        {
            DAL.Clientes dalCli = new DAL.Clientes();
            dalCli.Update(clientes);
        }

        public void Delete(int idClientes)
        {
            DAL.Clientes dalCli = new DAL.Clientes();
            dalCli.Delete(idClientes);
        }
    }
}
