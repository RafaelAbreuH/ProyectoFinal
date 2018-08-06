using BLL;
using Entidades;
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
    public partial class cGeneros : Form
    {
        public cGeneros()
        {
            InitializeComponent();
        }
        private List<Generos> generos = new List<Generos>();
        private void Consultabutton_Click(object sender, EventArgs e)
        {
            Expression<Func<Generos, bool>> filtro = c => true;
            int id;
            switch (FiltroComboBox.SelectedIndex)
            {
                case 0://Filtrando por ID.
                    id = Convert.ToInt32(CriterioTextBox.Text);
                    filtro = c => c.GeneroId == id;
                    break;
                case 1://Filtrando por Nombre.
                    filtro = c => c.Nombre.Contains(CriterioTextBox.Text);
                    break;

            }

            generos = GenerosBLL.GetList(filtro);
            ConsultaDataGridView.DataSource = generos;
        }
    }
}
