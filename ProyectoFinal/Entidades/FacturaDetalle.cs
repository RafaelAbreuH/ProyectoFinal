using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace ProyectoFinal.Entidades
{
    public class FacturaDetalle
    {
        [Key]

        public int Id { get; set; }
        public int FacturaId { get; set; }
        public int PeliculaId { get; set; }
        public int GeneroId { get; set; }
        public int ActoresId { get; set; }
        public string Pelicula { get; set; }
        public int Precio { get; set; }

        [ForeignKey("GeneroId")]
        public virtual Generos Generos { get; set; }

        [ForeignKey("ActoresId")]
        public virtual Actores Actores { get; set; }

        public FacturaDetalle(int id, int facturaId, int peliculaId,string pelicula, int precio)
        {
            Id = id;
            FacturaId = facturaId;
            PeliculaId = peliculaId;
            Pelicula = pelicula;
            Precio = precio;
        }

        public FacturaDetalle(int facturaId, int peliculaId, int generoId, int actoresId, int precio, Generos generos, Actores actores) : this(facturaId, peliculaId, generoId, actoresId)
        {
            Precio = precio;
            Generos = generos;
            Actores = actores;
        }
    }
}
