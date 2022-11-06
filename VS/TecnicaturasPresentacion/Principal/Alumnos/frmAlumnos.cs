using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;
using TecnicaturasPresentacion.Cliente;
using DatosCarrera.dominio;
using DatosCarrera.dominio.auxiliares;


namespace TecnicaturasPresentacion.Principal.Alumnos
{
    public partial class frmAlumnos : Form
    {
        public frmAlumnos()
        {
            InitializeComponent();
        }

        private void frmAlumnos_Load(object sender, EventArgs e)
        {
            
            cboBarrio.Enabled = false;
            cboCiudad.Enabled = false;
            //Combo.CargarComboCiudad(cboCiudad, "https://localhost:7148/api/Localizaciones/Ciudades/5");
            Combo.CargarComboEstadosCiviles(cboEstadoCivil, "https://localhost:7148/api/EstadosCiviles");
            Combo.CargarComboProvincia(cboProvincia, "https://localhost:7148/api/Localizaciones/Provincias");
            
        }

        private void cboProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboProvincia.SelectedItem != null)
            {
                cboCiudad.Enabled = true;
                Combo.CargarComboCiudad(cboCiudad, "https://localhost:7148/api/Localizaciones/Ciudades/" + cboProvincia.SelectedValue);
            }
        }
    }

} 