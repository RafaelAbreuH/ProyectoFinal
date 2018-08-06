using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Pelicula
    {
        [Key]

        public int PeliculaId { get; set; }
        public string Nombre { get; set; }
        public int Precio { get; set; }
        public DateTime FechaEstreno { get; set; }
        public string Introduccion { get; set; }
        public int GeneroId { get; set; }
        public int ActoresId { get; set; }
        public int Inventario { get; set; }

        public Pelicula()
        {
            PeliculaId = 0;
            Nombre = string.Empty;
            Precio = 0;
            FechaEstreno = DateTime.Now;
            Introduccion = string.Empty;
            Inventario = 0;

        }
    }
}
