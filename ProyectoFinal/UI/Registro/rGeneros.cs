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
    public partial class rGeneros : Form
    {
        public rGeneros()
        {
            InitializeComponent();
        }

        private bool HayErrores()
        {
            bool paso = false;

            if (String.IsNullOrEmpty(NombreTextBox.Text))
            {
                ErrorProvider.SetError(NombreTextBox,
                    "Ingrese el Nombre del Genero!");
                paso = true;
            }
            if (String.IsNullOrEmpty(DescripcionTextBox.Text))
            {
                ErrorProvider.SetError(DescripcionTextBox,
                    "Ingrese La descripcion del genero");
                paso = true;
            }
            return paso;
        }

        private Generos LlenarClase()
        {
            Generos generos = new Generos();

            generos.Descripcion = DescripcionTextBox.Text;
            generos.GeneroId = Convert.ToInt32(GeneroIdNumericUpDown.Value);
            generos.Nombre = NombreTextBox.Text;
            return generos;
        }

        private void Limpiar()
        {
            GeneroIdNumericUpDown.Value = 0;
            NombreTextBox.Clear();
            DescripcionTextBox.Clear();
            ErrorProvider.Clear();
        }
        private void BuscarButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(GeneroIdNumericUpDown.Value);
            Generos generos = GenerosBLL.Buscar(id);

            if (generos != null)
            {
                NombreTextBox.Text = generos.Nombre;
                DescripcionTextBox.Text = generos.Descripcion;
            }
            else
            {
                MessageBox.Show("ID no encontrado");
                GeneroIdNumericUpDown.Value = 0;
            }
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            Generos generos;
            bool paso = false;

            if (HayErrores())
                MessageBox.Show("Debe llenar los campos indicados", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {

                generos = LlenarClase();

                if (GeneroIdNumericUpDown.Value == 0)
                    paso = GenerosBLL.Guardar(generos);
                else
                {
                    int id = Convert.ToInt32(GeneroIdNumericUpDown.Value);
                    generos = GenerosBLL.Buscar(id);

                    if (generos != null)
                    {
                        paso = GenerosBLL.Modificar(LlenarClase());
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
            int id = Convert.ToInt32(GeneroIdNumericUpDown.Value);

            Generos generos = GenerosBLL.Buscar(id);
            if (generos != null)
            {
                if (GenerosBLL.Eliminar(id))
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

        private void NuevoButton_Click(object sender, EventArgs e)
        {

        }
    }
}
