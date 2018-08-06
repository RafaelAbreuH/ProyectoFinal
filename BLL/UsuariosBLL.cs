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
    public class UsuariosBLL
    {
        public static bool Guardar(Usuario usuario)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {

                if (contexto.Usuario.Add(usuario) != null)
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
                Usuario usuario = contexto.Usuario.Find(id);

                if (usuario != null)
                {
                    contexto.Entry(usuario).State = EntityState.Deleted;
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



        public static bool Modificar(Usuario usuario)
        {

            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                contexto.Entry(usuario).State = EntityState.Modified;

                if (contexto.SaveChanges() > 0)
                {
                    paso = true;
                }
                contexto.Dispose();

            }
            catch (Exception) { throw; }

            return paso;
        }



        public static Usuario Buscar(int id)
        {

            Usuario usuario = new Usuario();
            Contexto contexto = new Contexto();

            try
            {
                usuario = contexto.Usuario.Find(id);
                contexto.Dispose();
            }
            catch (Exception) { throw; }

            return usuario;

        }

        public static List<Usuario> GetListTodo()
        {
            List<Usuario> lista = null;
            try
            {
                Contexto dbase = new Contexto();
                lista = dbase.Usuario.ToList();
            }
            catch (Exception)
            {

                throw;
            }
            return lista;
        }


        public static List<Usuario> GetList(Expression<Func<Usuario, bool>> expression)
        {
            List<Usuario> usuario = new List<Usuario>();
            Contexto contexto = new Contexto();

            try
            {
                usuario = contexto.Usuario.Where(expression).ToList();
                contexto.Dispose();

            }
            catch (Exception) { throw; }
            return usuario;
        }
    }
}
