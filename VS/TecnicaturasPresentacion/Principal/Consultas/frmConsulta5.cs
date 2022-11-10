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
    public partial class frmConsulta5 : Form
    {
        private IConsultasComplejas consultasDAO;
        public frmConsulta5()
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
            List<EdadPromedioDTO> list = consultasDAO.ObtenerEdadPromedio();
            dgvConsulta5.DataSource = list;
        }
    }
}
