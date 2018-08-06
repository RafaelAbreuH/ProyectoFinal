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
    public partial class rUsuario : Form
    {
        public rUsuario()
        {
            InitializeComponent();
        }

        private Usuario LlenarClase()
        {
            Usuario usuario = new Usuario();

            usuario.UsuarioId = Convert.ToInt32(UsuarioIdNumericUpDown.Value);
            usuario.Nombre = NombreTextBox.Text;
            usuario.Username = UsernameTextBox.Text;
            usuario.Passwordd = PassworddTextBox.Text;
            usuario.Email = EmailTextBox.Text;
            usuario.Telefono = TelefonoMaskedTextBox.Text;

            return usuario;
        }

        private void Limpiar()
        {
            UsuarioIdNumericUpDown.Value = 0;
            NombreTextBox.Clear();
            UsernameTextBox.Clear();
            EmailTextBox.Clear();
            TelefonoMaskedTextBox.Clear();
            PassworddTextBox.Clear();
            RepetirPassworddtextBox.Clear();
            ErrorProvider.Clear();
        }

        private bool HayErrores()
        {
            bool paso = false;

            if (String.IsNullOrEmpty(NombreTextBox.Text))
            {
                ErrorProvider.SetError(NombreTextBox,
                    "Escribir el Nombre Completo!");
                paso = true;
            }
            if (String.IsNullOrEmpty(EmailTextBox.Text))
            {
                ErrorProvider.SetError(EmailTextBox,
                    "Escribir el Email!");
                paso = true;
            }
            if (String.IsNullOrEmpty(TelefonoMaskedTextBox.Text))
            {
                ErrorProvider.SetError(TelefonoMaskedTextBox,
                    "Escribir el numero de telefono");
                paso = true;
            }
            if (String.IsNullOrEmpty(PassworddTextBox.Text))
            {
                ErrorProvider.SetError(PassworddTextBox,
                    "Debes ingresar una Contraseña");
                paso = true;
            }
            if(RepetirPassworddtextBox.Text != PassworddTextBox.Text)
            {
                ErrorProvider.SetError(RepetirPassworddtextBox,
                    "La Contraseña no son iguales!");
                paso = true;
            }

            return paso;
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(UsuarioIdNumericUpDown.Value);
            Usuario usuario = UsuariosBLL.Buscar(id);

            if (usuario != null)
            {
                NombreTextBox.Text = usuario.Nombre;
                UsernameTextBox.Text = usuario.Username;
                EmailTextBox.Text = usuario.Email;
                TelefonoMaskedTextBox.Text = usuario.Telefono;
                PassworddTextBox.Text = usuario.Passwordd;
                ErrorProvider.Clear();
            }
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            Usuario usuario;
            bool paso = false;

            if (HayErrores())
                MessageBox.Show("Debe llenar los campos indicados", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {


                usuario = LlenarClase();

                if (UsuarioIdNumericUpDown.Value == 0)
                    paso = UsuariosBLL.Guardar(usuario);
                else
                {
                    int id = Convert.ToInt32(UsuarioIdNumericUpDown.Value);
                    usuario = UsuariosBLL.Buscar(id);

                    if (usuario != null)
                    {
                        paso = UsuariosBLL.Modificar(LlenarClase());
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
            int id = Convert.ToInt32(UsuarioIdNumericUpDown.Value);

            Usuario usuario = UsuariosBLL.Buscar(id);
            if (usuario != null)
            {
                if (UsuariosBLL.Eliminar(id))
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
