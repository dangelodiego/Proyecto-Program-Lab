using TecnicaturasPresentacion.PantallaDeCarga;
using TecnicaturasPresentacion.Principal;
using DatosCarrera.datos.Implementaciones;
using DatosCarrera.datos.Interfaces;

namespace TecnicaturasPresentacion
{
    public partial class frmLogin : Form
    {

        private IloginUsuario loginDAO;
        public frmLogin()
        {
            InitializeComponent();
            loginDAO = new LoginDAO();
        }

        private void pictureBoxCloseLogin_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Cerrar la aplicacion?", "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question
                , MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                this.Close();
        }

        private void pictureBoxMinLogin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            int resultado = loginDAO.ChequearLogin(txtUsuario.Text, txtContraseña.Text);

            if (resultado == 1)
            {
                frmPantallaCarga carga = new frmPantallaCarga();
                this.Hide();
                carga.ShowDialog();
            }
            else if (resultado == 0)
            {
                MessageBox.Show("Usuario o contraseña incorrecta");
                Limpiar();
            }

            //frmPantallaCarga carga = new frmPantallaCarga();
            //carga.Show();
            //this.Hide();
        }

        private void pictureBoxVisible_Click(object sender, EventArgs e)
        {
            pictureBoxOcultar.BringToFront();
            txtContraseña.PasswordChar = '\0';
        }

        private void pictureBoxOcultar_Click(object sender, EventArgs e)
        {
            pictureBoxVisible.BringToFront();
            txtContraseña.PasswordChar = '*';
        }

        private void Limpiar()
        {
            txtContraseña.Text = "";
            txtUsuario.Text = "";
        }
       
    }
}