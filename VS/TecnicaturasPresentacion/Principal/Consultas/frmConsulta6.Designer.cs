namespace TecnicaturasPresentacion.Principal.Consultas
{
    partial class frmConsulta6
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
            this.dgvConsulta6 = new System.Windows.Forms.DataGridView();
            this.btnConsultar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.lblCanti = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta6)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvConsulta6
            // 
            this.dgvConsulta6.AllowUserToAddRows = false;
            this.dgvConsulta6.AllowUserToDeleteRows = false;
            this.dgvConsulta6.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsulta6.Location = new System.Drawing.Point(81, 185);
            this.dgvConsulta6.Name = "dgvConsulta6";
            this.dgvConsulta6.ReadOnly = true;
            this.dgvConsulta6.RowTemplate.Height = 25;
            this.dgvConsulta6.Size = new System.Drawing.Size(673, 172);
            this.dgvConsulta6.TabIndex = 0;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Depth = 0;
            this.btnConsultar.Location = new System.Drawing.Point(604, 138);
            this.btnConsultar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Primary = true;
            this.btnConsultar.Size = new System.Drawing.Size(150, 41);
            this.btnConsultar.TabIndex = 1;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // lblCanti
            // 
            this.lblCanti.AutoSize = true;
            this.lblCanti.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCanti.Location = new System.Drawing.Point(81, 138);
            this.lblCanti.Name = "lblCanti";
            this.lblCanti.Size = new System.Drawing.Size(455, 40);
            this.lblCanti.TabIndex = 10;
            this.lblCanti.Text = "Profesores proximos a Jubilarse";
            // 
            // frmConsulta6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(853, 618);
            this.Controls.Add(this.lblCanti);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.dgvConsulta6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmConsulta6";
            this.Text = "frmConsulta6";
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvConsulta6;
        private MaterialSkin.Controls.MaterialRaisedButton btnConsultar;
        private Label lblCanti;
    }
}