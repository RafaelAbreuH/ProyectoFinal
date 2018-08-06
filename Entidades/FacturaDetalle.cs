using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class FacturaDetalle
    {
        [Key]

        public int Id { get; set; }
        public int FacturaId { get; set; }
        public int PeliculaId { get; set; }
        public int ClienteId { get; set; }
        public string Pelicula { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio { get; set; }
        public decimal Importe { get; set; }

        [ForeignKey("PeliculaId")]
        public virtual Pelicula pelicula { get; set; }


        public FacturaDetalle(int Id, int FacturaId, int ClienteId, int PeliculaId, string Pelicula, int Cantidad, decimal Precio, decimal Importe)
        {
            this.Id = Id;
            this.FacturaId = FacturaId;
            this.ClienteId = ClienteId;
            this.PeliculaId = PeliculaId;
            this.Pelicula = Pelicula;
            this.Cantidad = Cantidad;
            this.Precio = Precio;
            this.Importe = Importe;
        }
    }
}
