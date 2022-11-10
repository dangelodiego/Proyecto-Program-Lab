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
    public partial class frmConsulta4 : Form
    {
        private IConsultasComplejas consultasDAO;
        public frmConsulta4()
        {
            InitializeComponent();
            consultasDAO = new CarrerasDAO();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            int promedio = Convert.ToInt32(txtPromedio.Text);
            CargarGrilla(promedio);
        }

        private void CargarGrilla(int promedio)
        {
            List<MateriaSegunPromedioDTO> list = consultasDAO.ObtenerMateriaSegunPromedio(promedio);
            dataGridView1.DataSource = list;
            dataGridView1.Columns[1].Width = 320;
            dataGridView1.Columns[2].Width = 300;

        }

        private void frmConsulta4_Load(object sender, EventArgs e)
        {

        }
    }
}
