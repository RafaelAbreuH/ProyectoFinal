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
    public partial class cActores : Form
    {
        public cActores()
        {
            InitializeComponent();
        }
        private List<Actores> actores = new List<Actores>();

        private void Consultabutton_Click(object sender, EventArgs e)
        {
            Expression<Func<Actores, bool>> filtro = c => true;
            int id;
            switch (FiltroComboBox.SelectedIndex)
            {
                case 0://Filtrando por ID del Actor
                    id = Convert.ToInt32(CriterioTextBox.Text);
                    filtro = c => c.ActoresId == id;
                    break;
                case 1://Filtrando por Nombres del actor.
                    filtro = c => c.Nombre.Contains(CriterioTextBox.Text);
                    break;
            }

            actores = ActoresBLL.GetList(filtro);
            ConsultaDataGridView.DataSource = actores;
        }

        private void ReporteButton_Click(object sender, EventArgs e)
        {

        }
    }
}
