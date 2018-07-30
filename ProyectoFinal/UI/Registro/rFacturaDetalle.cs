using ProyectoFinal.BLL;
using ProyectoFinal.DAL;
using ProyectoFinal.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal.UI.Registro
{
    public partial class rFacturaDetalle : Form
    {
        public rFacturaDetalle()
        {
            InitializeComponent();
            LlenarComboBox();
        }

        private int ToInt(object valor)
        {
            int retorno = 0;
            int.TryParse(valor.ToString(), out retorno);

            return retorno;
        }


        private void LlenarComboBox()
        {
            Repositorio<Cliente> CliRepositorio = new Repositorio<Cliente>(new Contexto());
            Repositorio<Pelicula> ProRepositorio = new Repositorio<Pelicula>(new Contexto());

            ClienteComboBox.DataSource = CliRepositorio.GetList(c => true);
            ClienteComboBox.ValueMember = "ClienteId";
            ClienteComboBox.DisplayMember = "Nombres";
            PeliculaComboBox.DataSource = ProRepositorio.GetList(c => true);
            PeliculaComboBox.ValueMember = "PeliculaId";
            PeliculaComboBox.DisplayMember = "Nombre";
        }

        private void LlenaCampos(Factura factura)
        {
            FacturaIdNumericUpDown.Value = factura.FacturaId;
            ClienteComboBox.SelectedValue = factura.ClienteId;
            FechaDateTimePicker.Value = factura.Fecha;
            //    ItbisTextBox.Text = factura.Itbis.ToString();
            TotalTextBox.Text = factura.Total.ToString();
            ComentarioTextBox.Text = factura.Comentario;

            DetalleDataGridView.DataSource = factura.Detalle;

            DetalleDataGridView.Columns["Id"].Visible = false;
            DetalleDataGridView.Columns["FacturaId"].Visible = false;
        }

        private Factura LlenaClase()
        {
            Factura factura = new Factura();

            factura.FacturaId = Convert.ToInt32(FacturaIdNumericUpDown.Value);
            factura.ClienteId = Convert.ToInt32(ClienteComboBox.SelectedValue);
            factura.Fecha = FechaDateTimePicker.Value;
          //factura.Itbis = Convert.ToSingle(ItbisTextBox.Text);
            factura.Total = Convert.ToInt32(TotalTextBox.Text);

            foreach (DataGridViewRow item in DetalleDataGridView.Rows)
            {
                factura.AgregarDetalle(
                    ToInt(item.Cells["Id"].Value),
                    ToInt(item.Cells["FacturaId"].Value),
                    ToInt(item.Cells["PeliculaId"].Value),
                    ToInt(item.Cells["Precio"].Value),
                    ToInt(item.Cells["GeneroId"].Value),
                    ToInt(item.Cells["ActorId"].Value)
                );
            }

            DetalleDataGridView.Columns["Id"].Visible = false;
            DetalleDataGridView.Columns["FacturaId"].Visible = false;

            return factura;
        }

        private void Limpiar()
        {
            FacturaIdNumericUpDown.Value = 0;
            FechaDateTimePicker.Value = DateTime.Now;
            ClienteComboBox.SelectedIndex = 0;
            PeliculaComboBox.SelectedIndex = 0;
            PrecioTextBox.Clear();
            DetalleDataGridView.DataSource = null;
            //   ItbisTextBox.Clear();
            TotalTextBox.Clear();
            ErrorProvider.Clear();
        }

        private bool HayErrores()
        {
            bool HayErrores = false;

            if (DetalleDataGridView.RowCount == 0)
            {
                ErrorProvider.SetError(DetalleDataGridView,
                    "Debe Agregar los Productos ");
                HayErrores = true;
            }

            return HayErrores;
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(FacturaIdNumericUpDown.Value);
            Factura factura = BLL.FacturaBLL.Buscar(id);

            if (factura != null)
            {
                LlenaCampos(factura);

            }
            else
                MessageBox.Show("No se encontro!", "Fallo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void PeliculaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Pelicula precio = (Pelicula)PeliculaComboBox.SelectedItem;
            PrecioTextBox.SelectedText = precio.Precio.ToString();
        }

        private void AgregarButton_Click(object sender, EventArgs e)
        {
            List<FacturaDetalle> detalle = new List<FacturaDetalle>();

            if (DetalleDataGridView.DataSource != null)
            {
                detalle = (List<FacturaDetalle>)DetalleDataGridView.DataSource;
            }
            else
            {
                detalle.Add(new FacturaDetalle(
                       id: (int) 0,
                       facturaId: (int)FacturaIdNumericUpDown.Value,
                       peliculaId: (int)PeliculaComboBox.SelectedValue,
                       pelicula: (string)BLL.PeliculasBLL.RetornarNombre(PeliculaComboBox.Text),
                       precio: (int)Convert.ToInt32(PrecioTextBox.Text)
               ));
                int Total = 0;
                DetalleDataGridView.DataSource = null;
                DetalleDataGridView.DataSource = detalle;

                DetalleDataGridView.Columns["Id"].Visible = false;
                DetalleDataGridView.Columns["GeneroId"].Visible = false;
                DetalleDataGridView.Columns["ActoresId"].Visible = false;
                
                DetalleDataGridView.Columns["FacturaId"].Visible = false;

                foreach (var item in detalle)
                {
                    Total += item.Precio;
                }
                TotalTextBox.Text = Total.ToString();

            }
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {

        }
    }
}
