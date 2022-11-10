namespace TecnicaturasPresentacion.Principal.Consultas
{
    partial class frmConsulta5
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
            this.dgvConsulta5 = new System.Windows.Forms.DataGridView();
            this.lblObtenerProm = new System.Windows.Forms.Label();
            this.btnConsultar = new MaterialSkin.Controls.MaterialRaisedButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta5)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvConsulta5
            // 
            this.dgvConsulta5.AllowUserToAddRows = false;
            this.dgvConsulta5.AllowUserToDeleteRows = false;
            this.dgvConsulta5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsulta5.Location = new System.Drawing.Point(132, 178);
            this.dgvConsulta5.Name = "dgvConsulta5";
            this.dgvConsulta5.ReadOnly = true;
            this.dgvConsulta5.RowTemplate.Height = 25;
            this.dgvConsulta5.Size = new System.Drawing.Size(549, 150);
            this.dgvConsulta5.TabIndex = 0;
            // 
            // lblObtenerProm
            // 
            this.lblObtenerProm.AutoSize = true;
            this.lblObtenerProm.Location = new System.Drawing.Point(338, 91);
            this.lblObtenerProm.Name = "lblObtenerProm";
            this.lblObtenerProm.Size = new System.Drawing.Size(120, 15);
            this.lblObtenerProm.TabIndex = 1;
            this.lblObtenerProm.Text = "PROMEDIO DE EDAD ";
            // 
            // btnConsultar
            // 
            this.btnConsultar.Depth = 0;
            this.btnConsultar.Location = new System.Drawing.Point(576, 118);
            this.btnConsultar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Primary = true;
            this.btnConsultar.Size = new System.Drawing.Size(134, 37);
            this.btnConsultar.TabIndex = 2;
            this.btnConsultar.Text = "CONSULTAR";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // frmConsulta5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(853, 618);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.lblObtenerProm);
            this.Controls.Add(this.dgvConsulta5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmConsulta5";
            this.Text = "frmConsulta5";
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvConsulta5;
        private Label lblObtenerProm;
        private MaterialSkin.Controls.MaterialRaisedButton btnConsultar;
    }
}