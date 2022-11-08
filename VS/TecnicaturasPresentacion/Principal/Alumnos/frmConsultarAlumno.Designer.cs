namespace TecnicaturasPresentacion.Principal.Alumnos
{
    partial class frmConsultarAlumno
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnEditar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnBorrar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.dgvAlumno = new System.Windows.Forms.DataGridView();
            this.colLegajo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFechaNac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAltura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCurso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCarrera = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFechaInsc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLaboralidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHabitacionalidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIdBarrio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnConsultar = new MaterialSkin.Controls.MaterialFlatButton();
            this.txtLegajoAlu = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblLegajoAlu = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumno)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEditar
            // 
            this.btnEditar.Depth = 0;
            this.btnEditar.Location = new System.Drawing.Point(161, 444);
            this.btnEditar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Primary = true;
            this.btnEditar.Size = new System.Drawing.Size(180, 36);
            this.btnEditar.TabIndex = 12;
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnBorrar
            // 
            this.btnBorrar.Depth = 0;
            this.btnBorrar.Location = new System.Drawing.Point(463, 444);
            this.btnBorrar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Primary = true;
            this.btnBorrar.Size = new System.Drawing.Size(180, 36);
            this.btnBorrar.TabIndex = 11;
            this.btnBorrar.Text = "BORRAR";
            this.btnBorrar.UseVisualStyleBackColor = true;
            // 
            // dgvAlumno
            // 
            this.dgvAlumno.AllowUserToAddRows = false;
            this.dgvAlumno.AllowUserToDeleteRows = false;
            this.dgvAlumno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlumno.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colLegajo,
            this.colNombre,
            this.colApellido,
            this.colFechaNac,
            this.colDNI,
            this.colEmail,
            this.colTelefono,
            this.colCalle,
            this.colAltura,
            this.colSexo,
            this.colCurso,
            this.colCarrera,
            this.colFechaInsc,
            this.colLaboralidad,
            this.colHabitacionalidad,
            this.colIdBarrio});
            this.dgvAlumno.Location = new System.Drawing.Point(12, 190);
            this.dgvAlumno.Name = "dgvAlumno";
            this.dgvAlumno.ReadOnly = true;
            this.dgvAlumno.RowTemplate.Height = 25;
            this.dgvAlumno.Size = new System.Drawing.Size(829, 227);
            this.dgvAlumno.TabIndex = 10;
            // 
            // colLegajo
            // 
            this.colLegajo.HeaderText = "Legajo";
            this.colLegajo.Name = "colLegajo";
            this.colLegajo.ReadOnly = true;
            // 
            // colNombre
            // 
            this.colNombre.HeaderText = "Nombre";
            this.colNombre.Name = "colNombre";
            this.colNombre.ReadOnly = true;
            // 
            // colApellido
            // 
            this.colApellido.HeaderText = "Apellido";
            this.colApellido.Name = "colApellido";
            this.colApellido.ReadOnly = true;
            // 
            // colFechaNac
            // 
            this.colFechaNac.HeaderText = "Fecha de Nacimiento";
            this.colFechaNac.Name = "colFechaNac";
            this.colFechaNac.ReadOnly = true;
            // 
            // colDNI
            // 
            this.colDNI.HeaderText = "DNI";
            this.colDNI.Name = "colDNI";
            this.colDNI.ReadOnly = true;
            // 
            // colEmail
            // 
            this.colEmail.HeaderText = "Email";
            this.colEmail.Name = "colEmail";
            this.colEmail.ReadOnly = true;
            // 
            // colTelefono
            // 
            this.colTelefono.HeaderText = "Telefono";
            this.colTelefono.Name = "colTelefono";
            this.colTelefono.ReadOnly = true;
            // 
            // colCalle
            // 
            this.colCalle.HeaderText = "Calle";
            this.colCalle.Name = "colCalle";
            this.colCalle.ReadOnly = true;
            // 
            // colAltura
            // 
            this.colAltura.HeaderText = "Altura";
            this.colAltura.Name = "colAltura";
            this.colAltura.ReadOnly = true;
            // 
            // colSexo
            // 
            this.colSexo.HeaderText = "Sexo";
            this.colSexo.Name = "colSexo";
            this.colSexo.ReadOnly = true;
            // 
            // colCurso
            // 
            this.colCurso.HeaderText = "Curso";
            this.colCurso.Name = "colCurso";
            this.colCurso.ReadOnly = true;
            // 
            // colCarrera
            // 
            this.colCarrera.HeaderText = "Carrera";
            this.colCarrera.Name = "colCarrera";
            this.colCarrera.ReadOnly = true;
            // 
            // colFechaInsc
            // 
            this.colFechaInsc.HeaderText = "Fecha de Inscripción";
            this.colFechaInsc.Name = "colFechaInsc";
            this.colFechaInsc.ReadOnly = true;
            // 
            // colLaboralidad
            // 
            this.colLaboralidad.HeaderText = "Laboralidad";
            this.colLaboralidad.Name = "colLaboralidad";
            this.colLaboralidad.ReadOnly = true;
            // 
            // colHabitacionalidad
            // 
            this.colHabitacionalidad.HeaderText = "Habitacionalidad";
            this.colHabitacionalidad.Name = "colHabitacionalidad";
            this.colHabitacionalidad.ReadOnly = true;
            // 
            // colIdBarrio
            // 
            this.colIdBarrio.HeaderText = "Barrio";
            this.colIdBarrio.Name = "colIdBarrio";
            this.colIdBarrio.ReadOnly = true;
            // 
            // btnConsultar
            // 
            this.btnConsultar.AutoSize = true;
            this.btnConsultar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnConsultar.Depth = 0;
            this.btnConsultar.Location = new System.Drawing.Point(552, 138);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnConsultar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Primary = false;
            this.btnConsultar.Size = new System.Drawing.Size(91, 36);
            this.btnConsultar.TabIndex = 9;
            this.btnConsultar.Text = "CONSULTAR";
            this.btnConsultar.UseVisualStyleBackColor = true;
            // 
            // txtLegajoAlu
            // 
            this.txtLegajoAlu.Depth = 0;
            this.txtLegajoAlu.Hint = "";
            this.txtLegajoAlu.Location = new System.Drawing.Point(305, 146);
            this.txtLegajoAlu.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtLegajoAlu.Name = "txtLegajoAlu";
            this.txtLegajoAlu.PasswordChar = '\0';
            this.txtLegajoAlu.SelectedText = "";
            this.txtLegajoAlu.SelectionLength = 0;
            this.txtLegajoAlu.SelectionStart = 0;
            this.txtLegajoAlu.Size = new System.Drawing.Size(240, 23);
            this.txtLegajoAlu.TabIndex = 8;
            this.txtLegajoAlu.UseSystemPasswordChar = false;
            // 
            // lblLegajoAlu
            // 
            this.lblLegajoAlu.AutoSize = true;
            this.lblLegajoAlu.Depth = 0;
            this.lblLegajoAlu.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLegajoAlu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblLegajoAlu.Location = new System.Drawing.Point(161, 146);
            this.lblLegajoAlu.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblLegajoAlu.Name = "lblLegajoAlu";
            this.lblLegajoAlu.Size = new System.Drawing.Size(138, 19);
            this.lblLegajoAlu.TabIndex = 7;
            this.lblLegajoAlu.Text = "Legajo del Alumno:";
            // 
            // frmConsultarAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(853, 618);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.dgvAlumno);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.txtLegajoAlu);
            this.Controls.Add(this.lblLegajoAlu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmConsultarAlumno";
            this.Text = "frmConsultarAlumno";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumno)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton btnEditar;
        private MaterialSkin.Controls.MaterialRaisedButton btnBorrar;
        private DataGridView dgvAlumno;
        private DataGridViewTextBoxColumn colLegajo;
        private DataGridViewTextBoxColumn colNombre;
        private DataGridViewTextBoxColumn colApellido;
        private DataGridViewTextBoxColumn colFechaNac;
        private DataGridViewTextBoxColumn colDNI;
        private DataGridViewTextBoxColumn colEmail;
        private DataGridViewTextBoxColumn colTelefono;
        private DataGridViewTextBoxColumn colCalle;
        private DataGridViewTextBoxColumn colAltura;
        private DataGridViewTextBoxColumn colSexo;
        private DataGridViewTextBoxColumn colCurso;
        private DataGridViewTextBoxColumn colCarrera;
        private DataGridViewTextBoxColumn colFechaInsc;
        private DataGridViewTextBoxColumn colLaboralidad;
        private DataGridViewTextBoxColumn colHabitacionalidad;
        private DataGridViewTextBoxColumn colIdBarrio;
        private MaterialSkin.Controls.MaterialFlatButton btnConsultar;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtLegajoAlu;
        private MaterialSkin.Controls.MaterialLabel lblLegajoAlu;
    }
}