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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void EntrarButton_Click(object sender, EventArgs e)
        {//ContraseñatextBox.Text != ConfirmartextBox.Text
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void SalirButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
