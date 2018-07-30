using ProyectoFinal.DAL;
using ProyectoFinal.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace ProyectoFinal.BLL
{
    public class PeliculasBLL
    {
        public static bool Guardar(Pelicula pelicula)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {

                if (contexto.Pelicula.Add(pelicula) != null)
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
                Pelicula pelicula = contexto.Pelicula.Find(id);

                if (pelicula != null)
                {
                    contexto.Entry(pelicula).State = EntityState.Deleted;
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



        public static bool Modificar(Pelicula pelicula)
        {

            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                contexto.Entry(pelicula).State = EntityState.Modified;

                if (contexto.SaveChanges() > 0)
                {
                    paso = true;
                }
                contexto.Dispose();

            }
            catch (Exception) { throw; }

            return paso;
        }



        public static Pelicula Buscar(int id)
        {

            Pelicula pelicula = new Pelicula();
            Contexto contexto = new Contexto();

            try
            {
                pelicula = contexto.Pelicula.Find(id);
                contexto.Dispose();
            }
            catch (Exception) { throw; }

            return pelicula;

        }



        public static List<Pelicula> GetList(Expression<Func<Pelicula, bool>> expression)
        {
            List<Pelicula> pelicula = new List<Pelicula>();
            Contexto contexto = new Contexto();

            try
            {
                pelicula = contexto.Pelicula.Where(expression).ToList();
                contexto.Dispose();

            }
            catch (Exception) { throw; }
            return pelicula;
        }

        public static string RetornarNombre(string nombre)
        {
            string descripcion = string.Empty;
            var lista = GetList(x => x.Nombre.Equals(nombre));
            foreach (var item in lista)
            {
                descripcion = item.Nombre;
            }

            return descripcion;
        }
    }
}
