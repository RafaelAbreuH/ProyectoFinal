using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace ProyectoFinal.Entidades
{
    public class Actores
    {
        [Key]

        public int ActoresId { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaNacimiento { get; set; }

        public Actores()
        {
            ActoresId = 0;
            Nombre = string.Empty;
            FechaNacimiento = DateTime.Now;
        }

        public override string ToString()
        {
            return Nombre;
        }
    }
}
