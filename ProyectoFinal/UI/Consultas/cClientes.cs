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
    public partial class cClientes : Form
    {
        public cClientes()
        {
            InitializeComponent();
        }
        private List<Cliente> cliente = new List<Cliente>();

        private void Consultabutton_Click(object sender, EventArgs e)
        {
            Expression<Func<Cliente, bool>> filtro = c => true;
            int id;
            switch (FiltroComboBox.SelectedIndex)
            {
                case 0://Filtrando por ID.
                    id = Convert.ToInt32(CriterioTextBox.Text);
                    filtro = c => c.ClienteId == id;
                    break;
                case 1://Filtrando por Nombre.
                    filtro = c => c.Nombres.Contains(CriterioTextBox.Text);
                    break;
                case 2://Filtrando por Direccion.
                    filtro = c => c.Direccion.Contains(CriterioTextBox.Text);
                    break;
                case 3://Filtrando por Cedula.
                    filtro = c => c.Cedula.Contains(CriterioTextBox.Text);
                    break;
                case 4://Filtrando por Telefono.
                    filtro = c => c.Telefono.Contains(CriterioTextBox.Text);
                    break;
                case 5://Filtrando por Email.
                    filtro = c => c.Email.Contains(CriterioTextBox.Text);
                    break;
            }

            cliente = ClientesBLL.GetList(filtro);
            ConsultaDataGridView.DataSource = cliente;
        }

        private void ReporteButton_Click(object sender, EventArgs e)
        {

        }
    }
}
