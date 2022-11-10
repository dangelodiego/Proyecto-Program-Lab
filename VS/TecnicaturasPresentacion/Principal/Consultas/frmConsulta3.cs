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
    public partial class frmConsulta3 : Form
    {
        private IConsultasComplejas consultasDAO;
        public frmConsulta3()
        {
            InitializeComponent();
            consultasDAO = new CarrerasDAO();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            int cantidad = Convert.ToInt32(nudCantidad.Value);
            CargarGrilla(cantidad);
        }

        private void CargarGrilla(int cantidad)
        {
            List<AlumnosSegunMateriasCursadasDTO> list = consultasDAO.ObtenerAlumnosSegunMateriaCursada(cantidad);
            dgvConsulta3.DataSource = list;
            dgvConsulta3.Columns[1].Width = 320;
        }
    }
}
