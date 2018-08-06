using ProyectoFinal.UI.Registro;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void actoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rActores ver = new rActores();
            ver.MdiParent = this;
            ver.Show();
        }

        private void generosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rGeneros ver = new rGeneros();
            ver.MdiParent = this;
            ver.Show();
        }

        private void peliculaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rPeliculas ver = new rPeliculas();
            ver.MdiParent = this;
            ver.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rClientes ver = new rClientes();
            ver.MdiParent = this;
            ver.Show();
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rUsuario ver = new rUsuario();
            ver.MdiParent = this;
            ver.Show();
        }

        private void facturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rFacturaDetalle ver = new rFacturaDetalle();
            ver.MdiParent = this;
            ver.Show();
        }

        private void entradaPeliculaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rEntradaPelicula ver = new rEntradaPelicula();
            ver.MdiParent = this;
            ver.Show();
        }
    }
}