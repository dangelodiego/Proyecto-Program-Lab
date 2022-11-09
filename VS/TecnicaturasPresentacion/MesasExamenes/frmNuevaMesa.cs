using DatosCarrera.datos.Implementaciones;
using DatosCarrera.datos.Interfaces;
using DatosCarrera.dominio;
using DatosCarrera.dominio.auxiliares;
using Newtonsoft.Json;
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

namespace TecnicaturasPresentacion.MesasExamenes
{
    public partial class frmNuevaMesa : Form
    {
        private IMesasExamenDAO mesasExamenDAO;
        private MesaExamen mesa;
        public frmNuevaMesa()
        {
            InitializeComponent();
            mesasExamenDAO = new CarrerasDAO();
            mesa = new MesaExamen();
        }

        private async void frmNuevaMesa_Load(object sender, EventArgs e)
        {
            await Combo.CargarComboTecnicaturas(cboTecnicaturas, "https://localhost:7148/api/Tecnicaturas");
            DeshabilitarCamposMaestro(true);
        }

        //private void btnAgregar_Click(object sender, EventArgs e)
        //{
        //    if (validarCampos())
        //    {

        //        Examen ex = new Examen();

        //        Alumno a = new Alumno();

        //        a.Legajo = Convert.ToInt32(txtLegajoAlumno.Text);
        //        ex.Alumno = a;
        //        ex.Nota = Convert.ToInt32(numericUpDown1.Value);


        //        mesa.AgregarExamen(ex);

        //        string turnoExamenParaGrilla = cboTurnoExamen.Text;
        //        string tecnicaturaParaGrila = cboTecnicaturas.Text;
        //        string materiaParaGrilla = cboMateria.Text;
        //        string profesorParaGrilla = cboProfesor.Text;
        //        int legajoParaGrilla = Convert.ToInt32(txtLegajoAlumno.Text);
        //        int notaParaGrilla = Convert.ToInt32(numericUpDown1.Value);

        //        dataGridView1.Rows.Add(new object[] { dtpFechaMesa.Value, turnoExamenParaGrilla, tecnicaturaParaGrila, materiaParaGrilla, profesorParaGrilla, legajoParaGrilla, notaParaGrilla });

        //    }

        //    DeshabilitarCamposMaestro();

        //}


