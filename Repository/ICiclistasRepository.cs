using Ciclistas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ciclistas.Repository
{
    public interface ICiclistasRepository
    {
        List<Ciclista> SelectAllCiclistas();
        Ciclista SelectCiclistasById(int id);
        void InsertCiclistas(Ciclista cicli);
        void UpdateCiclistas(Ciclista cicli);
        void DeleteCiclistas(int id);
    }
}