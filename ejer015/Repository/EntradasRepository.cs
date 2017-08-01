using ejer015.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ejer015.Repository
{
    public class EntradasRepository : IEntradasRepository
    {
        public Entrada Create(Entrada entrada)
        {
            //     return EntradasService.applicationDbContext.Entradas.Add(entrada);
            return AppicationDbContext.applicationDbContext.Entradas.Add(entrada);
        }
    }
}