﻿namespace TecnicaturasPresentacion.Principal
{
    partial class frmPrincipal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.redondeo1 = new TecnicaturasPresentacion.Components.Redondeo();
            this.flpOpciones = new System.Windows.Forms.FlowLayoutPanel();
            this.pMenu = new System.Windows.Forms.Panel();
            this.lblMenu = new System.Windows.Forms.Label();
            this.pbMenu = new System.Windows.Forms.PictureBox();
            this.pHome = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAlumnos = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnProfesores = new System.Windows.Forms.Button();
            this.ConsultasContainer = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.btnConsulta8 = new System.Windows.Forms.Button();
            this.panel12 = new System.Windows.Forms.Panel();
            this.btnConsulta7 = new System.Windows.Forms.Button();
            this.panel11 = new System.Windows.Forms.Panel();
            this.btnConsulta6 = new System.Windows.Forms.Button();
            this.panel10 = new System.Windows.Forms.Panel();
            this.btnConsulta5 = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.btnConsulta4 = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnConsulta3 = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnConsulta2 = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnConsulta1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnConsultas = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnReportes = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnAbout = new System.Windows.Forms.Button();
            this.sidebarTimer = new System.Windows.Forms.Timer(this.components);
            this.ConsultasTimer = new System.Windows.Forms.Timer(this.components);
            this.pbClose = new System.Windows.Forms.PictureBox();
            this.pbMaximizar = new System.Windows.Forms.PictureBox();
            this.pbMinimizar = new System.Windows.Forms.PictureBox();
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.flpOpciones.SuspendLayout();
            this.pMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMenu)).BeginInit();
            this.pHome.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.ConsultasContainer.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimizar)).BeginInit();
            this.SuspendLayout();
            // 
            // redondeo1
            // 
            this.redondeo1.CornerRadius = 20;
            this.redondeo1.TargetControl = this;
            // 
            // flpOpciones
            // 
            this.flpOpciones.BackColor = System.Drawing.Color.Black;
            this.flpOpciones.Controls.Add(this.pMenu);
            this.flpOpciones.Controls.Add(this.pHome);
            this.flpOpciones.Controls.Add(this.panel1);
            this.flpOpciones.Controls.Add(this.panel2);
            this.flpOpciones.Controls.Add(this.ConsultasContainer);
            this.flpOpciones.Controls.Add(this.panel4);
            this.flpOpciones.Controls.Add(this.panel5);
            this.flpOpciones.Dock = System.Windows.Forms.DockStyle.Left;
            this.flpOpciones.Location = new System.Drawing.Point(0, 0);
            this.flpOpciones.MaximumSize = new System.Drawing.Size(226, 659);
            this.flpOpciones.MinimumSize = new System.Drawing.Size(66, 659);
            this.flpOpciones.Name = "flpOpciones";
            this.flpOpciones.Size = new System.Drawing.Size(226, 659);
            this.flpOpciones.TabIndex = 0;
            this.flpOpciones.Paint += new System.Windows.Forms.PaintEventHandler(this.flpOpciones_Paint);
            // 
            // pMenu
            // 
            this.pMenu.Controls.Add(this.lblMenu);
            this.pMenu.Controls.Add(this.pbMenu);
            this.pMenu.Location = new System.Drawing.Point(3, 3);
            this.pMenu.Name = "pMenu";
            this.pMenu.Size = new System.Drawing.Size(223, 100);
            this.pMenu.TabIndex = 0;
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMenu.ForeColor = System.Drawing.Color.White;
            this.lblMenu.Location = new System.Drawing.Point(92, 42);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(50, 21);
            this.lblMenu.TabIndex = 1;
            this.lblMenu.Text = "Menu";
            // 
            // pbMenu
            // 
            this.pbMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbMenu.Image = ((System.Drawing.Image)(resources.GetObject("pbMenu.Image")));
            this.pbMenu.Location = new System.Drawing.Point(9, 34);
            this.pbMenu.Name = "pbMenu";
            this.pbMenu.Size = new System.Drawing.Size(35, 35);
            this.pbMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMenu.TabIndex = 0;
            this.pbMenu.TabStop = false;
            this.pbMenu.Click += new System.EventHandler(this.pbMenu_Click);
            // 
            // pHome
            // 
            this.pHome.Controls.Add(this.btnHome);
            this.pHome.Location = new System.Drawing.Point(3, 109);
            this.pHome.Name = "pHome";
            this.pHome.Size = new System.Drawing.Size(223, 44);
            this.pHome.TabIndex = 1;
            // 
            // btnHome
            // 
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(-22, -7);
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnHome.Size = new System.Drawing.Size(266, 56);
            this.btnHome.TabIndex = 1;
            this.btnHome.Text = "                   Home";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAlumnos);
            this.panel1.Location = new System.Drawing.Point(3, 159);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(223, 44);
            this.panel1.TabIndex = 2;
            // 
            // btnAlumnos
            // 
            this.btnAlumnos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlumnos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlumnos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAlumnos.ForeColor = System.Drawing.Color.White;
            this.btnAlumnos.Image = ((System.Drawing.Image)(resources.GetObject("btnAlumnos.Image")));
            this.btnAlumnos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlumnos.Location = new System.Drawing.Point(-22, -7);
            this.btnAlumnos.Name = "btnAlumnos";
            this.btnAlumnos.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnAlumnos.Size = new System.Drawing.Size(266, 56);
            this.btnAlumnos.TabIndex = 1;
            this.btnAlumnos.Text = "                   Alumnos";
            this.btnAlumnos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlumnos.UseVisualStyleBackColor = true;
            this.btnAlumnos.Click += new System.EventHandler(this.btnAlumnos_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnProfesores);
            this.panel2.Location = new System.Drawing.Point(3, 209);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(223, 44);
            this.panel2.TabIndex = 3;
            // 
            // btnProfesores
            // 
            this.btnProfesores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProfesores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfesores.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnProfesores.ForeColor = System.Drawing.Color.White;
            this.btnProfesores.Image = ((System.Drawing.Image)(resources.GetObject("btnProfesores.Image")));
            this.btnProfesores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProfesores.Location = new System.Drawing.Point(-22, -7);
            this.btnProfesores.Name = "btnProfesores";
            this.btnProfesores.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnProfesores.Size = new System.Drawing.Size(266, 56);
            this.btnProfesores.TabIndex = 1;
            this.btnProfesores.Text = "                   Profesores";
            this.btnProfesores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProfesores.UseVisualStyleBackColor = true;
            this.btnProfesores.Click += new System.EventHandler(this.btnProfesores_Click);
            // 
            // ConsultasContainer
            // 
            this.ConsultasContainer.BackColor = System.Drawing.Color.Black;
            this.ConsultasContainer.Controls.Add(this.panel13);
            this.ConsultasContainer.Controls.Add(this.panel12);
            this.ConsultasContainer.Controls.Add(this.panel11);
            this.ConsultasContainer.Controls.Add(this.panel10);
            this.ConsultasContainer.Controls.Add(this.panel9);
            this.ConsultasContainer.Controls.Add(this.panel8);
            this.ConsultasContainer.Controls.Add(this.panel7);
            this.ConsultasContainer.Controls.Add(this.panel6);
            this.ConsultasContainer.Controls.Add(this.panel3);
            this.ConsultasContainer.Location = new System.Drawing.Point(3, 259);
            this.ConsultasContainer.MaximumSize = new System.Drawing.Size(223, 360);
            this.ConsultasContainer.MinimumSize = new System.Drawing.Size(223, 47);
            this.ConsultasContainer.Name = "ConsultasContainer";
            this.ConsultasContainer.Size = new System.Drawing.Size(223, 47);
            this.ConsultasContainer.TabIndex = 7;
            this.ConsultasContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.ConsultasContainer_Paint);
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.btnConsulta8);
            this.panel13.Location = new System.Drawing.Point(2, 321);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(223, 44);
            this.panel13.TabIndex = 13;
            // 
            // btnConsulta8
            // 
            this.btnConsulta8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsulta8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsulta8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnConsulta8.ForeColor = System.Drawing.Color.White;
            this.btnConsulta8.Image = ((System.Drawing.Image)(resources.GetObject("btnConsulta8.Image")));
            this.btnConsulta8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsulta8.Location = new System.Drawing.Point(-22, -9);
            this.btnConsulta8.Name = "btnConsulta8";
            this.btnConsulta8.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnConsulta8.Size = new System.Drawing.Size(266, 56);
            this.btnConsulta8.TabIndex = 1;
            this.btnConsulta8.Text = "                   Consulta 8";
            this.btnConsulta8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsulta8.UseVisualStyleBackColor = true;
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.btnConsulta7);
            this.panel12.Location = new System.Drawing.Point(0, 275);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(223, 44);
            this.panel12.TabIndex = 12;
            // 
            // btnConsulta7
            // 
            this.btnConsulta7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsulta7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsulta7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnConsulta7.ForeColor = System.Drawing.Color.White;
            this.btnConsulta7.Image = ((System.Drawing.Image)(resources.GetObject("btnConsulta7.Image")));
            this.btnConsulta7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsulta7.Location = new System.Drawing.Point(-22, -7);
            this.btnConsulta7.Name = "btnConsulta7";
            this.btnConsulta7.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnConsulta7.Size = new System.Drawing.Size(266, 56);
            this.btnConsulta7.TabIndex = 1;
            this.btnConsulta7.Text = "                   Consulta 7";
            this.btnConsulta7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsulta7.UseVisualStyleBackColor = true;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.btnConsulta6);
            this.panel11.Location = new System.Drawing.Point(0, 241);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(223, 44);
            this.panel11.TabIndex = 11;
            // 
            // btnConsulta6
            // 
            this.btnConsulta6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsulta6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsulta6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnConsulta6.ForeColor = System.Drawing.Color.White;
            this.btnConsulta6.Image = ((System.Drawing.Image)(resources.GetObject("btnConsulta6.Image")));
            this.btnConsulta6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsulta6.Location = new System.Drawing.Point(-22, -14);
            this.btnConsulta6.Name = "btnConsulta6";
            this.btnConsulta6.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnConsulta6.Size = new System.Drawing.Size(266, 56);
            this.btnConsulta6.TabIndex = 1;
            this.btnConsulta6.Text = "                   Consulta 6";
            this.btnConsulta6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsulta6.UseVisualStyleBackColor = true;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.btnConsulta5);
            this.panel10.Location = new System.Drawing.Point(0, 192);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(223, 44);
            this.panel10.TabIndex = 10;
            // 
            // btnConsulta5
            // 
            this.btnConsulta5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsulta5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsulta5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnConsulta5.ForeColor = System.Drawing.Color.White;
            this.btnConsulta5.Image = ((System.Drawing.Image)(resources.GetObject("btnConsulta5.Image")));
            this.btnConsulta5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsulta5.Location = new System.Drawing.Point(-22, -7);
            this.btnConsulta5.Name = "btnConsulta5";
            this.btnConsulta5.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnConsulta5.Size = new System.Drawing.Size(266, 56);
            this.btnConsulta5.TabIndex = 1;
            this.btnConsulta5.Text = "                   Consulta 5";
            this.btnConsulta5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsulta5.UseVisualStyleBackColor = true;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.btnConsulta4);
            this.panel9.Location = new System.Drawing.Point(0, 157);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(223, 44);
            this.panel9.TabIndex = 8;
            // 
            // btnConsulta4
            // 
            this.btnConsulta4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsulta4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsulta4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnConsulta4.ForeColor = System.Drawing.Color.White;
            this.btnConsulta4.Image = ((System.Drawing.Image)(resources.GetObject("btnConsulta4.Image")));
            this.btnConsulta4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsulta4.Location = new System.Drawing.Point(-22, -7);
            this.btnConsulta4.Name = "btnConsulta4";
            this.btnConsulta4.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnConsulta4.Size = new System.Drawing.Size(266, 56);
            this.btnConsulta4.TabIndex = 1;
            this.btnConsulta4.Text = "                   Consulta 4";
            this.btnConsulta4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsulta4.UseVisualStyleBackColor = true;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.btnConsulta3);
            this.panel8.Location = new System.Drawing.Point(0, 119);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(223, 44);
            this.panel8.TabIndex = 7;
            // 
            // btnConsulta3
            // 
            this.btnConsulta3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsulta3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsulta3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnConsulta3.ForeColor = System.Drawing.Color.White;
            this.btnConsulta3.Image = ((System.Drawing.Image)(resources.GetObject("btnConsulta3.Image")));
            this.btnConsulta3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsulta3.Location = new System.Drawing.Point(-22, -7);
            this.btnConsulta3.Name = "btnConsulta3";
            this.btnConsulta3.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnConsulta3.Size = new System.Drawing.Size(266, 56);
            this.btnConsulta3.TabIndex = 1;
            this.btnConsulta3.Text = "                   Consulta 3";
            this.btnConsulta3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsulta3.UseVisualStyleBackColor = true;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.btnConsulta2);
            this.panel7.Location = new System.Drawing.Point(0, 77);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(223, 44);
            this.panel7.TabIndex = 6;
            // 
            // btnConsulta2
            // 
            this.btnConsulta2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsulta2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsulta2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnConsulta2.ForeColor = System.Drawing.Color.White;
            this.btnConsulta2.Image = ((System.Drawing.Image)(resources.GetObject("btnConsulta2.Image")));
            this.btnConsulta2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsulta2.Location = new System.Drawing.Point(-22, -7);
            this.btnConsulta2.Name = "btnConsulta2";
            this.btnConsulta2.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnConsulta2.Size = new System.Drawing.Size(266, 56);
            this.btnConsulta2.TabIndex = 1;
            this.btnConsulta2.Text = "                   Consulta 2";
            this.btnConsulta2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsulta2.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btnConsulta1);
            this.panel6.Location = new System.Drawing.Point(0, 42);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(223, 44);
            this.panel6.TabIndex = 5;
            // 
            // btnConsulta1
            // 
            this.btnConsulta1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsulta1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsulta1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnConsulta1.ForeColor = System.Drawing.Color.White;
            this.btnConsulta1.Image = ((System.Drawing.Image)(resources.GetObject("btnConsulta1.Image")));
            this.btnConsulta1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsulta1.Location = new System.Drawing.Point(-22, -7);
            this.btnConsulta1.Name = "btnConsulta1";
            this.btnConsulta1.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnConsulta1.Size = new System.Drawing.Size(266, 56);
            this.btnConsulta1.TabIndex = 1;
            this.btnConsulta1.Text = "                   Consulta 1";
            this.btnConsulta1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsulta1.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnConsultas);
            this.panel3.Location = new System.Drawing.Point(0, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(223, 44);
            this.panel3.TabIndex = 4;
            // 
            // btnConsultas
            // 
            this.btnConsultas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsultas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnConsultas.ForeColor = System.Drawing.Color.White;
            this.btnConsultas.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultas.Image")));
            this.btnConsultas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultas.Location = new System.Drawing.Point(-22, -6);
            this.btnConsultas.Name = "btnConsultas";
            this.btnConsultas.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnConsultas.Size = new System.Drawing.Size(266, 56);
            this.btnConsultas.TabIndex = 1;
            this.btnConsultas.Text = "                   Consultas";
            this.btnConsultas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultas.UseVisualStyleBackColor = true;
            this.btnConsultas.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnReportes);
            this.panel4.Location = new System.Drawing.Point(3, 312);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(223, 44);
            this.panel4.TabIndex = 5;
            // 
            // btnReportes
            // 
            this.btnReportes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnReportes.ForeColor = System.Drawing.Color.White;
            this.btnReportes.Image = ((System.Drawing.Image)(resources.GetObject("btnReportes.Image")));
            this.btnReportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportes.Location = new System.Drawing.Point(-22, -7);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnReportes.Size = new System.Drawing.Size(266, 56);
            this.btnReportes.TabIndex = 1;
            this.btnReportes.Text = "                   Reportes";
            this.btnReportes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportes.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnAbout);
            this.panel5.Location = new System.Drawing.Point(3, 362);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(223, 44);
            this.panel5.TabIndex = 6;
            // 
            // btnAbout
            // 
            this.btnAbout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbout.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAbout.ForeColor = System.Drawing.Color.White;
            this.btnAbout.Image = ((System.Drawing.Image)(resources.GetObject("btnAbout.Image")));
            this.btnAbout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAbout.Location = new System.Drawing.Point(-22, -7);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnAbout.Size = new System.Drawing.Size(266, 56);
            this.btnAbout.TabIndex = 1;
            this.btnAbout.Text = "                   About";
            this.btnAbout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // sidebarTimer
            // 
            this.sidebarTimer.Interval = 10;
            this.sidebarTimer.Tick += new System.EventHandler(this.sidebarTimer_Tick);
            // 
            // ConsultasTimer
            // 
            this.ConsultasTimer.Interval = 1;
            this.ConsultasTimer.Tick += new System.EventHandler(this.ConsultasTimer_Tick);
            // 
            // pbClose
            // 
            this.pbClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbClose.Image = ((System.Drawing.Image)(resources.GetObject("pbClose.Image")));
            this.pbClose.Location = new System.Drawing.Point(1070, 1);
            this.pbClose.Name = "pbClose";
            this.pbClose.Size = new System.Drawing.Size(24, 23);
            this.pbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbClose.TabIndex = 1;
            this.pbClose.TabStop = false;
            this.pbClose.Click += new System.EventHandler(this.pbClose_Click);
            // 
            // pbMaximizar
            // 
            this.pbMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("pbMaximizar.Image")));
            this.pbMaximizar.Location = new System.Drawing.Point(1040, 0);
            this.pbMaximizar.Name = "pbMaximizar";
            this.pbMaximizar.Size = new System.Drawing.Size(24, 23);
            this.pbMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMaximizar.TabIndex = 2;
            this.pbMaximizar.TabStop = false;
            this.pbMaximizar.Click += new System.EventHandler(this.pbMaximizar_Click);
            // 
            // pbMinimizar
            // 
            this.pbMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("pbMinimizar.Image")));
            this.pbMinimizar.Location = new System.Drawing.Point(1010, 0);
            this.pbMinimizar.Name = "pbMinimizar";
            this.pbMinimizar.Size = new System.Drawing.Size(24, 23);
            this.pbMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMinimizar.TabIndex = 3;
            this.pbMinimizar.TabStop = false;
            this.pbMinimizar.Click += new System.EventHandler(this.pbMinimizar_Click);
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.Location = new System.Drawing.Point(232, 23);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(853, 618);
            this.panelPrincipal.TabIndex = 4;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1097, 659);
            this.Controls.Add(this.panelPrincipal);
            this.Controls.Add(this.pbMinimizar);
            this.Controls.Add(this.pbMaximizar);
            this.Controls.Add(this.pbClose);
            this.Controls.Add(this.flpOpciones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.flpOpciones.ResumeLayout(false);
            this.pMenu.ResumeLayout(false);
            this.pMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMenu)).EndInit();
            this.pHome.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ConsultasContainer.ResumeLayout(false);
            this.panel13.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimizar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Components.Redondeo redondeo1;
        private Button btnHome;
        private Panel pHome;
        private FlowLayoutPanel flpOpciones;
        private Panel pMenu;
        private Panel panel1;
        private Button btnAlumnos;
        private Panel panel2;
        private Button btnProfesores;
        private Panel panel3;
        private Button btnConsultas;
        private Panel panel4;
        private Button btnReportes;
        private Panel panel5;
        private Button btnAbout;
        private PictureBox pbMenu;
        private Label lblMenu;
        private System.Windows.Forms.Timer sidebarTimer;
        private Panel ConsultasContainer;
        private Panel panel8;
        private Button btnConsulta3;
        private Panel panel7;
        private Button btnConsulta2;
        private Panel panel6;
        private Button btnConsulta1;
        private Panel panel13;
        private Button btnConsulta8;
        private Panel panel12;
        private Button btnConsulta7;
        private Panel panel11;
        private Button btnConsulta6;
        private Panel panel10;
        private Button btnConsulta5;
        private Panel panel9;
        private Button btnConsulta4;
        private System.Windows.Forms.Timer ConsultasTimer;
        private PictureBox pbMinimizar;
        private PictureBox pbMaximizar;
        private PictureBox pbClose;
        private Panel panelPrincipal;
    }
}