namespace TecnicaturasPresentacion.Principal.Consultas
{
    partial class frmConsulta2
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
            this.dgvCantidadmateria = new System.Windows.Forms.DataGridView();
            this.cboMateria = new System.Windows.Forms.ComboBox();
            this.lblMateria = new MaterialSkin.Controls.MaterialLabel();
            this.btnConsultar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.cboTecnicaturas = new System.Windows.Forms.ComboBox();
            this.lblTecnicatura = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCantidadmateria)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCantidadmateria
            // 
            this.dgvCantidadmateria.AllowUserToAddRows = false;
            this.dgvCantidadmateria.AllowUserToDeleteRows = false;
            this.dgvCantidadmateria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCantidadmateria.Location = new System.Drawing.Point(12, 175);
            this.dgvCantidadmateria.Name = "dgvCantidadmateria";
            this.dgvCantidadmateria.ReadOnly = true;
            this.dgvCantidadmateria.RowTemplate.Height = 25;
            this.dgvCantidadmateria.Size = new System.Drawing.Size(829, 193);
            this.dgvCantidadmateria.TabIndex = 0;
            // 
            // cboMateria
            // 
            this.cboMateria.FormattingEnabled = true;
            this.cboMateria.Location = new System.Drawing.Point(379, 100);
            this.cboMateria.Name = "cboMateria";
            this.cboMateria.Size = new System.Drawing.Size(173, 23);
            this.cboMateria.TabIndex = 7;
            // 
            // lblMateria
            // 
            this.lblMateria.AutoSize = true;
            this.lblMateria.Depth = 0;
            this.lblMateria.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMateria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblMateria.Location = new System.Drawing.Point(379, 78);
            this.lblMateria.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblMateria.Name = "lblMateria";
            this.lblMateria.Size = new System.Drawing.Size(60, 19);
            this.lblMateria.TabIndex = 6;
            this.lblMateria.Text = "Materia";
            // 
            // btnConsultar
            // 
            this.btnConsultar.Depth = 0;
            this.btnConsultar.Location = new System.Drawing.Point(732, 115);
            this.btnConsultar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Primary = true;
            this.btnConsultar.Size = new System.Drawing.Size(109, 44);
            this.btnConsultar.TabIndex = 8;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // cboTecnicaturas
            // 
            this.cboTecnicaturas.FormattingEnabled = true;
            this.cboTecnicaturas.Location = new System.Drawing.Point(181, 100);
            this.cboTecnicaturas.Name = "cboTecnicaturas";
            this.cboTecnicaturas.Size = new System.Drawing.Size(173, 23);
            this.cboTecnicaturas.TabIndex = 11;
            this.cboTecnicaturas.SelectedIndexChanged += new System.EventHandler(this.cboTecnicaturas_SelectedIndexChanged);
            // 
            // lblTecnicatura
            // 
            this.lblTecnicatura.AutoSize = true;
            this.lblTecnicatura.Depth = 0;
            this.lblTecnicatura.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTecnicatura.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTecnicatura.Location = new System.Drawing.Point(181, 78);
            this.lblTecnicatura.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTecnicatura.Name = "lblTecnicatura";
            this.lblTecnicatura.Size = new System.Drawing.Size(88, 19);
            this.lblTecnicatura.TabIndex = 10;
            this.lblTecnicatura.Text = "Tecnicatura";
            // 
            // frmConsulta2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(853, 618);
            this.Controls.Add(this.cboTecnicaturas);
            this.Controls.Add(this.lblTecnicatura);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.cboMateria);
            this.Controls.Add(this.lblMateria);
            this.Controls.Add(this.dgvCantidadmateria);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmConsulta2";
            this.Text = "frmConsulta2";
            this.Load += new System.EventHandler(this.frmConsulta2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCantidadmateria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvCantidadmateria;
        private ComboBox cboMateria;
        private MaterialSkin.Controls.MaterialLabel lblMateria;
        private MaterialSkin.Controls.MaterialRaisedButton btnConsultar;
        private ComboBox cboTecnicaturas;
        private MaterialSkin.Controls.MaterialLabel lblTecnicatura;
    }
}