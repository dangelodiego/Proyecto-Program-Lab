namespace TecnicaturasPresentacion
{
    partial class frmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.pictureBoxLogoUtn = new System.Windows.Forms.PictureBox();
            this.pictureBoxCloseLogin = new System.Windows.Forms.PictureBox();
            this.pictureBoxMinLogin = new System.Windows.Forms.PictureBox();
            this.txtUsuario = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblContraseña = new MaterialSkin.Controls.MaterialLabel();
            this.txtContraseña = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblUsuario = new MaterialSkin.Controls.MaterialLabel();
            this.btnAcceder = new MaterialSkin.Controls.MaterialRaisedButton();
            this.redondeo1 = new TecnicaturasPresentacion.Components.Redondeo();
            this.pictureBoxOcultar = new System.Windows.Forms.PictureBox();
            this.pictureBoxVisible = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogoUtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCloseLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMinLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOcultar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVisible)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxLogoUtn
            // 
            this.pictureBoxLogoUtn.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogoUtn.Image")));
            this.pictureBoxLogoUtn.Location = new System.Drawing.Point(106, 12);
            this.pictureBoxLogoUtn.Name = "pictureBoxLogoUtn";
            this.pictureBoxLogoUtn.Size = new System.Drawing.Size(279, 307);
            this.pictureBoxLogoUtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxLogoUtn.TabIndex = 0;
            this.pictureBoxLogoUtn.TabStop = false;
            // 
            // pictureBoxCloseLogin
            // 
            this.pictureBoxCloseLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxCloseLogin.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCloseLogin.Image")));
            this.pictureBoxCloseLogin.Location = new System.Drawing.Point(462, 3);
            this.pictureBoxCloseLogin.Name = "pictureBoxCloseLogin";
            this.pictureBoxCloseLogin.Size = new System.Drawing.Size(21, 21);
            this.pictureBoxCloseLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCloseLogin.TabIndex = 1;
            this.pictureBoxCloseLogin.TabStop = false;
            this.pictureBoxCloseLogin.Click += new System.EventHandler(this.pictureBoxCloseLogin_Click);
            // 
            // pictureBoxMinLogin
            // 
            this.pictureBoxMinLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxMinLogin.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxMinLogin.Image")));
            this.pictureBoxMinLogin.Location = new System.Drawing.Point(433, 3);
            this.pictureBoxMinLogin.Name = "pictureBoxMinLogin";
            this.pictureBoxMinLogin.Size = new System.Drawing.Size(23, 21);
            this.pictureBoxMinLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMinLogin.TabIndex = 2;
            this.pictureBoxMinLogin.TabStop = false;
            this.pictureBoxMinLogin.Click += new System.EventHandler(this.pictureBoxMinLogin_Click);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsuario.Depth = 0;
            this.txtUsuario.Hint = "";
            this.txtUsuario.Location = new System.Drawing.Point(102, 377);
            this.txtUsuario.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.PasswordChar = '\0';
            this.txtUsuario.SelectedText = "";
            this.txtUsuario.SelectionLength = 0;
            this.txtUsuario.SelectionStart = 0;
            this.txtUsuario.Size = new System.Drawing.Size(279, 23);
            this.txtUsuario.TabIndex = 0;
            this.txtUsuario.UseSystemPasswordChar = false;
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Depth = 0;
            this.lblContraseña.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblContraseña.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblContraseña.Location = new System.Drawing.Point(102, 425);
            this.lblContraseña.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(86, 19);
            this.lblContraseña.TabIndex = 2;
            this.lblContraseña.Text = "Contraseña";
            // 
            // txtContraseña
            // 
            this.txtContraseña.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtContraseña.Depth = 0;
            this.txtContraseña.Hint = "";
            this.txtContraseña.Location = new System.Drawing.Point(102, 447);
            this.txtContraseña.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '*';
            this.txtContraseña.SelectedText = "";
            this.txtContraseña.SelectionLength = 0;
            this.txtContraseña.SelectionStart = 0;
            this.txtContraseña.Size = new System.Drawing.Size(279, 23);
            this.txtContraseña.TabIndex = 1;
            this.txtContraseña.UseSystemPasswordChar = false;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Depth = 0;
            this.lblUsuario.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblUsuario.Location = new System.Drawing.Point(102, 355);
            this.lblUsuario.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(61, 19);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "Usuario";
            // 
            // btnAcceder
            // 
            this.btnAcceder.BackColor = System.Drawing.Color.White;
            this.btnAcceder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAcceder.Depth = 0;
            this.btnAcceder.ForeColor = System.Drawing.Color.Black;
            this.btnAcceder.Location = new System.Drawing.Point(130, 501);
            this.btnAcceder.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAcceder.Name = "btnAcceder";
            this.btnAcceder.Primary = true;
            this.btnAcceder.Size = new System.Drawing.Size(210, 42);
            this.btnAcceder.TabIndex = 2;
            this.btnAcceder.Text = "ACCEDER";
            this.btnAcceder.UseVisualStyleBackColor = false;
            this.btnAcceder.Click += new System.EventHandler(this.btnAcceder_Click);
            // 
            // redondeo1
            // 
            this.redondeo1.CornerRadius = 30;
            this.redondeo1.TargetControl = this;
            // 
            // pictureBoxOcultar
            // 
            this.pictureBoxOcultar.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxOcultar.Image")));
            this.pictureBoxOcultar.Location = new System.Drawing.Point(387, 447);
            this.pictureBoxOcultar.Name = "pictureBoxOcultar";
            this.pictureBoxOcultar.Size = new System.Drawing.Size(27, 23);
            this.pictureBoxOcultar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxOcultar.TabIndex = 3;
            this.pictureBoxOcultar.TabStop = false;
            this.pictureBoxOcultar.Click += new System.EventHandler(this.pictureBoxOcultar_Click);
            // 
            // pictureBoxVisible
            // 
            this.pictureBoxVisible.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxVisible.Image")));
            this.pictureBoxVisible.Location = new System.Drawing.Point(387, 447);
            this.pictureBoxVisible.Name = "pictureBoxVisible";
            this.pictureBoxVisible.Size = new System.Drawing.Size(27, 23);
            this.pictureBoxVisible.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxVisible.TabIndex = 4;
            this.pictureBoxVisible.TabStop = false;
            this.pictureBoxVisible.Click += new System.EventHandler(this.pictureBoxVisible_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(489, 582);
            this.Controls.Add(this.pictureBoxVisible);
            this.Controls.Add(this.pictureBoxOcultar);
            this.Controls.Add(this.btnAcceder);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblContraseña);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.pictureBoxMinLogin);
            this.Controls.Add(this.pictureBoxCloseLogin);
            this.Controls.Add(this.pictureBoxLogoUtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogoUtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCloseLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMinLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOcultar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVisible)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBoxLogoUtn;
        private PictureBox pictureBoxCloseLogin;
        private PictureBox pictureBoxMinLogin;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtUsuario;
        private MaterialSkin.Controls.MaterialLabel lblContraseña;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtContraseña;
        private MaterialSkin.Controls.MaterialLabel lblUsuario;
        private MaterialSkin.Controls.MaterialRaisedButton btnAcceder;
        private Components.Redondeo redondeo1;
        private PictureBox pictureBoxVisible;
        private PictureBox pictureBoxOcultar;
    }
}