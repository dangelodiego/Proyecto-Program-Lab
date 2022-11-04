namespace TecnicaturasPresentacion.Principal.Profesores
{
    partial class frmProfesores
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
            this.btnGuardar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btmAgregar = new MaterialSkin.Controls.MaterialFlatButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblBarrio = new MaterialSkin.Controls.MaterialLabel();
            this.lblCiudad = new MaterialSkin.Controls.MaterialLabel();
            this.lblProvincia = new MaterialSkin.Controls.MaterialLabel();
            this.txtEstadoCivil = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblEstadoCivil = new MaterialSkin.Controls.MaterialLabel();
            this.lblFechaIncripcion = new MaterialSkin.Controls.MaterialLabel();
            this.cboCurso = new System.Windows.Forms.ComboBox();
            this.lblCurso = new MaterialSkin.Controls.MaterialLabel();
            this.cboTecnicatura = new System.Windows.Forms.ComboBox();
            this.lblTecnicatura = new MaterialSkin.Controls.MaterialLabel();
            this.rbDesconocido = new MaterialSkin.Controls.MaterialRadioButton();
            this.rbFemenino = new MaterialSkin.Controls.MaterialRadioButton();
            this.rbMasculino = new MaterialSkin.Controls.MaterialRadioButton();
            this.lblSexo = new MaterialSkin.Controls.MaterialLabel();
            this.lblAltura = new MaterialSkin.Controls.MaterialLabel();
            this.txtAltura = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblCalle = new MaterialSkin.Controls.MaterialLabel();
            this.txtCalle = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblTelefono = new MaterialSkin.Controls.MaterialLabel();
            this.materialSingleLineTextField2 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.cboEmails = new System.Windows.Forms.ComboBox();
            this.txtEmail = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblEmail = new MaterialSkin.Controls.MaterialLabel();
            this.lblDni = new MaterialSkin.Controls.MaterialLabel();
            this.materialSingleLineTextField1 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblFechaNacimiento = new MaterialSkin.Controls.MaterialLabel();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.lblApellido = new MaterialSkin.Controls.MaterialLabel();
            this.txtApellido = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblNombre = new MaterialSkin.Controls.MaterialLabel();
            this.txtNombre = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.cboMateria = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Depth = 0;
            this.btnGuardar.Location = new System.Drawing.Point(295, 570);
            this.btnGuardar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Primary = true;
            this.btnGuardar.Size = new System.Drawing.Size(204, 37);
            this.btnGuardar.TabIndex = 75;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btmAgregar
            // 
            this.btmAgregar.AutoSize = true;
            this.btmAgregar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btmAgregar.Depth = 0;
            this.btmAgregar.Location = new System.Drawing.Point(736, 379);
            this.btmAgregar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btmAgregar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btmAgregar.Name = "btmAgregar";
            this.btmAgregar.Primary = false;
            this.btmAgregar.Size = new System.Drawing.Size(74, 36);
            this.btmAgregar.TabIndex = 74;
            this.btmAgregar.Text = "AGREGAR";
            this.btmAgregar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(10, 430);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(800, 134);
            this.dataGridView1.TabIndex = 73;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(576, 387);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(141, 23);
            this.comboBox3.TabIndex = 72;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(401, 387);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(145, 23);
            this.comboBox2.TabIndex = 71;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(199, 387);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(162, 23);
            this.comboBox1.TabIndex = 70;
            // 
            // lblBarrio
            // 
            this.lblBarrio.AutoSize = true;
            this.lblBarrio.Depth = 0;
            this.lblBarrio.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBarrio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblBarrio.Location = new System.Drawing.Point(573, 365);
            this.lblBarrio.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblBarrio.Name = "lblBarrio";
            this.lblBarrio.Size = new System.Drawing.Size(49, 19);
            this.lblBarrio.TabIndex = 69;
            this.lblBarrio.Text = "Barrio";
            // 
            // lblCiudad
            // 
            this.lblCiudad.AutoSize = true;
            this.lblCiudad.Depth = 0;
            this.lblCiudad.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCiudad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCiudad.Location = new System.Drawing.Point(401, 365);
            this.lblCiudad.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCiudad.Name = "lblCiudad";
            this.lblCiudad.Size = new System.Drawing.Size(55, 19);
            this.lblCiudad.TabIndex = 68;
            this.lblCiudad.Text = "Ciudad";
            // 
            // lblProvincia
            // 
            this.lblProvincia.AutoSize = true;
            this.lblProvincia.Depth = 0;
            this.lblProvincia.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblProvincia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblProvincia.Location = new System.Drawing.Point(199, 365);
            this.lblProvincia.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblProvincia.Name = "lblProvincia";
            this.lblProvincia.Size = new System.Drawing.Size(71, 19);
            this.lblProvincia.TabIndex = 67;
            this.lblProvincia.Text = "Provincia";
            // 
            // txtEstadoCivil
            // 
            this.txtEstadoCivil.Depth = 0;
            this.txtEstadoCivil.Hint = "";
            this.txtEstadoCivil.Location = new System.Drawing.Point(22, 387);
            this.txtEstadoCivil.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtEstadoCivil.Name = "txtEstadoCivil";
            this.txtEstadoCivil.PasswordChar = '\0';
            this.txtEstadoCivil.SelectedText = "";
            this.txtEstadoCivil.SelectionLength = 0;
            this.txtEstadoCivil.SelectionStart = 0;
            this.txtEstadoCivil.Size = new System.Drawing.Size(162, 23);
            this.txtEstadoCivil.TabIndex = 66;
            this.txtEstadoCivil.UseSystemPasswordChar = false;
            // 
            // lblEstadoCivil
            // 
            this.lblEstadoCivil.AutoSize = true;
            this.lblEstadoCivil.Depth = 0;
            this.lblEstadoCivil.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEstadoCivil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblEstadoCivil.Location = new System.Drawing.Point(22, 365);
            this.lblEstadoCivil.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblEstadoCivil.Name = "lblEstadoCivil";
            this.lblEstadoCivil.Size = new System.Drawing.Size(89, 19);
            this.lblEstadoCivil.TabIndex = 65;
            this.lblEstadoCivil.Text = "Estado Civil";
            // 
            // lblFechaIncripcion
            // 
            this.lblFechaIncripcion.AutoSize = true;
            this.lblFechaIncripcion.Depth = 0;
            this.lblFechaIncripcion.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFechaIncripcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblFechaIncripcion.Location = new System.Drawing.Point(473, 281);
            this.lblFechaIncripcion.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblFechaIncripcion.Name = "lblFechaIncripcion";
            this.lblFechaIncripcion.Size = new System.Drawing.Size(60, 19);
            this.lblFechaIncripcion.TabIndex = 63;
            this.lblFechaIncripcion.Text = "Materia";
            // 
            // cboCurso
            // 
            this.cboCurso.FormattingEnabled = true;
            this.cboCurso.Location = new System.Drawing.Point(254, 312);
            this.cboCurso.Name = "cboCurso";
            this.cboCurso.Size = new System.Drawing.Size(162, 23);
            this.cboCurso.TabIndex = 62;
            // 
            // lblCurso
            // 
            this.lblCurso.AutoSize = true;
            this.lblCurso.Depth = 0;
            this.lblCurso.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCurso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCurso.Location = new System.Drawing.Point(254, 281);
            this.lblCurso.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCurso.Name = "lblCurso";
            this.lblCurso.Size = new System.Drawing.Size(49, 19);
            this.lblCurso.TabIndex = 61;
            this.lblCurso.Text = "Curso";
            // 
            // cboTecnicatura
            // 
            this.cboTecnicatura.FormattingEnabled = true;
            this.cboTecnicatura.Location = new System.Drawing.Point(22, 312);
            this.cboTecnicatura.Name = "cboTecnicatura";
            this.cboTecnicatura.Size = new System.Drawing.Size(162, 23);
            this.cboTecnicatura.TabIndex = 60;
            // 
            // lblTecnicatura
            // 
            this.lblTecnicatura.AutoSize = true;
            this.lblTecnicatura.Depth = 0;
            this.lblTecnicatura.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTecnicatura.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTecnicatura.Location = new System.Drawing.Point(22, 281);
            this.lblTecnicatura.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTecnicatura.Name = "lblTecnicatura";
            this.lblTecnicatura.Size = new System.Drawing.Size(88, 19);
            this.lblTecnicatura.TabIndex = 59;
            this.lblTecnicatura.Text = "Tecnicatura";
            // 
            // rbDesconocido
            // 
            this.rbDesconocido.AutoSize = true;
            this.rbDesconocido.Depth = 0;
            this.rbDesconocido.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbDesconocido.Location = new System.Drawing.Point(685, 169);
            this.rbDesconocido.Margin = new System.Windows.Forms.Padding(0);
            this.rbDesconocido.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbDesconocido.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbDesconocido.Name = "rbDesconocido";
            this.rbDesconocido.Ripple = true;
            this.rbDesconocido.Size = new System.Drawing.Size(109, 30);
            this.rbDesconocido.TabIndex = 58;
            this.rbDesconocido.TabStop = true;
            this.rbDesconocido.Text = "Desconocido";
            this.rbDesconocido.UseVisualStyleBackColor = true;
            // 
            // rbFemenino
            // 
            this.rbFemenino.AutoSize = true;
            this.rbFemenino.Depth = 0;
            this.rbFemenino.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbFemenino.Location = new System.Drawing.Point(580, 169);
            this.rbFemenino.Margin = new System.Windows.Forms.Padding(0);
            this.rbFemenino.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbFemenino.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbFemenino.Name = "rbFemenino";
            this.rbFemenino.Ripple = true;
            this.rbFemenino.Size = new System.Drawing.Size(90, 30);
            this.rbFemenino.TabIndex = 57;
            this.rbFemenino.TabStop = true;
            this.rbFemenino.Text = "Femenino";
            this.rbFemenino.UseVisualStyleBackColor = true;
            // 
            // rbMasculino
            // 
            this.rbMasculino.AutoSize = true;
            this.rbMasculino.Depth = 0;
            this.rbMasculino.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbMasculino.Location = new System.Drawing.Point(472, 169);
            this.rbMasculino.Margin = new System.Windows.Forms.Padding(0);
            this.rbMasculino.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbMasculino.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbMasculino.Name = "rbMasculino";
            this.rbMasculino.Ripple = true;
            this.rbMasculino.Size = new System.Drawing.Size(93, 30);
            this.rbMasculino.TabIndex = 56;
            this.rbMasculino.TabStop = true;
            this.rbMasculino.Text = "Masculino";
            this.rbMasculino.UseVisualStyleBackColor = true;
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Depth = 0;
            this.lblSexo.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSexo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblSexo.Location = new System.Drawing.Point(613, 138);
            this.lblSexo.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(42, 19);
            this.lblSexo.TabIndex = 55;
            this.lblSexo.Text = "Sexo";
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Depth = 0;
            this.lblAltura.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAltura.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblAltura.Location = new System.Drawing.Point(278, 212);
            this.lblAltura.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(49, 19);
            this.lblAltura.TabIndex = 54;
            this.lblAltura.Text = "Altura";
            // 
            // txtAltura
            // 
            this.txtAltura.Depth = 0;
            this.txtAltura.Hint = "";
            this.txtAltura.Location = new System.Drawing.Point(278, 234);
            this.txtAltura.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.PasswordChar = '\0';
            this.txtAltura.SelectedText = "";
            this.txtAltura.SelectionLength = 0;
            this.txtAltura.SelectionStart = 0;
            this.txtAltura.Size = new System.Drawing.Size(221, 23);
            this.txtAltura.TabIndex = 53;
            this.txtAltura.UseSystemPasswordChar = false;
            // 
            // lblCalle
            // 
            this.lblCalle.AutoSize = true;
            this.lblCalle.Depth = 0;
            this.lblCalle.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCalle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCalle.Location = new System.Drawing.Point(22, 212);
            this.lblCalle.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCalle.Name = "lblCalle";
            this.lblCalle.Size = new System.Drawing.Size(43, 19);
            this.lblCalle.TabIndex = 52;
            this.lblCalle.Text = "Calle";
            // 
            // txtCalle
            // 
            this.txtCalle.Depth = 0;
            this.txtCalle.Hint = "";
            this.txtCalle.Location = new System.Drawing.Point(22, 234);
            this.txtCalle.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.PasswordChar = '\0';
            this.txtCalle.SelectedText = "";
            this.txtCalle.SelectionLength = 0;
            this.txtCalle.SelectionStart = 0;
            this.txtCalle.Size = new System.Drawing.Size(221, 23);
            this.txtCalle.TabIndex = 51;
            this.txtCalle.UseSystemPasswordChar = false;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Depth = 0;
            this.lblTelefono.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTelefono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTelefono.Location = new System.Drawing.Point(22, 175);
            this.lblTelefono.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(73, 19);
            this.lblTelefono.TabIndex = 50;
            this.lblTelefono.Text = "Teléfono:";
            // 
            // materialSingleLineTextField2
            // 
            this.materialSingleLineTextField2.Depth = 0;
            this.materialSingleLineTextField2.Hint = "";
            this.materialSingleLineTextField2.Location = new System.Drawing.Point(98, 171);
            this.materialSingleLineTextField2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField2.Name = "materialSingleLineTextField2";
            this.materialSingleLineTextField2.PasswordChar = '\0';
            this.materialSingleLineTextField2.SelectedText = "";
            this.materialSingleLineTextField2.SelectionLength = 0;
            this.materialSingleLineTextField2.SelectionStart = 0;
            this.materialSingleLineTextField2.Size = new System.Drawing.Size(221, 23);
            this.materialSingleLineTextField2.TabIndex = 49;
            this.materialSingleLineTextField2.UseSystemPasswordChar = false;
            // 
            // cboEmails
            // 
            this.cboEmails.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEmails.FormattingEnabled = true;
            this.cboEmails.Items.AddRange(new object[] {
            "@gmail.com",
            "@yahoo.com",
            "@outlock.com",
            "@hotmail.com"});
            this.cboEmails.Location = new System.Drawing.Point(316, 134);
            this.cboEmails.Name = "cboEmails";
            this.cboEmails.Size = new System.Drawing.Size(121, 23);
            this.cboEmails.TabIndex = 48;
            // 
            // txtEmail
            // 
            this.txtEmail.Depth = 0;
            this.txtEmail.Hint = "";
            this.txtEmail.Location = new System.Drawing.Point(89, 134);
            this.txtEmail.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.SelectedText = "";
            this.txtEmail.SelectionLength = 0;
            this.txtEmail.SelectionStart = 0;
            this.txtEmail.Size = new System.Drawing.Size(221, 23);
            this.txtEmail.TabIndex = 47;
            this.txtEmail.UseSystemPasswordChar = false;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Depth = 0;
            this.lblEmail.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblEmail.Location = new System.Drawing.Point(22, 138);
            this.lblEmail.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(61, 19);
            this.lblEmail.TabIndex = 46;
            this.lblEmail.Text = "E-MAIL:";
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Depth = 0;
            this.lblDni.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDni.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDni.Location = new System.Drawing.Point(399, 77);
            this.lblDni.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(38, 19);
            this.lblDni.TabIndex = 45;
            this.lblDni.Text = "DNI:";
            // 
            // materialSingleLineTextField1
            // 
            this.materialSingleLineTextField1.Depth = 0;
            this.materialSingleLineTextField1.Hint = "";
            this.materialSingleLineTextField1.Location = new System.Drawing.Point(437, 76);
            this.materialSingleLineTextField1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField1.Name = "materialSingleLineTextField1";
            this.materialSingleLineTextField1.PasswordChar = '\0';
            this.materialSingleLineTextField1.SelectedText = "";
            this.materialSingleLineTextField1.SelectionLength = 0;
            this.materialSingleLineTextField1.SelectionStart = 0;
            this.materialSingleLineTextField1.Size = new System.Drawing.Size(221, 23);
            this.materialSingleLineTextField1.TabIndex = 44;
            this.materialSingleLineTextField1.UseSystemPasswordChar = false;
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Depth = 0;
            this.lblFechaNacimiento.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFechaNacimiento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblFechaNacimiento.Location = new System.Drawing.Point(22, 77);
            this.lblFechaNacimiento.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(155, 19);
            this.lblFechaNacimiento.TabIndex = 43;
            this.lblFechaNacimiento.Text = "Fecha de Nacimiento:";
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(179, 76);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(200, 23);
            this.dtpFechaNacimiento.TabIndex = 42;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Depth = 0;
            this.lblApellido.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblApellido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblApellido.Location = new System.Drawing.Point(278, 14);
            this.lblApellido.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(64, 19);
            this.lblApellido.TabIndex = 41;
            this.lblApellido.Text = "Apellido";
            // 
            // txtApellido
            // 
            this.txtApellido.Depth = 0;
            this.txtApellido.Hint = "";
            this.txtApellido.Location = new System.Drawing.Point(278, 36);
            this.txtApellido.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.PasswordChar = '\0';
            this.txtApellido.SelectedText = "";
            this.txtApellido.SelectionLength = 0;
            this.txtApellido.SelectionStart = 0;
            this.txtApellido.Size = new System.Drawing.Size(221, 23);
            this.txtApellido.TabIndex = 40;
            this.txtApellido.UseSystemPasswordChar = false;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Depth = 0;
            this.lblNombre.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblNombre.Location = new System.Drawing.Point(22, 14);
            this.lblNombre.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(63, 19);
            this.lblNombre.TabIndex = 39;
            this.lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Depth = 0;
            this.txtNombre.Hint = "";
            this.txtNombre.Location = new System.Drawing.Point(22, 36);
            this.txtNombre.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PasswordChar = '\0';
            this.txtNombre.SelectedText = "";
            this.txtNombre.SelectionLength = 0;
            this.txtNombre.SelectionStart = 0;
            this.txtNombre.Size = new System.Drawing.Size(221, 23);
            this.txtNombre.TabIndex = 38;
            this.txtNombre.UseSystemPasswordChar = false;
            // 
            // cboMateria
            // 
            this.cboMateria.FormattingEnabled = true;
            this.cboMateria.Location = new System.Drawing.Point(473, 312);
            this.cboMateria.Name = "cboMateria";
            this.cboMateria.Size = new System.Drawing.Size(162, 23);
            this.cboMateria.TabIndex = 76;
            // 
            // frmProfesores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(821, 621);
            this.Controls.Add(this.cboMateria);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btmAgregar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblBarrio);
            this.Controls.Add(this.lblCiudad);
            this.Controls.Add(this.lblProvincia);
            this.Controls.Add(this.txtEstadoCivil);
            this.Controls.Add(this.lblEstadoCivil);
            this.Controls.Add(this.lblFechaIncripcion);
            this.Controls.Add(this.cboCurso);
            this.Controls.Add(this.lblCurso);
            this.Controls.Add(this.cboTecnicatura);
            this.Controls.Add(this.lblTecnicatura);
            this.Controls.Add(this.rbDesconocido);
            this.Controls.Add(this.rbFemenino);
            this.Controls.Add(this.rbMasculino);
            this.Controls.Add(this.lblSexo);
            this.Controls.Add(this.lblAltura);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.lblCalle);
            this.Controls.Add(this.txtCalle);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.materialSingleLineTextField2);
            this.Controls.Add(this.cboEmails);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblDni);
            this.Controls.Add(this.materialSingleLineTextField1);
            this.Controls.Add(this.lblFechaNacimiento);
            this.Controls.Add(this.dtpFechaNacimiento);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtNombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmProfesores";
            this.Text = "frmProfesores";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton btnGuardar;
        private MaterialSkin.Controls.MaterialFlatButton btmAgregar;
        private DataGridView dataGridView1;
        private ComboBox comboBox3;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private MaterialSkin.Controls.MaterialLabel lblBarrio;
        private MaterialSkin.Controls.MaterialLabel lblCiudad;
        private MaterialSkin.Controls.MaterialLabel lblProvincia;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtEstadoCivil;
        private MaterialSkin.Controls.MaterialLabel lblEstadoCivil;
        private MaterialSkin.Controls.MaterialLabel lblFechaIncripcion;
        private ComboBox cboCurso;
        private MaterialSkin.Controls.MaterialLabel lblCurso;
        private ComboBox cboTecnicatura;
        private MaterialSkin.Controls.MaterialLabel lblTecnicatura;
        private MaterialSkin.Controls.MaterialRadioButton rbDesconocido;
        private MaterialSkin.Controls.MaterialRadioButton rbFemenino;
        private MaterialSkin.Controls.MaterialRadioButton rbMasculino;
        private MaterialSkin.Controls.MaterialLabel lblSexo;
        private MaterialSkin.Controls.MaterialLabel lblAltura;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtAltura;
        private MaterialSkin.Controls.MaterialLabel lblCalle;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCalle;
        private MaterialSkin.Controls.MaterialLabel lblTelefono;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField2;
        private ComboBox cboEmails;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtEmail;
        private MaterialSkin.Controls.MaterialLabel lblEmail;
        private MaterialSkin.Controls.MaterialLabel lblDni;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField1;
        private MaterialSkin.Controls.MaterialLabel lblFechaNacimiento;
        private DateTimePicker dtpFechaNacimiento;
        private MaterialSkin.Controls.MaterialLabel lblApellido;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtApellido;
        private MaterialSkin.Controls.MaterialLabel lblNombre;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNombre;
        private ComboBox cboMateria;
    }
}