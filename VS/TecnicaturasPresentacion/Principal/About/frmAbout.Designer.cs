namespace TecnicaturasPresentacion.Principal.About
{
    partial class frmAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAbout));
            this.lblSobreLaApp = new System.Windows.Forms.Label();
            this.lblTextAbout = new System.Windows.Forms.Label();
            this.linkLabelRepo = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lblSobreLaApp
            // 
            this.lblSobreLaApp.AutoSize = true;
            this.lblSobreLaApp.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSobreLaApp.Location = new System.Drawing.Point(12, 9);
            this.lblSobreLaApp.Name = "lblSobreLaApp";
            this.lblSobreLaApp.Size = new System.Drawing.Size(337, 47);
            this.lblSobreLaApp.TabIndex = 0;
            this.lblSobreLaApp.Text = "Sobre la Aplicación";
            // 
            // lblTextAbout
            // 
            this.lblTextAbout.AutoSize = true;
            this.lblTextAbout.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTextAbout.Location = new System.Drawing.Point(12, 56);
            this.lblTextAbout.Name = "lblTextAbout";
            this.lblTextAbout.Size = new System.Drawing.Size(784, 200);
            this.lblTextAbout.TabIndex = 1;
            this.lblTextAbout.Text = resources.GetString("lblTextAbout.Text");
            // 
            // linkLabelRepo
            // 
            this.linkLabelRepo.AutoSize = true;
            this.linkLabelRepo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.linkLabelRepo.Location = new System.Drawing.Point(13, 258);
            this.linkLabelRepo.Name = "linkLabelRepo";
            this.linkLabelRepo.Size = new System.Drawing.Size(137, 20);
            this.linkLabelRepo.TabIndex = 2;
            this.linkLabelRepo.TabStop = true;
            this.linkLabelRepo.Text = "Repositorio GitHub";
            this.linkLabelRepo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelRepo_LinkClicked);
            // 
            // frmAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.linkLabelRepo);
            this.Controls.Add(this.lblTextAbout);
            this.Controls.Add(this.lblSobreLaApp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAbout";
            this.Text = "frmAbout";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblSobreLaApp;
        private Label lblTextAbout;
        private LinkLabel linkLabelRepo;
    }
}