namespace TecnicaturasPresentacion.Principal.Consultas
{
    partial class frmConsulta4
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtPromedio = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnConsultar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.lblCanti = new System.Windows.Forms.Label();
            this.lblIngrese = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(88, 217);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(673, 172);
            this.dataGridView1.TabIndex = 0;
            // 
            // txtPromedio
            // 
            this.txtPromedio.Depth = 0;
            this.txtPromedio.Hint = "";
            this.txtPromedio.Location = new System.Drawing.Point(530, 175);
            this.txtPromedio.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPromedio.Name = "txtPromedio";
            this.txtPromedio.PasswordChar = '\0';
            this.txtPromedio.SelectedText = "";
            this.txtPromedio.SelectionLength = 0;
            this.txtPromedio.SelectionStart = 0;
            this.txtPromedio.Size = new System.Drawing.Size(100, 23);
            this.txtPromedio.TabIndex = 1;
            this.txtPromedio.UseSystemPasswordChar = false;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Depth = 0;
            this.btnConsultar.Location = new System.Drawing.Point(649, 168);
            this.btnConsultar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Primary = true;
            this.btnConsultar.Size = new System.Drawing.Size(112, 43);
            this.btnConsultar.TabIndex = 2;
            this.btnConsultar.Text = "CONSULTAR";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // lblCanti
            // 
            this.lblCanti.AutoSize = true;
            this.lblCanti.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCanti.Location = new System.Drawing.Point(88, 117);
            this.lblCanti.Name = "lblCanti";
            this.lblCanti.Size = new System.Drawing.Size(322, 40);
            this.lblCanti.TabIndex = 9;
            this.lblCanti.Text = "Promedio de Materias";
            // 
            // lblIngrese
            // 
            this.lblIngrese.AutoSize = true;
            this.lblIngrese.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblIngrese.Location = new System.Drawing.Point(88, 177);
            this.lblIngrese.Name = "lblIngrese";
            this.lblIngrese.Size = new System.Drawing.Size(436, 21);
            this.lblIngrese.TabIndex = 10;
            this.lblIngrese.Text = "Ingrese promedio deseado (redondeado a valor entero):";
            // 
            // frmConsulta4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(853, 618);
            this.Controls.Add(this.lblIngrese);
            this.Controls.Add(this.lblCanti);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.txtPromedio);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmConsulta4";
            this.Text = "frmConsulta4";
            this.Load += new System.EventHandler(this.frmConsulta4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPromedio;
        private MaterialSkin.Controls.MaterialRaisedButton btnConsultar;
        private Label lblCanti;
        private Label lblIngrese;
    }
}