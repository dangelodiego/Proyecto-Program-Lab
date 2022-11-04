using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;


namespace TecnicaturasPresentacion.Principal.About
{
    public partial class frmAbout : Form
    {
        public frmAbout()
        {
            InitializeComponent();
        }

        private void linkLabelRepo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabelRepo.LinkVisited = true;
            Process.Start(new ProcessStartInfo { FileName = @"https://github.com/dangelodiego/Proyecto-Program-Lab", UseShellExecute = true });
            //Response.Redirect("https://github.com/dangelodiego/Proyecto-Program-Lab");
        }
    }
}
