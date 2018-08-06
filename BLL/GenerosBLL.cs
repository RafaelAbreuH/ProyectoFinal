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
    public class GenerosBLL
    {
        public static bool Guardar(Generos generos)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {

                if (contexto.Generos.Add(generos) != null)
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
                Generos generos = contexto.Generos.Find(id);

                if (generos != null)
                {
                    contexto.Entry(generos).State = EntityState.Deleted;
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

        public static bool Modificar(Generos generos)
        {

            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                contexto.Entry(generos).State = EntityState.Modified;

                if (contexto.SaveChanges() > 0)
                {
                    paso = true;
                }
                contexto.Dispose();

            }
            catch (Exception) { throw; }

            return paso;
        }

        public static Generos Buscar(int id)
        {

            Generos generos = new Generos();
            Contexto contexto = new Contexto();

            try
            {
                generos = contexto.Generos.Find(id);
                contexto.Dispose();
            }
            catch (Exception) { throw; }

            return generos;

        }

        public static List<Generos> GetList(Expression<Func<Generos, bool>> expression)
        {
            List<Generos> generos = new List<Generos>();
            Contexto contexto = new Contexto();

            try
            {
                generos = contexto.Generos.Where(expression).ToList();
                contexto.Dispose();

            }
            catch (Exception) { throw; }
            return generos;
        }
    }
}
