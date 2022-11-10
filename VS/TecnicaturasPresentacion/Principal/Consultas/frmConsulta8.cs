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
    public partial class frmConsulta8 : Form
    {
        private IConsultasComplejas consultasDAO;
        public frmConsulta8()
        {
            InitializeComponent();
            consultasDAO = new CarrerasDAO();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            int nota = Convert.ToInt32(nudNota.Value);
            CargarGrilla(nota);
        }

        private void CargarGrilla(int nota)
        {
            List<DatosAlumnosDTO> list = consultasDAO.ObtenerDatosAlumnos(nota);
            dataGridView1.DataSource = list;
        }
    }
}
