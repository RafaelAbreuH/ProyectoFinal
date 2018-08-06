using BLL;
using Entidades;
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
    public partial class rClientes : Form
    {
        public rClientes()
        {
            InitializeComponent();
        }

        private Cliente LlenarClase()
        {
            Cliente cliente = new Cliente();

            cliente.ClienteId = Convert.ToInt32(ClienteIdNumericUpDown.Value);
            cliente.Nombres = NombresTextBox.Text;
            cliente.Telefono = TelefonoMaskedTextBox.Text;
            cliente.Cedula = CedulaMaskedTextBox.Text;
            cliente.Email = EmailTextBox.Text;
            cliente.Direccion = DireccionTextBox.Text;

            return cliente;
        }

        private void Limpiar()
        {
            ClienteIdNumericUpDown.Value = 0;
            NombresTextBox.Clear();
            TelefonoMaskedTextBox.Clear();
            CedulaMaskedTextBox.Clear();
            DireccionTextBox.Clear();
            EmailTextBox.Clear();
            ErrorProvider.Clear();
        }

        private bool HayErrores()
        {
            bool paso = false;

            if (String.IsNullOrEmpty(NombresTextBox.Text))
            {
                ErrorProvider.SetError(NombresTextBox,
                    "Ingrese el Nombre del cliente!");
                paso = true;
            }
            if (String.IsNullOrEmpty(TelefonoMaskedTextBox.Text))
            {
                ErrorProvider.SetError(TelefonoMaskedTextBox,
                    "Ingrese el Número de Teléfono para el cliente!");
                paso = true;
            }
            if (String.IsNullOrEmpty(CedulaMaskedTextBox.Text))
            {
                ErrorProvider.SetError(CedulaMaskedTextBox,
                    "Ingrese el Número de Cédula de el cliente!");
                paso = true;
            }
            if (String.IsNullOrEmpty(EmailTextBox.Text))
            {
                ErrorProvider.SetError(EmailTextBox,
                    "Ingrese el email del cliente!");
                paso = true;
            }
            if (String.IsNullOrEmpty(DireccionTextBox.Text))
            {
                ErrorProvider.SetError(DireccionTextBox,
                    "Ingresar la Dirección para el cliente");
                paso = true;
            }

            return paso;
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(ClienteIdNumericUpDown.Value);
            Cliente cliente = ClientesBLL.Buscar(id);

            if (cliente != null)
            {
                NombresTextBox.Text = cliente.Nombres;
                TelefonoMaskedTextBox.Text = cliente.Telefono;
                CedulaMaskedTextBox.Text = cliente.Cedula;
                EmailTextBox.Text = cliente.Email;
                DireccionTextBox.Text = cliente.Direccion;
                
            }
            else
            {
                MessageBox.Show("ID no encontrado");
                ClienteIdNumericUpDown.Value = 0;
            }
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {

            Cliente cliente;
            bool paso = false;

            if (HayErrores())
                MessageBox.Show("Debe llenar los campos indicados", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                cliente = LlenarClase();

                if (ClienteIdNumericUpDown.Value == 0)
                    paso = ClientesBLL.Guardar(cliente);
                else
                {
                    int id = Convert.ToInt32(ClienteIdNumericUpDown.Value);
                    cliente = ClientesBLL.Buscar(id);

                    if (cliente != null)
                    {
                        paso = ClientesBLL.Modificar(LlenarClase());
                    }
                    else
                        MessageBox.Show("Id no existe", "Falló",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (paso)
                {
                    MessageBox.Show("Guardado!!", "Exito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                }
                else
                    MessageBox.Show("No se pudo guardar!!", "Falló",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(ClienteIdNumericUpDown.Value);

            Cliente cliente = ClientesBLL.Buscar(id);
            if (cliente != null)
            {
                if (ClientesBLL.Eliminar(id))
                {
                    MessageBox.Show("Eliminado!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                }
                else
                    MessageBox.Show("No se pudo eliminar!!", "Falló", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("No existe!!", "Falló", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


        private void TelefonoMaskedTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se puede digitar Números", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CedulaMaskedTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se puede digitar Números", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
