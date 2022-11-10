using DatosCarrera.datos.DTOs;
using DatosCarrera.datos.Implementaciones;
using DatosCarrera.datos.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TecnicaturasPresentacion.Principal.Consultas
{
    public partial class frmConsulta6 : Form
    {
        private IConsultasComplejas consultasDAO;
        public frmConsulta6()
        {
            InitializeComponent();
            consultasDAO = new CarrerasDAO();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        private void CargarGrilla()
        {
            List<ProximoAJubilar> list = consultasDAO.ObtenerJubilar();
            dgvConsulta6.DataSource = list;
        }
    }
}
