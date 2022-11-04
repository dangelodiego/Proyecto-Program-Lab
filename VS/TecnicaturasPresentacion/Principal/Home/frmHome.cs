using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TecnicaturasPresentacion.Principal.Home
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        private void frmHome_Load(object sender, EventArgs e)
        {

        }

        private void lnkPaginaUTN_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lnkPaginaUTN.LinkVisited = true;
            Process.Start(new ProcessStartInfo { FileName = @"https://www.frc.utn.edu.ar/", UseShellExecute = true });
        }

        private void lnkCorreoUTN_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lnkCorreoUTN.LinkVisited = true;
            Process.Start(new ProcessStartInfo { FileName = @"https://rc.frc.utn.edu.ar/?_task=mail&_mbox=INBOX", UseShellExecute = true });
        }

        private void lnkCalendario_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lnkCorreoUTN.LinkVisited = true;
            Process.Start(new ProcessStartInfo { FileName = @"https://www.frc.utn.edu.ar/secretarias/academica/?pIs=98#n40185", UseShellExecute = true });
        }

        private void lblCantTecnicaturas_Click(object sender, EventArgs e)
        {

        }
    }
}
