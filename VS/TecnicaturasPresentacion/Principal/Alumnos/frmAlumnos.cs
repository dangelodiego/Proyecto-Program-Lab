﻿using System;
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
using DatosCarrera.dominio.auxiliares;
using MaterialSkin.Controls;


namespace TecnicaturasPresentacion.Principal.Alumnos
{
    public partial class frmAlumnos : Form
    {

        public List<Alumno> alumnos = new List<Alumno>();
        public frmAlumnos()
        {
            InitializeComponent();
        }

        private void frmAlumnos_Load(object sender, EventArgs e)
        {
            
            cboBarrio.Enabled = false;
            cboCiudad.Enabled = false;
            Combo.CargarComboEstadosCiviles(cboEstadoCivil, "https://localhost:7148/api/EstadosCiviles");
            Combo.CargarComboProvincia(cboProvincia, "https://localhost:7148/api/Localizaciones/Provincias");
            Combo.CargarComboTecnicaturas(cboTecnicatura, "https://localhost:7148/api/Tecnicaturas");
            Combo.CargarComboCurso(cboCurso, "https://localhost:7148/api/Tecnicaturas/Curso");

        }

        private void cboProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboProvincia.SelectedItem != null)
            {
                cboCiudad.Enabled = true;
                Combo.CargarComboCiudad(cboCiudad, "https://localhost:7148/api/Localizaciones/Ciudades/" + cboProvincia.SelectedValue);
            }
        }


        

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void limpiar()
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            dtpFechaNacimiento.Value = DateTime.Today;
            txtDNI.Text = "";
            txtEmail.Text = "";
            txtTel.Text = ""; 
            rbDesconocido.Checked = false;
            rbFemenino.Checked = false;
            rbMasculino.Checked = false;
            txtAltura.Text = "";
            txtCalle.Text = "";
            cboEstadoCivil.SelectedValue = -1;
            cboProvincia.SelectedValue = -1;
            cboCiudad.SelectedValue = -1;
            cboBarrio.SelectedValue = -1;
            cboTecnicatura.SelectedValue = -1;
            cboCurso.SelectedValue = -1;
            dgvAlumnos.Rows.Clear();
        }

        private void cboCiudad_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCiudad.SelectedItem != null)
            {
                cboBarrio.Enabled = true;
                Combo.CargarComboBarrio(cboBarrio, "https://localhost:7148/api/Localizaciones/Barrios/" + cboCiudad.SelectedValue);
            }
        }

        //private async Task GuardarAlumnos()
        //{








        //}









        private void btmAgregar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                MessageBox.Show("Debe ingresar un NOMBRE del alumno", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (txtApellido.Text == "")
            {
                MessageBox.Show("Debe ingresar un APELLIDO del alumno", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (txtDNI.Text == "")
            {
                MessageBox.Show("Debe ingresar un DNI del alumno", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (txtEmail.Text == "" || cboEmails.Text.Equals(String.Empty))
            {
                MessageBox.Show("Debe ingresar un E-MAIL del alumno", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (txtTel.Text == "")
            {
                MessageBox.Show("Debe ingresar un Telefono del alumno", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (rbDesconocido.Checked == false && rbFemenino.Checked == false && rbMasculino.Checked == false)
            {
                MessageBox.Show("Debe ingresar un SEXO del alumno", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (txtCalle.Text == "" || txtAltura.Text == "")
            {
                MessageBox.Show("Debe ingresar una CALLE y ALTURA del alumno", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (cboEstadoCivil.SelectedIndex == -1)
            {
                MessageBox.Show("Debe ingresar un ESTADO CIVIL del alumno", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (cboProvincia.SelectedIndex == -1)
            {
                MessageBox.Show("Debe ingresar una PROVINCIA del alumno", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (cboBarrio.SelectedIndex == -1)
            {
                MessageBox.Show("Debe ingresar un BARRIO del alumno", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (cboCiudad.SelectedIndex == -1)
            {
                MessageBox.Show("Debe ingresar una CIUDAD del alumno", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            //if(cboLaboralidad.SelectedIndex == -1)
            //{
            //    MessageBox.Show("Debe ingresar una LABORALIDAD del alumno", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    return;
            //}

            //if(cboHabitacionalidad.SelectedIndex == -1)
            //{
            //    MessageBox.Show("Debe ingresar una HABITACIONALIDAD del alumno", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    return;
            //}

            if(cboTecnicatura.SelectedIndex == -1)
            {
                MessageBox.Show("Debe ingresar una TECNICATURA del alumno", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if(cboCurso.SelectedIndex == -1)
            {
                MessageBox.Show("Debe ingresar un CURSO del alumno", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            foreach (DataGridViewRow row in dgvAlumnos.Rows)
            {
                if (row.Cells["colDniAlu"].Value.ToString().Equals(txtDNI.Text))
                {
                    MessageBox.Show("ALUMNO: " + txtApellido.Text + " - " + txtDNI.Text + " ya se encuentra como detalle!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;

                }
            }



            Alumno alumno = new Alumno();
            
    
            alumno.Nombre = txtNombre.Text;
            alumno.Apellido = txtApellido.Text;
            alumno.FechaNacimiento = dtpFechaNacimiento.Value;
            alumno.Dni = Convert.ToInt32(txtDNI.Text);
            alumno.Telefono = Convert.ToInt32(txtTel.Text);
            string sexo = "";
            if (rbMasculino.Checked)
            {

                alumno.Sexo = Sexos.Masculino;
                sexo = "Masculino";
            }
            else if (rbFemenino.Checked)
            {
                alumno.Sexo = Sexos.Femenino;
                sexo = "Femenino";
            }
            else if (rbDesconocido.Checked)
            {
                alumno.Sexo = Sexos.Desconocido;
                sexo = "Desconocido";
            }
            alumno.Calle = txtCalle.Text;
            alumno.Altura = Convert.ToInt32(txtAltura.Text);
            Barrio b = new Barrio();
            b.Id = Convert.ToInt32(cboBarrio.SelectedValue); 
            b.Nombre= (string)cboBarrio.SelectedText;

            //alumno.Barrio.Id = Convert.ToInt32(cboBarrio.SelectedValue);
            //alumno.Barrio.Nombre = (string)cboBarrio.SelectedItem;

            alumno.Barrio = b;

            Carrera c = new Carrera();
            c.Id= Convert.ToInt32(cboTecnicatura.SelectedValue);
            c.Nombre= (string)cboTecnicatura.SelectedText;
            alumno.Carrera=c;

            //alumno.Carrera.Id = Convert.ToInt32(cboTecnicatura.SelectedValue);
            //alumno.Carrera.Nombre = (string)cboTecnicatura.SelectedItem;
            Curso cu = new Curso();
            cu.Id=Convert.ToInt32(cboTecnicatura.SelectedValue);
            cu.Nombre = (string)cboTecnicatura.SelectedText;

            //alumno.Curso.Id = Convert.ToInt32(cboCurso.SelectedValue);
            //alumno.Curso.Nombre = (string)cboTecnicatura.SelectedItem;

            alumno.Curso = cu;
            alumno.FechaInscripcion = dtpFechaInscripcion.Value;
            alumnos.Add(alumno);
            dgvAlumnos.Rows.Add(new object[] { alumno.Nombre, alumno.Apellido, alumno.FechaNacimiento, alumno.Dni, alumno.Email, alumno.Telefono, sexo, alumno.Calle, alumno.Altura, alumno.EstadoCivil.Descripcion, alumno.Barrio.Ciudad.Provincia.Nombre, alumno.Barrio.Ciudad, alumno.Barrio, alumno.Carrera.Nombre, alumno.Curso.Nombre, alumno.FechaInscripcion });

























        }






















    }

} 