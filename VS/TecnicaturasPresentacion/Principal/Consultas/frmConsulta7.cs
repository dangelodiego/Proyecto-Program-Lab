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
    public partial class frmConsulta7 : Form
    {
        private IConsultasComplejas consultasDAO;
        public frmConsulta7()
        {
            InitializeComponent();
            consultasDAO = new CarrerasDAO();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            int año = Convert.ToInt32(txtAño.Text);
            CargarGrilla(año);
        }

        private void CargarGrilla(int año)
        {
            List<AlumnosRindieronEsteAñoDTO> list = consultasDAO.ObtenerAlumnosRindieronEsteAño(año);
            dgvConsulta7.DataSource = list;
            dgvConsulta7.Columns[1].Width = 250;
        }
    }
}
