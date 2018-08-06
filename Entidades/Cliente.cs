using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Cliente
    {
        [Key]

        public int ClienteId { get; set; }
        public string Nombres { get; set; }
        public string Direccion { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string Cedula { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }

        public Cliente()
        {
            ClienteId = 0;
            Nombres = string.Empty;
            Direccion = string.Empty;
            FechaRegistro = DateTime.Now;
            Cedula = string.Empty;
            Telefono = string.Empty;
            Email = string.Empty;
        }

        public override string ToString()
        {
            return Nombres;
        }
    }
}
