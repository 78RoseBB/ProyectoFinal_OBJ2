using System;
using System.Windows.Forms;

namespace ProyectoFinal_OBJ2
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        dgvAlumnos = new DataGridView();
        dgvAlumnos.Dock = DockStyle.Fill;
        dgvAlumnos.AutoGenerateColumns = true; 
        dgvAlumnos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvAlumnos.AllowUserToAddRows = false; 
        dgvAlumnos.ReadOnly = true; 
        this.Controls.Add(dgvAlumnos); 

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Obtener el nombre de usuario y la contraseña ingresados
            string usuario = txtUsuario.Text;
            string contrasena = txtContrasena.Text;

            // Autenticar al usuario
            if (Autenticar(usuario, contrasena))
            {
                // Usuario autenticado correctamente
                MessageBox.Show("Inicio de sesión exitoso", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Cerrar el formulario de login
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                // Usuario no autenticado
                MessageBox.Show("Inicio de sesión fallido. Verifica las credenciales.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool Autenticar(string usuario, string contrasena)
        {
            // Realizar la lógica de autenticación aquí
            // Por ejemplo, comparar con una lista de usuarios y contraseñas
            if (usuario == "Julio" && contrasena == "Julio14/79")
            {
                // Autenticar como Administrador y propietario
                return true;
            }
            else if (usuario == "Rosemary" && contrasena == "Rose0208*")
            {
                // Autenticar como Servicio al Cliente
                return true;
            }

            return false;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            // Cerrar la aplicación
            Application.Exit();
        }
    }
}
