using TecnicaturasPresentacion.PantallaDeCarga;
using TecnicaturasPresentacion.Principal;


namespace TecnicaturasPresentacion
{
    public partial class frmLogin : Form
    {
        
        public frmLogin()
        {
            InitializeComponent();
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
            frmPantallaCarga carga = new frmPantallaCarga();
            carga.Show(); 
            this.Hide();
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

        private void login()
        {
        
        }
    }
}