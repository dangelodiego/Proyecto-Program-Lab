using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TecnicaturasPresentacion.Principal;

namespace TecnicaturasPresentacion.PantallaDeCarga
{
    public partial class frmPantallaCarga : Form
    {
        public frmPantallaCarga()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel2.Width += 3;
            if(panel2.Width >= 800)
            {
                timer1.Stop();
                frmPrincipal pr = new frmPrincipal();
                pr.Show();
                this.Hide();
            }
        }
    }
}
