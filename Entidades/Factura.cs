using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Factura
    {
        [Key]

        public int FacturaId { get; set; }
        public int ClienteId { get; set; }
        public int GeneroId { get; set; }
        public string Pelicula { get; set; }
        public int ActoresId { get; set; }
        public DateTime Fecha { get; set; }
        public int Precio { get; set; }
        public int Total { get; set; }
        public string Comentario { get; set; }

        public virtual ICollection<FacturaDetalle> Detalle { get; set; }

        public Factura()
        {
            FacturaId = 0;
            Fecha = DateTime.Now;
            Total = 0;
            Precio = 0;
            this.Detalle = new List<FacturaDetalle>();
        }

        public void AgregarDetalle(int Id, int facturaId, int clienteId, int peliculaId, string pelicula, int cantidad, decimal precio, decimal importe)
        {
            this.Detalle.Add(new FacturaDetalle(Id, facturaId, clienteId, peliculaId, pelicula, cantidad, precio, importe));
        }
    }
}
