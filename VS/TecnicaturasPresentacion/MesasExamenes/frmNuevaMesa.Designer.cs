namespace TecnicaturasPresentacion.MesasExamenes
{
    partial class frmNuevaMesa
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
            this.txtMesaFecha = new MaterialSkin.Controls.MaterialLabel();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.lblTurnoExamen = new MaterialSkin.Controls.MaterialLabel();
            this.cboTurnoExamen = new System.Windows.Forms.ComboBox();
            this.lblMateria = new MaterialSkin.Controls.MaterialLabel();
            this.cboMateria = new System.Windows.Forms.ComboBox();
            this.lblProfesor = new MaterialSkin.Controls.MaterialLabel();
            this.cboProfesor = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblTecnicatura = new MaterialSkin.Controls.MaterialLabel();
            this.lblLegajoAlumno = new MaterialSkin.Controls.MaterialLabel();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.lblNota = new MaterialSkin.Controls.MaterialLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnCargar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnAgregar = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.txtLegajoAlumno = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.colIdMesa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFechaExamen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTurnoExamen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTecnincatua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMateria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProfesor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLegajoAlumno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMesaFecha
            // 
            this.txtMesaFecha.AutoSize = true;
            this.txtMesaFecha.Depth = 0;
            this.txtMesaFecha.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMesaFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtMesaFecha.Location = new System.Drawing.Point(75, 9);
            this.txtMesaFecha.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtMesaFecha.Name = "txtMesaFecha";
            this.txtMesaFecha.Size = new System.Drawing.Size(126, 19);
            this.txtMesaFecha.TabIndex = 0;
            this.txtMesaFecha.Text = "Fecha de Exámen";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(18, 37);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 1;
            // 
            // lblTurnoExamen
            // 
            this.lblTurnoExamen.AutoSize = true;
            this.lblTurnoExamen.Depth = 0;
            this.lblTurnoExamen.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTurnoExamen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTurnoExamen.Location = new System.Drawing.Point(296, 37);
            this.lblTurnoExamen.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTurnoExamen.Name = "lblTurnoExamen";
            this.lblTurnoExamen.Size = new System.Drawing.Size(125, 19);
            this.lblTurnoExamen.TabIndex = 2;
            this.lblTurnoExamen.Text = "Turno de Exámen";
            // 
            // cboTurnoExamen
            // 
            this.cboTurnoExamen.FormattingEnabled = true;
            this.cboTurnoExamen.Location = new System.Drawing.Point(296, 59);
            this.cboTurnoExamen.Name = "cboTurnoExamen";
            this.cboTurnoExamen.Size = new System.Drawing.Size(173, 23);
            this.cboTurnoExamen.TabIndex = 3;
            // 
            // lblMateria
            // 
            this.lblMateria.AutoSize = true;
            this.lblMateria.Depth = 0;
            this.lblMateria.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMateria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblMateria.Location = new System.Drawing.Point(296, 102);
            this.lblMateria.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblMateria.Name = "lblMateria";
            this.lblMateria.Size = new System.Drawing.Size(60, 19);
            this.lblMateria.TabIndex = 4;
            this.lblMateria.Text = "Materia";
            // 
            // cboMateria
            // 
            this.cboMateria.FormattingEnabled = true;
            this.cboMateria.Location = new System.Drawing.Point(296, 124);
            this.cboMateria.Name = "cboMateria";
            this.cboMateria.Size = new System.Drawing.Size(173, 23);
            this.cboMateria.TabIndex = 5;
            // 
            // lblProfesor
            // 
            this.lblProfesor.AutoSize = true;
            this.lblProfesor.Depth = 0;
            this.lblProfesor.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblProfesor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblProfesor.Location = new System.Drawing.Point(511, 102);
            this.lblProfesor.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblProfesor.Name = "lblProfesor";
            this.lblProfesor.Size = new System.Drawing.Size(67, 19);
            this.lblProfesor.TabIndex = 6;
            this.lblProfesor.Text = "Profesor";
            // 
            // cboProfesor
            // 
            this.cboProfesor.FormattingEnabled = true;
            this.cboProfesor.Location = new System.Drawing.Point(511, 124);
            this.cboProfesor.Name = "cboProfesor";
            this.cboProfesor.Size = new System.Drawing.Size(173, 23);
            this.cboProfesor.TabIndex = 7;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(511, 59);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(173, 23);
            this.comboBox1.TabIndex = 9;
            // 
            // lblTecnicatura
            // 
            this.lblTecnicatura.AutoSize = true;
            this.lblTecnicatura.Depth = 0;
            this.lblTecnicatura.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTecnicatura.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTecnicatura.Location = new System.Drawing.Point(511, 37);
            this.lblTecnicatura.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTecnicatura.Name = "lblTecnicatura";
            this.lblTecnicatura.Size = new System.Drawing.Size(88, 19);
            this.lblTecnicatura.TabIndex = 8;
            this.lblTecnicatura.Text = "Tecnicatura";
            // 
            // lblLegajoAlumno
            // 
            this.lblLegajoAlumno.AutoSize = true;
            this.lblLegajoAlumno.Depth = 0;
            this.lblLegajoAlumno.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLegajoAlumno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblLegajoAlumno.Location = new System.Drawing.Point(296, 165);
            this.lblLegajoAlumno.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblLegajoAlumno.Name = "lblLegajoAlumno";
            this.lblLegajoAlumno.Size = new System.Drawing.Size(138, 19);
            this.lblLegajoAlumno.TabIndex = 10;
            this.lblLegajoAlumno.Text = "Legajo del Alumno:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(511, 187);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(55, 23);
            this.numericUpDown1.TabIndex = 12;
            // 
            // lblNota
            // 
            this.lblNota.AutoSize = true;
            this.lblNota.Depth = 0;
            this.lblNota.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNota.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblNota.Location = new System.Drawing.Point(511, 165);
            this.lblNota.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblNota.Name = "lblNota";
            this.lblNota.Size = new System.Drawing.Size(42, 19);
            this.lblNota.TabIndex = 13;
            this.lblNota.Text = "Nota";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIdMesa,
            this.colFechaExamen,
            this.colTurnoExamen,
            this.colTecnincatua,
            this.colMateria,
            this.colProfesor,
            this.colLegajoAlumno,
            this.colNota});
            this.dataGridView1.Location = new System.Drawing.Point(12, 224);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(687, 308);
            this.dataGridView1.TabIndex = 14;
            // 
            // btnCargar
            // 
            this.btnCargar.Depth = 0;
            this.btnCargar.Location = new System.Drawing.Point(233, 547);
            this.btnCargar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Primary = true;
            this.btnCargar.Size = new System.Drawing.Size(218, 35);
            this.btnCargar.TabIndex = 15;
            this.btnCargar.Text = "CARGAR";
            this.btnCargar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.AutoSize = true;
            this.btnAgregar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAgregar.Depth = 0;
            this.btnAgregar.Location = new System.Drawing.Point(610, 178);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAgregar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Primary = false;
            this.btnAgregar.Size = new System.Drawing.Size(74, 36);
            this.btnAgregar.TabIndex = 16;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(279, 159);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(420, 2);
            this.materialDivider1.TabIndex = 17;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // txtLegajoAlumno
            // 
            this.txtLegajoAlumno.Depth = 0;
            this.txtLegajoAlumno.Hint = "";
            this.txtLegajoAlumno.Location = new System.Drawing.Point(296, 187);
            this.txtLegajoAlumno.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtLegajoAlumno.Name = "txtLegajoAlumno";
            this.txtLegajoAlumno.PasswordChar = '\0';
            this.txtLegajoAlumno.SelectedText = "";
            this.txtLegajoAlumno.SelectionLength = 0;
            this.txtLegajoAlumno.SelectionStart = 0;
            this.txtLegajoAlumno.Size = new System.Drawing.Size(173, 23);
            this.txtLegajoAlumno.TabIndex = 18;
            this.txtLegajoAlumno.UseSystemPasswordChar = false;
            // 
            // colIdMesa
            // 
            this.colIdMesa.HeaderText = "IdMesa";
            this.colIdMesa.Name = "colIdMesa";
            this.colIdMesa.Visible = false;
            // 
            // colFechaExamen
            // 
            this.colFechaExamen.HeaderText = "Fecha de Examen";
            this.colFechaExamen.Name = "colFechaExamen";
            // 
            // colTurnoExamen
            // 
            this.colTurnoExamen.HeaderText = "Turno de Examen";
            this.colTurnoExamen.Name = "colTurnoExamen";
            // 
            // colTecnincatua
            // 
            this.colTecnincatua.HeaderText = "Tecnicatura";
            this.colTecnincatua.Name = "colTecnincatua";
            // 
            // colMateria
            // 
            this.colMateria.HeaderText = "Materia";
            this.colMateria.Name = "colMateria";
            // 
            // colProfesor
            // 
            this.colProfesor.HeaderText = "Profesor";
            this.colProfesor.Name = "colProfesor";
            // 
            // colLegajoAlumno
            // 
            this.colLegajoAlumno.HeaderText = "Legajo";
            this.colLegajoAlumno.Name = "colLegajoAlumno";
            // 
            // colNota
            // 
            this.colNota.HeaderText = "Nota";
            this.colNota.Name = "colNota";
            // 
            // frmNuevaMesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(711, 594);
            this.Controls.Add(this.txtLegajoAlumno);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblNota);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.lblLegajoAlumno);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblTecnicatura);
            this.Controls.Add(this.cboProfesor);
            this.Controls.Add(this.lblProfesor);
            this.Controls.Add(this.cboMateria);
            this.Controls.Add(this.lblMateria);
            this.Controls.Add(this.cboTurnoExamen);
            this.Controls.Add(this.lblTurnoExamen);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.txtMesaFecha);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmNuevaMesa";
            this.Text = "frmNuevaMesa";
            this.Load += new System.EventHandler(this.frmNuevaMesa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel txtMesaFecha;
        private MonthCalendar monthCalendar1;
        private MaterialSkin.Controls.MaterialLabel lblTurnoExamen;
        private ComboBox cboTurnoExamen;
        private MaterialSkin.Controls.MaterialLabel lblMateria;
        private ComboBox cboMateria;
        private MaterialSkin.Controls.MaterialLabel lblProfesor;
        private ComboBox cboProfesor;
        private ComboBox comboBox1;
        private MaterialSkin.Controls.MaterialLabel lblTecnicatura;
        private MaterialSkin.Controls.MaterialLabel lblLegajoAlumno;
        private NumericUpDown numericUpDown1;
        private MaterialSkin.Controls.MaterialLabel lblNota;
        private DataGridView dataGridView1;
        private MaterialSkin.Controls.MaterialRaisedButton btnCargar;
        private MaterialSkin.Controls.MaterialFlatButton btnAgregar;
        public MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtLegajoAlumno;
        private DataGridViewTextBoxColumn colIdMesa;
        private DataGridViewTextBoxColumn colFechaExamen;
        private DataGridViewTextBoxColumn colTurnoExamen;
        private DataGridViewTextBoxColumn colTecnincatua;
        private DataGridViewTextBoxColumn colMateria;
        private DataGridViewTextBoxColumn colProfesor;
        private DataGridViewTextBoxColumn colLegajoAlumno;
        private DataGridViewTextBoxColumn colNota;
    }
}