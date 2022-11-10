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
using TecnicaturasPresentacion.Cliente;

namespace TecnicaturasPresentacion.Principal.Consultas
{
    public partial class frmConsulta2 : Form
    {
        private IConsultasComplejas consultasDAO;
        public frmConsulta2()
        {
            InitializeComponent();
            consultasDAO = new CarrerasDAO();
        }

        private async void frmConsulta2_Load(object sender, EventArgs e)
        {
            await Combo.CargarComboTecnicaturas(cboTecnicaturas, "https://localhost:7148/api/Tecnicaturas");
        }

        private async void cboTecnicaturas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTecnicaturas.SelectedItem != null)
            {

                cboMateria.Enabled = true;
                await Combo.CargarComboMateriasPorCarrera(cboMateria, "https://localhost:7148/api/Materias/Materias/" + cboTecnicaturas.SelectedValue);
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            int idMateria = Convert.ToInt32(cboMateria.SelectedValue);
            CargarGrilla(idMateria);
        }

        private void CargarGrilla(int idMateria)
        {

            List<CantidadInscriptosPorMateriaDTO> list = consultasDAO.ObtenerCantidadInscriptosPorMateria( idMateria);
            dgvCantidadmateria.DataSource = list;

        }
    }
}
