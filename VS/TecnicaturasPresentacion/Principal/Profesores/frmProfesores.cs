using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TecnicaturasPresentacion.Cliente;

namespace TecnicaturasPresentacion.Principal.Profesores
{
    public partial class frmProfesores : Form
    {
        public frmProfesores()
        {
            InitializeComponent();
        }

        private void frmProfesores_Load(object sender, EventArgs e)
        {
            cboCiudad.Enabled = false;
            cboBarrio.Enabled = false;
            Combo.CargarComboCiudad(cboCiudad, "https://localhost:7148/api/Localizaciones/Ciudades/5");
            Combo.CargarComboEstadosCiviles(cboEstadoCivil, "https://localhost:7148/api/EstadosCiviles");
            Combo.CargarComboProvincia(cboProvincia, "https://localhost:7148/api/Localizaciones/Provincias");
        }
    }
}
