namespace TecnicaturasPresentacion.Principal.Consultas
{
    partial class frmConsulta3
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
            this.dgvConsulta3 = new System.Windows.Forms.DataGridView();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.btnConsultar = new MaterialSkin.Controls.MaterialRaisedButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvConsulta3
            // 
            this.dgvConsulta3.AllowUserToAddRows = false;
            this.dgvConsulta3.AllowUserToDeleteRows = false;
            this.dgvConsulta3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsulta3.Location = new System.Drawing.Point(244, 159);
            this.dgvConsulta3.Name = "dgvConsulta3";
            this.dgvConsulta3.ReadOnly = true;
            this.dgvConsulta3.RowTemplate.Height = 25;
            this.dgvConsulta3.Size = new System.Drawing.Size(240, 150);
            this.dgvConsulta3.TabIndex = 0;
            // 
            // nudCantidad
            // 
            this.nudCantidad.Location = new System.Drawing.Point(244, 95);
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.Size = new System.Drawing.Size(120, 23);
            this.nudCantidad.TabIndex = 1;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Depth = 0;
            this.btnConsultar.Location = new System.Drawing.Point(567, 110);
            this.btnConsultar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Primary = true;
            this.btnConsultar.Size = new System.Drawing.Size(100, 68);
            this.btnConsultar.TabIndex = 2;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // frmConsulta3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(853, 618);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.nudCantidad);
            this.Controls.Add(this.dgvConsulta3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmConsulta3";
            this.Text = "frmConsulta3";
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgvConsulta3;
        private NumericUpDown nudCantidad;
        private MaterialSkin.Controls.MaterialRaisedButton btnConsultar;
    }
}