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

namespace ProyectoFinal
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }


        public bool Validar()
        {
            bool paso = false;
            if (string.IsNullOrWhiteSpace(UsernameTextBox.Text))
            {
                MyerrorProvider.SetError(UsernameTextBox, "Llene el campo Nombre de usuario.");
                paso = true;
            }

            if (string.IsNullOrWhiteSpace(PassworddTextBox.Text))
            {
                MyerrorProvider.SetError(PassworddTextBox, "Llene el campo contraseña.");
                paso = true;
            }

            return paso;
        }

        private void EntrarButton_Click(object sender, EventArgs e)
        {
            if (UsernameTextBox.Text == "1admin" && PassworddTextBox.Text == "1admin")
            {
                this.Hide();
                new Menu().Show();
                return;
            }

            foreach (Usuario user in UsuariosBLL.GetListTodo())
            {
                if (user.Username.Equals(UsernameTextBox.Text) &&
                    user.Passwordd.Equals(PassworddTextBox.Text))
                {
                    this.Hide();
                    new Menu().Show();
                    return;
                }
            }

            MessageBox.Show("Este usuario no existe");

        }

        private void SalirButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
