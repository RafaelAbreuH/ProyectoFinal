using DAL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace BLL
{
    public class ActoresBLL
    {
        public static bool Guardar(Actores actores)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {

                if (contexto.Actores.Add(actores) != null)
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
                Actores actores = contexto.Actores.Find(id);

                if (actores != null)
                {
                    contexto.Entry(actores).State = EntityState.Deleted;
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

        public static bool Modificar(Actores actores)
        {

            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                contexto.Entry(actores).State = EntityState.Modified;

                if (contexto.SaveChanges() > 0)
                {
                    paso = true;
                }
                contexto.Dispose();

            }
            catch (Exception) { throw; }

            return paso;
        }

        public static Actores Buscar(int id)
        {

            Actores actores = new Actores();
            Contexto contexto = new Contexto();

            try
            {
                actores = contexto.Actores.Find(id);
                contexto.Dispose();
            }
            catch (Exception) { throw; }

            return actores;

        }

        public static List<Actores> GetList(Expression<Func<Actores, bool>> expression)
        {
            List<Actores> actores = new List<Actores>();
            Contexto contexto = new Contexto();

            try
            {
                actores = contexto.Actores.Where(expression).ToList();
                contexto.Dispose();

            }
            catch (Exception) { throw; }
            return actores;
        }
    }
}
