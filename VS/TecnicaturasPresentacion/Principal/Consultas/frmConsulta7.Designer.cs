namespace TecnicaturasPresentacion.Principal.Consultas
{
    partial class frmConsulta7
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
            this.dgvConsulta7 = new System.Windows.Forms.DataGridView();
            this.btnConsultar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtAño = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblCanti = new System.Windows.Forms.Label();
            this.lblIngrese = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta7)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvConsulta7
            // 
            this.dgvConsulta7.AllowUserToAddRows = false;
            this.dgvConsulta7.AllowUserToDeleteRows = false;
            this.dgvConsulta7.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsulta7.Location = new System.Drawing.Point(82, 192);
            this.dgvConsulta7.Name = "dgvConsulta7";
            this.dgvConsulta7.ReadOnly = true;
            this.dgvConsulta7.RowTemplate.Height = 25;
            this.dgvConsulta7.Size = new System.Drawing.Size(673, 172);
            this.dgvConsulta7.TabIndex = 0;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Depth = 0;
            this.btnConsultar.Location = new System.Drawing.Point(664, 136);
            this.btnConsultar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Primary = true;
            this.btnConsultar.Size = new System.Drawing.Size(91, 36);
            this.btnConsultar.TabIndex = 1;
            this.btnConsultar.Text = "CONSULTAR";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // txtAño
            // 
            this.txtAño.Depth = 0;
            this.txtAño.Hint = "";
            this.txtAño.Location = new System.Drawing.Point(260, 140);
            this.txtAño.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtAño.Name = "txtAño";
            this.txtAño.PasswordChar = '\0';
            this.txtAño.SelectedText = "";
            this.txtAño.SelectionLength = 0;
            this.txtAño.SelectionStart = 0;
            this.txtAño.Size = new System.Drawing.Size(108, 23);
            this.txtAño.TabIndex = 2;
            this.txtAño.UseSystemPasswordChar = false;
            // 
            // lblCanti
            // 
            this.lblCanti.AutoSize = true;
            this.lblCanti.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCanti.Location = new System.Drawing.Point(82, 79);
            this.lblCanti.Name = "lblCanti";
            this.lblCanti.Size = new System.Drawing.Size(459, 40);
            this.lblCanti.TabIndex = 10;
            this.lblCanti.Text = "Alumnos que rindieron este año";
            // 
            // lblIngrese
            // 
            this.lblIngrese.AutoSize = true;
            this.lblIngrese.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblIngrese.Location = new System.Drawing.Point(82, 142);
            this.lblIngrese.Name = "lblIngrese";
            this.lblIngrese.Size = new System.Drawing.Size(172, 21);
            this.lblIngrese.TabIndex = 11;
            this.lblIngrese.Text = "Ingresar aqui el AÑO:";
            // 
            // frmConsulta7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(853, 618);
            this.Controls.Add(this.lblIngrese);
            this.Controls.Add(this.lblCanti);
            this.Controls.Add(this.txtAño);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.dgvConsulta7);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmConsulta7";
            this.Text = "frmConsulta7";
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvConsulta7;
        private MaterialSkin.Controls.MaterialRaisedButton btnConsultar;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtAño;
        private Label lblCanti;
        private Label lblIngrese;
    }
}