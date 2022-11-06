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
            CargarCombo(cboProvincia, "https://localhost:7148/api/Localizaciones/Provincias");
            cboCiudad.Enabled = false;
            cboBarrio.Enabled = false;

        }

        private async void CargarCombo(ComboBox cbo, string url)
        {
            var response = await SingletonHttpClient.ObtenerInstancia().GetAsync(url);
            var objeto = JsonConvert.DeserializeObject<List<Provincia>>(response);
            cbo.DataSource = objeto;
            cbo.DisplayMember = "Nombre";
            cbo.ValueMember = "Id";
            cbo.DropDownStyle = ComboBoxStyle.DropDownList;
        }


    }

} 