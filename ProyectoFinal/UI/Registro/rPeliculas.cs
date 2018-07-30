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
    public partial class rPeliculas : Form
    {
        public rPeliculas()
        {
            InitializeComponent();
            LlenarComboBox();
        }

        private Pelicula LlenarClase()
        {
            Pelicula pelicula = new Pelicula();

            pelicula.PeliculaId = Convert.ToInt32(PeliculaIdNumericUpDown.Value);
            pelicula.Nombre = NombreTextBox.Text;
            pelicula.FechaEstreno = FechaDateTimePicker.Value;
            pelicula.Precio = Convert.ToInt32(PrecioNumericUpDown.Value);
            pelicula.Introduccion = IntroduccionTextBox.Text;

            return pelicula;
        }
        private bool HayErrores()
        {
            bool paso = false;

            if (String.IsNullOrEmpty(IntroduccionTextBox.Text))
            {
                ErrorProvider.SetError(IntroduccionTextBox,
                    "Escribir la Introduccion de la pelicula");
                paso = true;
            }
            if (PrecioNumericUpDown.Value == 0)
            {
                ErrorProvider.SetError(PrecioNumericUpDown,
                    "Ingrese el precio de la Pelicula");
                paso = true;
            }
            if (String.IsNullOrEmpty(NombreTextBox.Text))
            {
                ErrorProvider.SetError(NombreTextBox,
                    "Debe ingresar el nombre de la Pelicula");
                paso = true;
            }
            if (CantidadNumericUpDown.Value == 0)
            {
                ErrorProvider.SetError(NombreTextBox,
                    "Debe ingresar La cantidad");
                paso = true;
            }

            return paso;
        }

        private void LlenarComboBox()
        {
            Repositorio<Generos> GenRepositorio = new Repositorio<Generos>(new Contexto());

            GenerosComboBox.DataSource = GenRepositorio.GetList(c => true);
            GenerosComboBox.ValueMember = "GeneroId";
            GenerosComboBox.DisplayMember = "Nombre";

            Repositorio<Actores> ActRepositorio = new Repositorio<Actores>(new Contexto());

            ProtagonistaComboBox.DataSource = ActRepositorio.GetList(c => true);
            ProtagonistaComboBox.ValueMember = "ActoresId";
            ProtagonistaComboBox.DisplayMember = "Nombre";
        }

        public void Limpiar()
        {
            PeliculaIdNumericUpDown.Value = 0;
            NombreTextBox.Clear();
            PrecioNumericUpDown.Value = 0;
            FechaDateTimePicker.Value = DateTime.Now;
            IntroduccionTextBox.Clear();
            CantidadNumericUpDown.Value = 0;
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(PeliculaIdNumericUpDown.Value);
            Pelicula pelicula = PeliculasBLL.Buscar(id);

            if (pelicula != null)
            {
                PeliculaIdNumericUpDown.Value = pelicula.PeliculaId;
                NombreTextBox.Text = pelicula.Nombre;
                PrecioNumericUpDown.Value = pelicula.Precio;
                FechaDateTimePicker.Value = pelicula.FechaEstreno;
                IntroduccionTextBox.Text = pelicula.Introduccion;
                GenerosComboBox.SelectedValue = pelicula.GeneroId;
                ProtagonistaComboBox.SelectedValue = pelicula.ActoresId;
                CantidadNumericUpDown.Value = pelicula.cantidad;
                LlenarComboBox();
            }
            else
            {
                MessageBox.Show("ID no encontrado");
                PeliculaIdNumericUpDown.Value = 0;
            }
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            Pelicula pelicula;
            bool paso = false;

            if (HayErrores())
                MessageBox.Show("Debe llenar los campos indicados", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {


                pelicula = LlenarClase();

                if (PeliculaIdNumericUpDown.Value == 0)
                {
                    paso = PeliculasBLL.Guardar(pelicula);
                    MessageBox.Show("Guardado!!", "Exito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else
                {
                    int id = Convert.ToInt32(PeliculaIdNumericUpDown.Value);
                    pelicula = PeliculasBLL.Buscar(id);

                    if (pelicula != null)
                    {
                        paso = PeliculasBLL.Modificar(LlenarClase());
                        MessageBox.Show("Modificado", "Exito",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show("Id no existe", "Falló",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (paso)
                {
                    Limpiar();
                }
                else
                    MessageBox.Show("No se pudo guardar!!", "Falló",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(PeliculaIdNumericUpDown.Value);

            Pelicula pelicula = PeliculasBLL.Buscar(id);
            if (pelicula != null)
            {
                if (PeliculasBLL.Eliminar(id))
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
