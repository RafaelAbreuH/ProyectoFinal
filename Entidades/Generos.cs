using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Generos
    {
        [Key]

        public int GeneroId { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        public Generos()
        {
            GeneroId = 0;
            Nombre = string.Empty;
            Descripcion = string.Empty;
        }

        public override string ToString()
        {
            return Nombre;
        }
    }
}
