using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace ProyectoFinal.Entidades
{
    public class Usuario
    {
        [Key]

        public int UsuarioId { get; set; }
        public string Nombre { get; set; }
        public string Username { get; set; }
        public string Passwordd { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }

        public Usuario()
        {
            UsuarioId = 0;
            Nombre = string.Empty;
            Username = string.Empty;
            Passwordd = string.Empty;
            Telefono = string.Empty;
            Email = string.Empty;
        }
    }
}
