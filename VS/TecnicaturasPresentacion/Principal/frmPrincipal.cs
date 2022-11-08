using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TecnicaturasPresentacion.MesasExamenes;
using TecnicaturasPresentacion.Principal.About;
using TecnicaturasPresentacion.Principal.Alumnos;
using TecnicaturasPresentacion.Principal.Home;
using TecnicaturasPresentacion.Principal.Profesores;

namespace TecnicaturasPresentacion.Principal
{
    public partial class frmPrincipal : Form
    {
        bool sidebarExpand;
        bool consultaCollapsed;
        bool mesaCollapsed;
        bool aluCollapsed;
        public frmPrincipal()
        {
            InitializeComponent();
            AbrirFrom(new frmHome());
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void flpOpciones_Paint(object sender, PaintEventArgs e)
        {

        }

        

        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                flpOpciones.Width -= 10;
                if (flpOpciones.Width == flpOpciones.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebarTimer.Stop();
                }
            }
            else
            {
                flpOpciones.Width += 10;
                if(flpOpciones.Width == flpOpciones.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sidebarTimer.Stop();
                }
            }
        }

        private void pbMenu_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }

        private void ConsultasContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ConsultasTimer_Tick(object sender, EventArgs e)
        {
            if (consultaCollapsed)
            {
                ConsultasContainer.Height += 10;
                if(ConsultasContainer.Height == ConsultasContainer.MaximumSize.Height)
                {
                    consultaCollapsed = false;
                    ConsultasTimer.Stop();
                }
            }
            else
            {
                ConsultasContainer.Height -= 10;
                if (ConsultasContainer.Height == ConsultasContainer.MinimumSize.Height)
                {
                    consultaCollapsed = true;
                    ConsultasTimer.Stop();
                }
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            ConsultasTimer.Start();
        }
        private void MesasTimer_Tick(object sender, EventArgs e)
        {
            if (mesaCollapsed)
            {
                MesasContainer.Height += 10;
                if (MesasContainer.Height == MesasContainer.MaximumSize.Height)
                {
                    mesaCollapsed = false;
                    MesasTimer.Stop();
                }
            }
            else
            {
                MesasContainer.Height -= 10;
                if (MesasContainer.Height == MesasContainer.MinimumSize.Height)
                {
                    mesaCollapsed = true;
                    MesasTimer.Stop();
                }
            }
        }
        private void btnMesas_Click(object sender, EventArgs e)
        {
            MesasTimer.Start();
        }
        private void AlumnosTimer_Tick(object sender, EventArgs e)
        {
            if (aluCollapsed)
            {
                AlumnosContainer.Height += 10;
                if (AlumnosContainer.Height == AlumnosContainer.MaximumSize.Height)
                {
                    aluCollapsed = false;
                    AlumnosTimer.Stop();
                }
            }
            else
            {
                AlumnosContainer.Height -= 10;
                if (AlumnosContainer.Height == AlumnosContainer.MinimumSize.Height)
                {
                    aluCollapsed = true;
                    AlumnosTimer.Stop();
                }
            }
        }


        private void btnAlumnos_Click_1(object sender, EventArgs e)
        {
            AlumnosTimer.Start();
        }

        private void pbMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pbMaximizar_Click(object sender, EventArgs e)
        {
           
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea cerrar la aplicacion?", "SISTEMA", MessageBoxButtons.YesNo, MessageBoxIcon.Question
                , MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                Application.Exit();
        }

        private void AbrirFrom(object formhija)
        {
            if (this.panelPrincipal.Controls.Count > 0)
                this.panelPrincipal.Controls.RemoveAt(0);
            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelPrincipal.Controls.Add(fh);
            this.panelPrincipal.Tag = fh;
            fh.Show();

        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            AbrirFrom(new frmAbout());
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            AbrirFrom(new frmHome());
        }

        private void btnAlumnos_Click(object sender, EventArgs e)
        {
            AbrirFrom(new frmAlumnos());
        }

        private void btnProfesores_Click(object sender, EventArgs e)
        {
            AbrirFrom(new frmProfesores());
        }

        private void btnConsultarAlumno_Click(object sender, EventArgs e)
        {
            AbrirFrom(new frmConsultarAlumno());
        }

        private void btnNuevaMesa_Click(object sender, EventArgs e)
        {
            AbrirFrom(new frmNuevaMesa());
        }

        private void btnRetMesa_Click(object sender, EventArgs e)
        {
            AbrirFrom(new frmRetificarMesa());
        }
       

        private void panelPrincipal_Paint(object sender, PaintEventArgs e)
        {

        }

        
    }
}
