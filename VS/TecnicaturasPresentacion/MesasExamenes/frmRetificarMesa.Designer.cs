namespace TecnicaturasPresentacion.MesasExamenes
{
    partial class frmRetificarMesa
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
            this.btnBorrar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnEditar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtIdExamen = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblIdMesaExamen = new MaterialSkin.Controls.MaterialLabel();
            this.dgvExamen = new System.Windows.Forms.DataGridView();
            this.colIdMesaExamen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTurnoExamen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMateria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProfesor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMesa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLegajo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnConsultar = new MaterialSkin.Controls.MaterialRaisedButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExamen)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBorrar
            // 
            this.btnBorrar.Depth = 0;
            this.btnBorrar.Location = new System.Drawing.Point(548, 462);
            this.btnBorrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBorrar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Primary = true;
            this.btnBorrar.Size = new System.Drawing.Size(172, 38);
            this.btnBorrar.TabIndex = 13;
            this.btnBorrar.Text = "BORRAR";
            this.btnBorrar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Depth = 0;
            this.btnEditar.Location = new System.Drawing.Point(135, 462);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEditar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Primary = true;
            this.btnEditar.Size = new System.Drawing.Size(172, 38);
            this.btnEditar.TabIndex = 12;
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // txtIdExamen
            // 
            this.txtIdExamen.Depth = 0;
            this.txtIdExamen.Hint = "";
            this.txtIdExamen.Location = new System.Drawing.Point(298, 128);
            this.txtIdExamen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIdExamen.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtIdExamen.Name = "txtIdExamen";
            this.txtIdExamen.PasswordChar = '\0';
            this.txtIdExamen.SelectedText = "";
            this.txtIdExamen.SelectionLength = 0;
            this.txtIdExamen.SelectionStart = 0;
            this.txtIdExamen.Size = new System.Drawing.Size(244, 23);
            this.txtIdExamen.TabIndex = 11;
            this.txtIdExamen.UseSystemPasswordChar = false;
            // 
            // lblIdMesaExamen
            // 
            this.lblIdMesaExamen.AutoSize = true;
            this.lblIdMesaExamen.Depth = 0;
            this.lblIdMesaExamen.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblIdMesaExamen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblIdMesaExamen.Location = new System.Drawing.Point(135, 128);
            this.lblIdMesaExamen.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblIdMesaExamen.Name = "lblIdMesaExamen";
            this.lblIdMesaExamen.Size = new System.Drawing.Size(145, 19);
            this.lblIdMesaExamen.TabIndex = 10;
            this.lblIdMesaExamen.Text = "ID Mesa de Exámen:";
            // 
            // dgvExamen
            // 
            this.dgvExamen.AllowUserToAddRows = false;
            this.dgvExamen.AllowUserToDeleteRows = false;
            this.dgvExamen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExamen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIdMesaExamen,
            this.colFecha,
            this.colTurnoExamen,
            this.colMateria,
            this.colProfesor,
            this.colMesa,
            this.colLegajo,
            this.colNota});
            this.dgvExamen.Location = new System.Drawing.Point(10, 179);
            this.dgvExamen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvExamen.Name = "dgvExamen";
            this.dgvExamen.ReadOnly = true;
            this.dgvExamen.RowHeadersWidth = 51;
            this.dgvExamen.RowTemplate.Height = 29;
            this.dgvExamen.Size = new System.Drawing.Size(832, 254);
            this.dgvExamen.TabIndex = 9;
            // 
            // colIdMesaExamen
            // 
            this.colIdMesaExamen.HeaderText = "ID Mesa de Exámen";
            this.colIdMesaExamen.MinimumWidth = 6;
            this.colIdMesaExamen.Name = "colIdMesaExamen";
            this.colIdMesaExamen.ReadOnly = true;
            this.colIdMesaExamen.Width = 125;
            // 
            // colFecha
            // 
            this.colFecha.HeaderText = "Fecha Exámen";
            this.colFecha.MinimumWidth = 6;
            this.colFecha.Name = "colFecha";
            this.colFecha.ReadOnly = true;
            this.colFecha.Width = 125;
            // 
            // colTurnoExamen
            // 
            this.colTurnoExamen.HeaderText = "Turno";
            this.colTurnoExamen.MinimumWidth = 6;
            this.colTurnoExamen.Name = "colTurnoExamen";
            this.colTurnoExamen.ReadOnly = true;
            this.colTurnoExamen.Width = 125;
            // 
            // colMateria
            // 
            this.colMateria.HeaderText = "Materia";
            this.colMateria.MinimumWidth = 6;
            this.colMateria.Name = "colMateria";
            this.colMateria.ReadOnly = true;
            this.colMateria.Width = 125;
            // 
            // colProfesor
            // 
            this.colProfesor.HeaderText = "Profesor";
            this.colProfesor.MinimumWidth = 6;
            this.colProfesor.Name = "colProfesor";
            this.colProfesor.ReadOnly = true;
            this.colProfesor.Width = 125;
            // 
            // colMesa
            // 
            this.colMesa.HeaderText = "Mesa";
            this.colMesa.MinimumWidth = 6;
            this.colMesa.Name = "colMesa";
            this.colMesa.ReadOnly = true;
            this.colMesa.Width = 125;
            // 
            // colLegajo
            // 
            this.colLegajo.HeaderText = "Legajo Alumno";
            this.colLegajo.MinimumWidth = 6;
            this.colLegajo.Name = "colLegajo";
            this.colLegajo.ReadOnly = true;
            this.colLegajo.Width = 125;
            // 
            // colNota
            // 
            this.colNota.HeaderText = "Nota";
            this.colNota.MinimumWidth = 6;
            this.colNota.Name = "colNota";
            this.colNota.ReadOnly = true;
            this.colNota.Width = 125;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Depth = 0;
            this.btnConsultar.Location = new System.Drawing.Point(548, 118);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConsultar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Primary = true;
            this.btnConsultar.Size = new System.Drawing.Size(172, 38);
            this.btnConsultar.TabIndex = 8;
            this.btnConsultar.Text = "CONSULTAR";
            this.btnConsultar.UseVisualStyleBackColor = true;
            // 
            // frmRetificarMesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(853, 618);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.txtIdExamen);
            this.Controls.Add(this.lblIdMesaExamen);
            this.Controls.Add(this.dgvExamen);
            this.Controls.Add(this.btnConsultar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRetificarMesa";
            this.Text = "frmRetificarMesa";
            ((System.ComponentModel.ISupportInitialize)(this.dgvExamen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton btnBorrar;
        private MaterialSkin.Controls.MaterialRaisedButton btnEditar;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtIdExamen;
        private MaterialSkin.Controls.MaterialLabel lblIdMesaExamen;
        private DataGridView dgvExamen;
        private DataGridViewTextBoxColumn colIdMesaExamen;
        private DataGridViewTextBoxColumn colFecha;
        private DataGridViewTextBoxColumn colTurnoExamen;
        private DataGridViewTextBoxColumn colMateria;
        private DataGridViewTextBoxColumn colProfesor;
        private DataGridViewTextBoxColumn colMesa;
        private DataGridViewTextBoxColumn colLegajo;
        private DataGridViewTextBoxColumn colNota;
        private MaterialSkin.Controls.MaterialRaisedButton btnConsultar;
    }
}