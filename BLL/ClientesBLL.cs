﻿using DAL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace BLL
{
    public class ClientesBLL
    {
        public static bool Guardar(Cliente cliente)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {

                if (contexto.Cliente.Add(cliente) != null)
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
                Cliente cliente = contexto.Cliente.Find(id);

                if (cliente != null)
                {
                    contexto.Entry(cliente).State = EntityState.Deleted;
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



        public static bool Modificar(Cliente cliente)
        {

            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                contexto.Entry(cliente).State = EntityState.Modified;

                if (contexto.SaveChanges() > 0)
                {
                    paso = true;
                }
                contexto.Dispose();

            }
            catch (Exception) { throw; }

            return paso;
        }

        public static Cliente Buscar(int id)
        {

            Cliente cliente = new Cliente();
            Contexto contexto = new Contexto();

            try
            {
                cliente = contexto.Cliente.Find(id);
                contexto.Dispose();
            }
            catch (Exception) { throw; }

            return cliente;

        }

        public static List<Cliente> GetList(Expression<Func<Cliente, bool>> expression)
        {
            List<Cliente> cliente = new List<Cliente>();
            Contexto contexto = new Contexto();

            try
            {
                cliente = contexto.Cliente.Where(expression).ToList();
                contexto.Dispose();

            }
            catch (Exception) { throw; }
            return cliente;
        }
    }
}
