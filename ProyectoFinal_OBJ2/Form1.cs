using System;
using System.Windows.Forms;

namespace ProyectoFinal_OBJ2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            // Formulario de login
            using (LoginForm loginForm = new LoginForm())
            {
                if (loginForm.ShowDialog() == DialogResult.OK)
                {
                    // El usuario se autenticó correctamente
                    // Realizar acciones posteriores al inicio de sesión
                }
            }
        }
    }
}
