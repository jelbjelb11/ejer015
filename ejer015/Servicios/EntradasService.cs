using ejer015.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ejer015.Servicios
{
    public class EntradasService : IEntradasService
    {
        //El ThreadStatic Hace que cada hilo me instance una nueva varible sin modificar la que tengo. Es decir, que los hilos no se pisen entre sí las variables estáticas
       // [ThreadStatic] public static ApplicationDbContext applicationDbContext;
        private IEntradasRepository entradasRepository;
        public EntradasService(IEntradasRepository _entradasRepository)
        {
            this.entradasRepository = _entradasRepository;
        }

        public Entrada Create(Entrada entrada)
        {
            using (var context = new ApplicationDbContext())
            {
         //       applicationDbContext = context;
                ApplicationDbContext.applicationDbContext = context;
                using (var dbContextTransaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        entrada = entradasRepository.Create(entrada);
                        context.SaveChanges();
                        dbContextTransaction.Commit();
                    }
                    catch (Exception e)
                    {
                        dbContextTransaction.Rollback();
                        //throw e;
                        //La "e" me va a mostrar la excepción original que incluye el número de línea donde se produce la excepción. Es importante mantenerla.
                        throw new Exception("He hecho rollback de la transacción", e);
                    }
                }
            }
            return entrada;
        }
    }
}