namespace TecnicaturasPresentacion.Principal.Consultas
{
    partial class frmConsulta1
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
            this.dgvCantidadInscriptos = new System.Windows.Forms.DataGridView();
            this.txtAnioUNO = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblAñouno = new MaterialSkin.Controls.MaterialLabel();
            this.lblAñodos = new MaterialSkin.Controls.MaterialLabel();
            this.txtAniodos = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnConsultar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.lblCanti = new System.Windows.Forms.Label();
            this.lblIngrese = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCantidadInscriptos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCantidadInscriptos
            // 
            this.dgvCantidadInscriptos.AllowUserToAddRows = false;
            this.dgvCantidadInscriptos.AllowUserToDeleteRows = false;
            this.dgvCantidadInscriptos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCantidadInscriptos.Location = new System.Drawing.Point(63, 212);
            this.dgvCantidadInscriptos.Name = "dgvCantidadInscriptos";
            this.dgvCantidadInscriptos.ReadOnly = true;
            this.dgvCantidadInscriptos.RowTemplate.Height = 25;
            this.dgvCantidadInscriptos.Size = new System.Drawing.Size(673, 76);
            this.dgvCantidadInscriptos.TabIndex = 0;
            // 
            // txtAnioUNO
            // 
            this.txtAnioUNO.Depth = 0;
            this.txtAnioUNO.Hint = "";
            this.txtAnioUNO.Location = new System.Drawing.Point(63, 173);
            this.txtAnioUNO.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtAnioUNO.Name = "txtAnioUNO";
            this.txtAnioUNO.PasswordChar = '\0';
            this.txtAnioUNO.SelectedText = "";
            this.txtAnioUNO.SelectionLength = 0;
            this.txtAnioUNO.SelectionStart = 0;
            this.txtAnioUNO.Size = new System.Drawing.Size(191, 23);
            this.txtAnioUNO.TabIndex = 1;
            this.txtAnioUNO.UseSystemPasswordChar = false;
            // 
            // lblAñouno
            // 
            this.lblAñouno.AutoSize = true;
            this.lblAñouno.Depth = 0;
            this.lblAñouno.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAñouno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblAñouno.Location = new System.Drawing.Point(63, 150);
            this.lblAñouno.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblAñouno.Name = "lblAñouno";
            this.lblAñouno.Size = new System.Drawing.Size(52, 19);
            this.lblAñouno.TabIndex = 2;
            this.lblAñouno.Text = "Año 1:";
            // 
            // lblAñodos
            // 
            this.lblAñodos.AutoSize = true;
            this.lblAñodos.Depth = 0;
            this.lblAñodos.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAñodos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblAñodos.Location = new System.Drawing.Point(319, 150);
            this.lblAñodos.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblAñodos.Name = "lblAñodos";
            this.lblAñodos.Size = new System.Drawing.Size(52, 19);
            this.lblAñodos.TabIndex = 4;
            this.lblAñodos.Text = "Año 2:";
            // 
            // txtAniodos
            // 
            this.txtAniodos.Depth = 0;
            this.txtAniodos.Hint = "";
            this.txtAniodos.Location = new System.Drawing.Point(319, 172);
            this.txtAniodos.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtAniodos.Name = "txtAniodos";
            this.txtAniodos.PasswordChar = '\0';
            this.txtAniodos.SelectedText = "";
            this.txtAniodos.SelectionLength = 0;
            this.txtAniodos.SelectionStart = 0;
            this.txtAniodos.Size = new System.Drawing.Size(191, 23);
            this.txtAniodos.TabIndex = 3;
            this.txtAniodos.UseSystemPasswordChar = false;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Depth = 0;
            this.btnConsultar.Location = new System.Drawing.Point(627, 150);
            this.btnConsultar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Primary = true;
            this.btnConsultar.Size = new System.Drawing.Size(109, 45);
            this.btnConsultar.TabIndex = 6;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // lblCanti
            // 
            this.lblCanti.AutoSize = true;
            this.lblCanti.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCanti.Location = new System.Drawing.Point(63, 43);
            this.lblCanti.Name = "lblCanti";
            this.lblCanti.Size = new System.Drawing.Size(324, 40);
            this.lblCanti.TabIndex = 7;
            this.lblCanti.Text = "Cantidad de Inscriptos";
            // 
            // lblIngrese
            // 
            this.lblIngrese.AutoSize = true;
            this.lblIngrese.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblIngrese.Location = new System.Drawing.Point(63, 110);
            this.lblIngrese.Name = "lblIngrese";
            this.lblIngrese.Size = new System.Drawing.Size(255, 21);
            this.lblIngrese.TabIndex = 8;
            this.lblIngrese.Text = "Ingrese DOS años distintos aqui:";
            // 
            // frmConsulta1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(837, 579);
            this.Controls.Add(this.lblIngrese);
            this.Controls.Add(this.lblCanti);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.lblAñodos);
            this.Controls.Add(this.txtAniodos);
            this.Controls.Add(this.lblAñouno);
            this.Controls.Add(this.txtAnioUNO);
            this.Controls.Add(this.dgvCantidadInscriptos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmConsulta1";
            this.Text = "frmConsulta1cs";
            this.Load += new System.EventHandler(this.frmConsulta1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCantidadInscriptos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvCantidadInscriptos;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtAnioUNO;
        private MaterialSkin.Controls.MaterialLabel lblAñouno;
        private MaterialSkin.Controls.MaterialLabel lblAñodos;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtAniodos;
        private MaterialSkin.Controls.MaterialRaisedButton btnConsultar;
        private Label lblCanti;
        private Label lblIngrese;
    }
}