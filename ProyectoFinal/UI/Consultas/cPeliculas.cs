using ProyectoFinal.BLL;
using ProyectoFinal.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal.UI.Consultas
{
    public partial class cPeliculas : Form
    {
        public cPeliculas()
        {
            InitializeComponent();
        }
        private List<Pelicula> pelicula = new List<Pelicula>();
        private void Consultabutton_Click(object sender, EventArgs e)
        {
            Expression<Func<Pelicula, bool>> filtro = f => true;
            int id;
            switch (FiltroComboBox.SelectedIndex)
            {
                case 0://Filtrando por ID de la Factura.
                    id = Convert.ToInt32(CriterioTextBox.Text);
                    filtro = f => f.PeliculaId == id;
                    break;
                case 1://Filtrando por la Fecha estreno de la Pelicula.
                    filtro = f => f.FechaEstreno >= DesdeDateTimePicker.Value.Date && f.FechaEstreno <= HastaDateTimePicker.Value.Date;
                    break;
                case 4://Filtrando por Nombre.
                    filtro = f => f.Nombre.Contains(CriterioTextBox.Text);
                    break;
                case 6://Filtrando por Precio.
                    filtro = f => f.Precio.Equals(CriterioTextBox.Text);
                    break;
            }

            pelicula = PeliculasBLL.GetList(filtro);
            ConsultaDataGridView.DataSource = pelicula;
        }

        private void ReporteButton_Click(object sender, EventArgs e)
        {

        }
    }
}
