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
    public partial class cUsuario : Form
    {
        public cUsuario()
        {
            InitializeComponent();
        }
        private List<Usuario> usuario = new List<Usuario>();

        private void Consultabutton_Click(object sender, EventArgs e)
        {
            Expression<Func<Usuario, bool>> filtro = c => true;
            int id;
            switch (FiltroComboBox.SelectedIndex)
            {
                case 0://Filtrando por ID.
                    id = Convert.ToInt32(CriterioTextBox.Text);
                    filtro = u => u.UsuarioId == id;
                    break;
                case 1://Filtrando por Nombre.
                    filtro = u => u.Nombre.Contains(CriterioTextBox.Text);
                    break;
                case 2://Filtrando por Username.
                    filtro = u => u.Username.Equals(CriterioTextBox.Text);
                    break;
                case 3://Filtrando por Telefono.
                    filtro = u => u.Telefono.Equals(CriterioTextBox.Text);
                    break;
                case 4://Filtrando por Email del Usuario.
                    filtro = u => u.Email.Equals(CriterioTextBox.Text);
                    break;
            }

            usuario = UsuariosBLL.GetList(filtro);
            ConsultaDataGridView.DataSource = usuario;
        }

        private void ReporteButton_Click(object sender, EventArgs e)
        {

        }
    }
}
