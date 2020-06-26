using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante.CAMADAS.BLL
{
    public class CadastroProd
    {
        public List<MODEL.CadastroProd> Select()
        {
            DAL.CadastroProd dalCadP = new DAL.CadastroProd();
            return dalCadP.Select();
        }

        public MODEL.CadastroProd SelectByID(int id)
        {
            DAL.CadastroProd dalCadP = new DAL.CadastroProd();
            return dalCadP.SelectByID(id);
        }
        public MODEL.CadastroProd SelectByTipo(string tipo)
        {
            DAL.CadastroProd dalCadP = new DAL.CadastroProd();
;           return dalCadP.SelectByTipo(tipo);
        }

        public void Insert(MODEL.CadastroProd cadastroProd)
        {

            DAL.CadastroProd dalCadP = new DAL.CadastroProd();

            dalCadP.Insert(cadastroProd);
        }

        public void Update(MODEL.CadastroProd cadastroProd)
        {
            DAL.CadastroProd dalCadP = new DAL.CadastroProd();
            dalCadP.Update(cadastroProd);
        }

        public void Delete(int idCadastroProd)
        {
            DAL.CadastroProd dalCadP = new DAL.CadastroProd();
            dalCadP.Delete(idCadastroProd);
        }
    }
}
