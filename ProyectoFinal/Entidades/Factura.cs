using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace ProyectoFinal.Entidades
{
    public class Factura
    {
        [Key]

        public int FacturaId { get; set; }
        public int ClienteId { get; set; }
        public int GeneroId { get; set; }
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

        public void AgregarDetalle(int id, int FacturaId, int PeliculaId,int GeneroId,int ClienteId, int Precio)
        {
            this.Detalle.Add(new FacturaDetalle(id, FacturaId, PeliculaId, Precio));
        }
    }
}