        private bool validarCampos()
        {
            if (cboTurnoExamen.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un Turno", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false; ;
            }

            if (cboTecnicaturas.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un Tecnicatura ", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (cboMateria.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar una Materia", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (cboProfesor.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un Profesor", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }


            if (txtLegajoAlumno.Text == "")
            {
                MessageBox.Show("Debe ingresar un Legajo del alumno", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (numericUpDown1.Value > 10)
            {
                MessageBox.Show("La nota no puede ser superior a 10");
                return false;
            }

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {

                if (row.Cells["colLegajoAlumno"].Value == null)
                {
                    break;
                }

                if (row.Cells["colLegajoAlumno"].Value.ToString().Equals(txtLegajoAlumno.Text))
                {
                    MessageBox.Show("ALUMNO con Legajo: " + txtLegajoAlumno.Text + " ya se encuentra como detalle!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;

                }

                if (dataGridView1.Rows.Count == 0)
                {
                    break;

                }

            }

            return true;

        }



        //private void btnCargar_Click(object sender, EventArgs e)
        //{
        //    Materia m = new Materia();  
        //    Profesor p = new Profesor();
        //    m.Id = Convert.ToInt32(cboMateria.SelectedValue);
        //    p.Id = Convert.ToInt32(cboProfesor.SelectedValue);


        //    mesa.Fecha = dtpFechaMesa.Value;
        //    if (cboTurnoExamen.SelectedIndex > -1)
        //        mesa.TurnoExamen = (TurnosExamen)cboTurnoExamen.SelectedIndex + 1;
        //    mesa.Fecha = dtpFechaMesa.Value;
        //    mesa.Profesor = p;
        //    mesa.Materia = m;
        //    if (mesasExamenDAO.CrearMesa(mesa))
        //    {
        //        MessageBox.Show("Se guardó la mesa de examen correctamente ", "Sistema", MessageBoxButtons.OK);
        //    }
        //    else
        //    {
        //        MessageBox.Show("No se pudo guardar la mesa de examen", "Sistema", MessageBoxButtons.OK);
        //    }
        //    limpiar();


        //}

        //private async void cboMateria_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (cboMateria.SelectedItem != null)
        //    {
        //        cboProfesor.Enabled = true;
        //        await Combo.CargarComboProfesoresPorMateria(cboProfesor, "https://localhost:7148/api/Profesores/Profesores/" + cboMateria.SelectedValue);
        //    }

        //}

        private void DeshabilitarCamposMaestro(bool x)
        {
                dtpFechaMesa.Enabled = x;
                cboTurnoExamen.Enabled = x;
                cboTecnicaturas.Enabled = x;
                cboMateria.Enabled = x;
                cboProfesor.Enabled = x;
            
        }

        private void limpiar()
        {
            dtpFechaMesa.Value = DateTime.Today;
            cboTurnoExamen.SelectedIndex = -1;
            cboTecnicaturas.SelectedIndex = -1;
            cboMateria.SelectedIndex = -1;
            cboProfesor.SelectedIndex = -1;
            txtLegajoAlumno.Text = "";
            numericUpDown1.Value = 1;
            dataGridView1.Rows.Clear();
        }

        private async void cboMateria_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cboMateria.SelectedItem != null)
            {
                cboProfesor.Enabled = true;
                await Combo.CargarComboProfesoresPorMateria(cboProfesor, "https://localhost:7148/api/Profesores/Profesores/" + cboMateria.SelectedValue);
            }
        }

        private async void cboTecnicaturas_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cboTecnicaturas.SelectedItem != null)
            {

                cboMateria.Enabled = true;
                await Combo.CargarComboMateriasPorCarrera(cboMateria, "https://localhost:7148/api/Materias/Materias/" + cboTecnicaturas.SelectedValue);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (validarCampos())
            {

                Examen ex = new Examen();

                Alumno a = new Alumno();

                a.Legajo = Convert.ToInt32(txtLegajoAlumno.Text);
                ex.Alumno = a;
                ex.Nota = Convert.ToInt32(numericUpDown1.Value);


                mesa.AgregarExamen(ex);

                string turnoExamenParaGrilla = cboTurnoExamen.Text;
                string tecnicaturaParaGrila = cboTecnicaturas.Text;
                string materiaParaGrilla = cboMateria.Text;
                string profesorParaGrilla = cboProfesor.Text;
                int legajoParaGrilla = Convert.ToInt32(txtLegajoAlumno.Text);
                int notaParaGrilla = Convert.ToInt32(numericUpDown1.Value);

                dataGridView1.Rows.Add(new object[] { dtpFechaMesa.Value, turnoExamenParaGrilla, tecnicaturaParaGrila, materiaParaGrilla, profesorParaGrilla, legajoParaGrilla, notaParaGrilla });

            }
            if (dataGridView1.Rows.Count > 0)
            {
                DeshabilitarCamposMaestro(false);
            }
                
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            {
                Materia m = new Materia();
                Profesor p = new Profesor();
                m.Id = Convert.ToInt32(cboMateria.SelectedValue);
                p.Id = Convert.ToInt32(cboProfesor.SelectedValue);


                mesa.Fecha = dtpFechaMesa.Value;
                if (cboTurnoExamen.SelectedIndex > -1)
                    mesa.TurnoExamen = (TurnosExamen)cboTurnoExamen.SelectedIndex + 1;
                mesa.Fecha = dtpFechaMesa.Value;
                mesa.Profesor = p;
                mesa.Materia = m;
                if ( mesasExamenDAO.CrearMesa(mesa))
                {
                    MessageBox.Show("Se guardó la mesa de examen correctamente ", "Sistema", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("No se pudo guardar la mesa de examen", "Sistema", MessageBoxButtons.OK);
                }
                limpiar();
                
                DeshabilitarCamposMaestro(true);
                
            }

        }
        private async Task<bool> GrabarMesaExamenAsync(MesaExamen mesa)
        {
            string url = "https://localhost:7148/api/Mesas";
            string mesaJson = JsonConvert.SerializeObject(mesa);
            var result = await SingletonHttpClient.ObtenerInstancia().PostAsync(url, mesaJson);
            return result.Equals("true");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentCell.ColumnIndex == 7)
            {
                mesa.Examenes.Remove(mesa.Examenes[dataGridView1.CurrentCell.RowIndex]);
                dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
            }
        }
    }
}
