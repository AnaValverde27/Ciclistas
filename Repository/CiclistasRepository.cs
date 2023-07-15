using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ciclistas.Repository
{
    public class CiclistasRepository : ICiclistasRepository
    {
        public List<Models.Ciclista> SelectAllCiclistas()
        {
            return CiclistasList.SelectCiclistasList();
        }

        public Models.Ciclista SelectCiclistasById(int id)
        {
            return CiclistasList.SelectCiclistasList().Find(x => x.Id == id);
        }

        public void InsertCiclistas(Models.Ciclista cicli)
        {
            CiclistasList.InsertCiclistasList(cicli);
        }

        public void UpdateCiclistas(Models.Ciclista cicli)
        {
            CiclistasList.UpdateCiclistasList(cicli);
        }

        public void DeleteCiclistas(int id)
        {
            CiclistasList.DeleteCiclistasList(id);
        }
    }
}