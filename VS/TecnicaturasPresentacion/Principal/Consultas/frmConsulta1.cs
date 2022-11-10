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
    public partial class frmConsulta1 : Form
    {
        private IConsultasComplejas consultasDAO;
        
        public frmConsulta1()
        {
            InitializeComponent();
            consultasDAO = new CarrerasDAO();
        }

        private void frmConsulta1_Load(object sender, EventArgs e)
        {
           
            
        }

         

        private void CargarGrilla(int anio1, int anio2)
        {

            List<CantidadInscriptosDTO> list = consultasDAO.ObtenerCantidadInscriptos(anio1, anio2);
            dgvCantidadInscriptos.DataSource = list;

        }

        private void btnAcutalizar_Click(object sender, EventArgs e)
        {
           
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            int anio1 = Convert.ToInt32(txtAnioUNO.Text);
            int anio2 = Convert.ToInt32(txtAniodos.Text);
            CargarGrilla(anio1, anio2);
        }
    }
}
