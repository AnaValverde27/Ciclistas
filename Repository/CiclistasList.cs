using Ciclistas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ciclistas.Repository
{
    public class CiclistasList
    {
        static List<Ciclista> empList = null;
        static CiclistasList()
        {
            empList = new List<Ciclista>(){};
        }

        public static List<Ciclista> SelectCiclistasList()
        {
            return empList;
        }

        public static void InsertCiclistasList(Ciclista cicli)
        {
            empList.Add(cicli);
        }

        public static void UpdateCiclistasList(Ciclista cicli)
        {
            Ciclista cicliUpdate = empList.Find(x => x.Id == cicli.Id);
            cicliUpdate.Nombre = cicli.Nombre;
            cicliUpdate.Tiempo = cicli.Tiempo;
            cicliUpdate.Metros = cicli.Metros;
        }
        public static void DeleteCiclistasList(int id)
        {
            Ciclista cicliDelete = empList.Find(x => x.Id == id);
            empList.Remove(cicliDelete);
        }
    }
}