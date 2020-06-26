using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante.CAMADAS.BLL
{
    public class Categoria
    {
        public List<MODEL.Categoria> Select()
        {
            DAL.Categoria dalCat = new DAL.Categoria();
            return dalCat.Select();
        }

        public MODEL.Categoria SelectByID(int id)
        {
            DAL.Categoria dalCategoria = new DAL.Categoria();
            return dalCategoria.SelectByID(id);
        }

        public void Insert(MODEL.Categoria categoria)
        {

            DAL.Categoria dalCat = new DAL.Categoria();

            dalCat.Insert(categoria);
        }

        public void Update(MODEL.Categoria categoria)
        {
            DAL.Categoria dalCat = new DAL.Categoria();
            dalCat.Update(categoria);
        }

        public void Delete(int idCategoria)
        {
            DAL.Categoria dalCat = new DAL.Categoria();
            dalCat.Delete(idCategoria);
        }
    }
}
