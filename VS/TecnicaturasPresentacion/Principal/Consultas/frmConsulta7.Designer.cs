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
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta7)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvConsulta7
            // 
            this.dgvConsulta7.AllowUserToAddRows = false;
            this.dgvConsulta7.AllowUserToDeleteRows = false;
            this.dgvConsulta7.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsulta7.Location = new System.Drawing.Point(291, 211);
            this.dgvConsulta7.Name = "dgvConsulta7";
            this.dgvConsulta7.ReadOnly = true;
            this.dgvConsulta7.RowTemplate.Height = 25;
            this.dgvConsulta7.Size = new System.Drawing.Size(240, 150);
            this.dgvConsulta7.TabIndex = 0;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Depth = 0;
            this.btnConsultar.Location = new System.Drawing.Point(559, 149);
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
            this.txtAño.Location = new System.Drawing.Point(291, 182);
            this.txtAño.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtAño.Name = "txtAño";
            this.txtAño.PasswordChar = '\0';
            this.txtAño.SelectedText = "";
            this.txtAño.SelectionLength = 0;
            this.txtAño.SelectionStart = 0;
            this.txtAño.Size = new System.Drawing.Size(75, 23);
            this.txtAño.TabIndex = 2;
            this.txtAño.UseSystemPasswordChar = false;
            // 
            // frmConsulta7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(853, 618);
            this.Controls.Add(this.txtAño);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.dgvConsulta7);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmConsulta7";
            this.Text = "frmConsulta7";
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta7)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgvConsulta7;
        private MaterialSkin.Controls.MaterialRaisedButton btnConsultar;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtAño;
    }
}