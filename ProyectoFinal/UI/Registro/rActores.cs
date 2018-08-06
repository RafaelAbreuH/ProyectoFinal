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
    public partial class rActores : Form
    {
        public rActores()
        {
            InitializeComponent();
        }

        private bool HayErrores()
        {
            bool paso = false;
            if (String.IsNullOrEmpty(NombreTextBox.Text))
            {
                ErrorProvider.SetError(NombreTextBox,
                    "Debes Digitar el Nombre del Actor!");
                paso = true;
            }
            return paso;
        }

        private Actores LlenarClase()
        {
            Actores actores = new Actores();

            actores.ActoresId = Convert.ToInt32(ActorIdNumericUpDown.Value);
            actores.Nombre = NombreTextBox.Text;
            actores.FechaNacimiento = FechaDateTimePicker.Value;
            return actores;
        }

        private void Limpiar()
        {
            ActorIdNumericUpDown.Value = 0;
            NombreTextBox.Clear();
            FechaDateTimePicker.Value = DateTime.Now;
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(ActorIdNumericUpDown.Value);
            Actores actores = ActoresBLL.Buscar(id);

            if (actores != null)
            {
                FechaDateTimePicker.Value = actores.FechaNacimiento;
                NombreTextBox.Text = actores.Nombre;
                
            }
            else
            {
                MessageBox.Show("ID no encontrado");
                ActorIdNumericUpDown.Value = 0;
            }
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            bool paso = false;
            Actores actores;

            if (HayErrores())
                MessageBox.Show("Llenar los Campos indicados", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            actores = LlenarClase();

            if (ActorIdNumericUpDown.Value == 0)
                paso = ActoresBLL.Guardar(actores);
            else
            {
                int id = Convert.ToInt32(ActorIdNumericUpDown.Value);
                actores = ActoresBLL.Buscar(id);

                if (actores != null)
                {
                    paso = ActoresBLL.Modificar(LlenarClase());
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

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(ActorIdNumericUpDown.Value);

            Actores actores = ActoresBLL.Buscar(id);
            if (actores != null)
            {
                if (ActoresBLL.Eliminar(id))
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
    }
}
