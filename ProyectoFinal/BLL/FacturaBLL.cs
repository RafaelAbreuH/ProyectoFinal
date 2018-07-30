using ProyectoFinal.DAL;
using ProyectoFinal.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.BLL
{
    public class FacturaBLL
    {
        public static bool Guardar(Factura factura)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {

                if (contexto.Factura.Add(factura) != null)
                {
                    contexto.SaveChanges();
                    paso = true;
                }
                contexto.Dispose();

            }
            catch (Exception) { throw; }

            return paso;
        }

        public static bool Eliminar(int id)
        {

            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                Factura factura = contexto.Factura.Find(id);

                if (factura != null)
                {
                    contexto.Entry(factura).State = EntityState.Deleted;
                }

                if (contexto.SaveChanges() > 0)
                {
                    paso = true;
                    contexto.Dispose();
                }


            }
            catch (Exception) { throw; }

            return paso;
        }

        public static bool Modificar(Factura factura)
        {

            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                contexto.Entry(factura).State = EntityState.Modified;

                if (contexto.SaveChanges() > 0)
                {
                    paso = true;
                }
                contexto.Dispose();

            }
            catch (Exception) { throw; }

            return paso;
        }

        public static Factura Buscar(int id)
        {

            Factura factura = new Factura();
            Contexto contexto = new Contexto();

            try
            {
                factura = contexto.Factura.Find(id);
                contexto.Dispose();
            }
            catch (Exception) { throw; }

            return factura;

        }

        public static List<Factura> GetList(Expression<Func<Factura, bool>> expression)
        {
            List<Factura> factura = new List<Factura>();
            Contexto contexto = new Contexto();

            try
            {
                factura = contexto.Factura.Where(expression).ToList();
                contexto.Dispose();

            }
            catch (Exception) { throw; }
            return factura;
        }
    }
}
