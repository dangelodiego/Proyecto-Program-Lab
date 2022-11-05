namespace TecnicaturasPresentacion.Principal.Alumnos
{
    partial class frmAlumnos
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
            this.txtNombre = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblNombre = new MaterialSkin.Controls.MaterialLabel();
            this.lblApellido = new MaterialSkin.Controls.MaterialLabel();
            this.txtApellido = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.lblFechaNacimiento = new MaterialSkin.Controls.MaterialLabel();
            this.lblDni = new MaterialSkin.Controls.MaterialLabel();
            this.materialSingleLineTextField1 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblEmail = new MaterialSkin.Controls.MaterialLabel();
            this.txtEmail = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.cboEmails = new System.Windows.Forms.ComboBox();
            this.lblTelefono = new MaterialSkin.Controls.MaterialLabel();
            this.materialSingleLineTextField2 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblAltura = new MaterialSkin.Controls.MaterialLabel();
            this.txtAltura = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblCalle = new MaterialSkin.Controls.MaterialLabel();
            this.txtCalle = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblSexo = new MaterialSkin.Controls.MaterialLabel();
            this.rbMasculino = new MaterialSkin.Controls.MaterialRadioButton();
            this.rbFemenino = new MaterialSkin.Controls.MaterialRadioButton();
            this.rbDesconocido = new MaterialSkin.Controls.MaterialRadioButton();
            this.lblTecnicatura = new MaterialSkin.Controls.MaterialLabel();
            this.cboTecnicatura = new System.Windows.Forms.ComboBox();
            this.lblCurso = new MaterialSkin.Controls.MaterialLabel();
            this.cboCurso = new System.Windows.Forms.ComboBox();
            this.lblFechaIncripcion = new MaterialSkin.Controls.MaterialLabel();
            this.dtpFechaInscripcion = new System.Windows.Forms.DateTimePicker();
            this.btmAgregar = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnGuardar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.cboEstadoCivil = new System.Windows.Forms.ComboBox();
            this.cboBarrio = new System.Windows.Forms.ComboBox();
            this.cboCiudad = new System.Windows.Forms.ComboBox();
            this.cboProvincia = new System.Windows.Forms.ComboBox();
            this.lblBarrio = new MaterialSkin.Controls.MaterialLabel();
            this.lblCiudad = new MaterialSkin.Controls.MaterialLabel();
            this.lblProvincia = new MaterialSkin.Controls.MaterialLabel();
            this.lblEstadoCivil = new MaterialSkin.Controls.MaterialLabel();
            this.dgvAlumnos = new System.Windows.Forms.DataGridView();
            this.colIDALU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombreAlu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colApellidoAlu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFechaNacAlu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDniAlu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmailAlu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTelAlu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSexoAlu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCalleAlu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAlturaAlu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstadoCivAlu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProvAlu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCiudadAlu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBarrioAlu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTecnicaturaAlu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCursoAlu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFechaInscAlu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Depth = 0;
            this.txtNombre.Hint = "";
            this.txtNombre.Location = new System.Drawing.Point(24, 44);
            this.txtNombre.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PasswordChar = '\0';
            this.txtNombre.SelectedText = "";
            this.txtNombre.SelectionLength = 0;
            this.txtNombre.SelectionStart = 0;
            this.txtNombre.Size = new System.Drawing.Size(221, 23);
            this.txtNombre.TabIndex = 0;
            this.txtNombre.UseSystemPasswordChar = false;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Depth = 0;
            this.lblNombre.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblNombre.Location = new System.Drawing.Point(24, 22);
            this.lblNombre.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(63, 19);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Depth = 0;
            this.lblApellido.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblApellido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblApellido.Location = new System.Drawing.Point(280, 22);
            this.lblApellido.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(64, 19);
            this.lblApellido.TabIndex = 3;
            this.lblApellido.Text = "Apellido";
            // 
            // txtApellido
            // 
            this.txtApellido.Depth = 0;
            this.txtApellido.Hint = "";
            this.txtApellido.Location = new System.Drawing.Point(280, 44);
            this.txtApellido.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.PasswordChar = '\0';
            this.txtApellido.SelectedText = "";
            this.txtApellido.SelectionLength = 0;
            this.txtApellido.SelectionStart = 0;
            this.txtApellido.Size = new System.Drawing.Size(221, 23);
            this.txtApellido.TabIndex = 1;
            this.txtApellido.UseSystemPasswordChar = false;
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(181, 84);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(200, 23);
            this.dtpFechaNacimiento.TabIndex = 2;
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Depth = 0;
            this.lblFechaNacimiento.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFechaNacimiento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblFechaNacimiento.Location = new System.Drawing.Point(24, 85);
            this.lblFechaNacimiento.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(155, 19);
            this.lblFechaNacimiento.TabIndex = 5;
            this.lblFechaNacimiento.Text = "Fecha de Nacimiento:";
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Depth = 0;
            this.lblDni.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDni.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDni.Location = new System.Drawing.Point(401, 85);
            this.lblDni.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(38, 19);
            this.lblDni.TabIndex = 7;
            this.lblDni.Text = "DNI:";
            // 
            // materialSingleLineTextField1
            // 
            this.materialSingleLineTextField1.Depth = 0;
            this.materialSingleLineTextField1.Hint = "";
            this.materialSingleLineTextField1.Location = new System.Drawing.Point(439, 84);
            this.materialSingleLineTextField1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField1.Name = "materialSingleLineTextField1";
            this.materialSingleLineTextField1.PasswordChar = '\0';
            this.materialSingleLineTextField1.SelectedText = "";
            this.materialSingleLineTextField1.SelectionLength = 0;
            this.materialSingleLineTextField1.SelectionStart = 0;
            this.materialSingleLineTextField1.Size = new System.Drawing.Size(221, 23);
            this.materialSingleLineTextField1.TabIndex = 3;
            this.materialSingleLineTextField1.UseSystemPasswordChar = false;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Depth = 0;
            this.lblEmail.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblEmail.Location = new System.Drawing.Point(24, 146);
            this.lblEmail.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(61, 19);
            this.lblEmail.TabIndex = 8;
            this.lblEmail.Text = "E-MAIL:";
            // 
            // txtEmail
            // 
            this.txtEmail.Depth = 0;
            this.txtEmail.Hint = "";
            this.txtEmail.Location = new System.Drawing.Point(91, 142);
            this.txtEmail.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.SelectedText = "";
            this.txtEmail.SelectionLength = 0;
            this.txtEmail.SelectionStart = 0;
            this.txtEmail.Size = new System.Drawing.Size(221, 23);
            this.txtEmail.TabIndex = 4;
            this.txtEmail.UseSystemPasswordChar = false;
            // 
            // cboEmails
            // 
            this.cboEmails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this.cboEmails.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEmails.FormattingEnabled = true;
            this.cboEmails.Items.AddRange(new object[] {
            "@gmail.com",
            "@yahoo.com",
            "@outlock.com",
            "@hotmail.com"});
            this.cboEmails.Location = new System.Drawing.Point(318, 142);
            this.cboEmails.Name = "cboEmails";
            this.cboEmails.Size = new System.Drawing.Size(121, 23);
            this.cboEmails.TabIndex = 5;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Depth = 0;
            this.lblTelefono.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTelefono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTelefono.Location = new System.Drawing.Point(24, 183);
            this.lblTelefono.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(73, 19);
            this.lblTelefono.TabIndex = 12;
            this.lblTelefono.Text = "Teléfono:";
            // 
            // materialSingleLineTextField2
            // 
            this.materialSingleLineTextField2.Depth = 0;
            this.materialSingleLineTextField2.Hint = "";
            this.materialSingleLineTextField2.Location = new System.Drawing.Point(100, 179);
            this.materialSingleLineTextField2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField2.Name = "materialSingleLineTextField2";
            this.materialSingleLineTextField2.PasswordChar = '\0';
            this.materialSingleLineTextField2.SelectedText = "";
            this.materialSingleLineTextField2.SelectionLength = 0;
            this.materialSingleLineTextField2.SelectionStart = 0;
            this.materialSingleLineTextField2.Size = new System.Drawing.Size(221, 23);
            this.materialSingleLineTextField2.TabIndex = 6;
            this.materialSingleLineTextField2.UseSystemPasswordChar = false;
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Depth = 0;
            this.lblAltura.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAltura.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblAltura.Location = new System.Drawing.Point(280, 220);
            this.lblAltura.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(49, 19);
            this.lblAltura.TabIndex = 16;
            this.lblAltura.Text = "Altura";
            // 
            // txtAltura
            // 
            this.txtAltura.Depth = 0;
            this.txtAltura.Hint = "";
            this.txtAltura.Location = new System.Drawing.Point(280, 242);
            this.txtAltura.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.PasswordChar = '\0';
            this.txtAltura.SelectedText = "";
            this.txtAltura.SelectionLength = 0;
            this.txtAltura.SelectionStart = 0;
            this.txtAltura.Size = new System.Drawing.Size(221, 23);
            this.txtAltura.TabIndex = 11;
            this.txtAltura.UseSystemPasswordChar = false;
            // 
            // lblCalle
            // 
            this.lblCalle.AutoSize = true;
            this.lblCalle.Depth = 0;
            this.lblCalle.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCalle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCalle.Location = new System.Drawing.Point(24, 220);
            this.lblCalle.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCalle.Name = "lblCalle";
            this.lblCalle.Size = new System.Drawing.Size(43, 19);
            this.lblCalle.TabIndex = 14;
            this.lblCalle.Text = "Calle";
            // 
            // txtCalle
            // 
            this.txtCalle.Depth = 0;
            this.txtCalle.Hint = "";
            this.txtCalle.Location = new System.Drawing.Point(24, 242);
            this.txtCalle.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.PasswordChar = '\0';
            this.txtCalle.SelectedText = "";
            this.txtCalle.SelectionLength = 0;
            this.txtCalle.SelectionStart = 0;
            this.txtCalle.Size = new System.Drawing.Size(221, 23);
            this.txtCalle.TabIndex = 10;
            this.txtCalle.UseSystemPasswordChar = false;
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Depth = 0;
            this.lblSexo.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSexo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblSexo.Location = new System.Drawing.Point(615, 146);
            this.lblSexo.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(42, 19);
            this.lblSexo.TabIndex = 17;
            this.lblSexo.Text = "Sexo";
            // 
            // rbMasculino
            // 
            this.rbMasculino.AutoSize = true;
            this.rbMasculino.Depth = 0;
            this.rbMasculino.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbMasculino.Location = new System.Drawing.Point(474, 177);
            this.rbMasculino.Margin = new System.Windows.Forms.Padding(0);
            this.rbMasculino.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbMasculino.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbMasculino.Name = "rbMasculino";
            this.rbMasculino.Ripple = true;
            this.rbMasculino.Size = new System.Drawing.Size(93, 30);
            this.rbMasculino.TabIndex = 7;
            this.rbMasculino.TabStop = true;
            this.rbMasculino.Text = "Masculino";
            this.rbMasculino.UseVisualStyleBackColor = true;
            // 
            // rbFemenino
            // 
            this.rbFemenino.AutoSize = true;
            this.rbFemenino.Depth = 0;
            this.rbFemenino.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbFemenino.Location = new System.Drawing.Point(582, 177);
            this.rbFemenino.Margin = new System.Windows.Forms.Padding(0);
            this.rbFemenino.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbFemenino.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbFemenino.Name = "rbFemenino";
            this.rbFemenino.Ripple = true;
            this.rbFemenino.Size = new System.Drawing.Size(90, 30);
            this.rbFemenino.TabIndex = 8;
            this.rbFemenino.TabStop = true;
            this.rbFemenino.Text = "Femenino";
            this.rbFemenino.UseVisualStyleBackColor = true;
            // 
            // rbDesconocido
            // 
            this.rbDesconocido.AutoSize = true;
            this.rbDesconocido.Depth = 0;
            this.rbDesconocido.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbDesconocido.Location = new System.Drawing.Point(687, 177);
            this.rbDesconocido.Margin = new System.Windows.Forms.Padding(0);
            this.rbDesconocido.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbDesconocido.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbDesconocido.Name = "rbDesconocido";
            this.rbDesconocido.Ripple = true;
            this.rbDesconocido.Size = new System.Drawing.Size(109, 30);
            this.rbDesconocido.TabIndex = 9;
            this.rbDesconocido.TabStop = true;
            this.rbDesconocido.Text = "Desconocido";
            this.rbDesconocido.UseVisualStyleBackColor = true;
            // 
            // lblTecnicatura
            // 
            this.lblTecnicatura.AutoSize = true;
            this.lblTecnicatura.Depth = 0;
            this.lblTecnicatura.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTecnicatura.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTecnicatura.Location = new System.Drawing.Point(24, 361);
            this.lblTecnicatura.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTecnicatura.Name = "lblTecnicatura";
            this.lblTecnicatura.Size = new System.Drawing.Size(88, 19);
            this.lblTecnicatura.TabIndex = 21;
            this.lblTecnicatura.Text = "Tecnicatura";
            // 
            // cboTecnicatura
            // 
            this.cboTecnicatura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this.cboTecnicatura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTecnicatura.FormattingEnabled = true;
            this.cboTecnicatura.Location = new System.Drawing.Point(24, 392);
            this.cboTecnicatura.Name = "cboTecnicatura";
            this.cboTecnicatura.Size = new System.Drawing.Size(162, 23);
            this.cboTecnicatura.TabIndex = 16;
            // 
            // lblCurso
            // 
            this.lblCurso.AutoSize = true;
            this.lblCurso.Depth = 0;
            this.lblCurso.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCurso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCurso.Location = new System.Drawing.Point(256, 361);
            this.lblCurso.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCurso.Name = "lblCurso";
            this.lblCurso.Size = new System.Drawing.Size(49, 19);
            this.lblCurso.TabIndex = 23;
            this.lblCurso.Text = "Curso";
            // 
            // cboCurso
            // 
            this.cboCurso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCurso.FormattingEnabled = true;
            this.cboCurso.Location = new System.Drawing.Point(256, 392);
            this.cboCurso.Name = "cboCurso";
            this.cboCurso.Size = new System.Drawing.Size(162, 23);
            this.cboCurso.TabIndex = 17;
            // 
            // lblFechaIncripcion
            // 
            this.lblFechaIncripcion.AutoSize = true;
            this.lblFechaIncripcion.Depth = 0;
            this.lblFechaIncripcion.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFechaIncripcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblFechaIncripcion.Location = new System.Drawing.Point(475, 361);
            this.lblFechaIncripcion.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblFechaIncripcion.Name = "lblFechaIncripcion";
            this.lblFechaIncripcion.Size = new System.Drawing.Size(151, 19);
            this.lblFechaIncripcion.TabIndex = 25;
            this.lblFechaIncripcion.Text = "Fecha de Inscripción:";
            // 
            // dtpFechaInscripcion
            // 
            this.dtpFechaInscripcion.Location = new System.Drawing.Point(475, 392);
            this.dtpFechaInscripcion.Name = "dtpFechaInscripcion";
            this.dtpFechaInscripcion.Size = new System.Drawing.Size(200, 23);
            this.dtpFechaInscripcion.TabIndex = 18;
            // 
            // btmAgregar
            // 
            this.btmAgregar.AutoSize = true;
            this.btmAgregar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btmAgregar.Depth = 0;
            this.btmAgregar.Location = new System.Drawing.Point(738, 387);
            this.btmAgregar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btmAgregar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btmAgregar.Name = "btmAgregar";
            this.btmAgregar.Primary = false;
            this.btmAgregar.Size = new System.Drawing.Size(74, 36);
            this.btmAgregar.TabIndex = 19;
            this.btmAgregar.Text = "AGREGAR";
            this.btmAgregar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Depth = 0;
            this.btnGuardar.Location = new System.Drawing.Point(297, 578);
            this.btnGuardar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Primary = true;
            this.btnGuardar.Size = new System.Drawing.Size(204, 37);
            this.btnGuardar.TabIndex = 21;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // cboEstadoCivil
            // 
            this.cboEstadoCivil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstadoCivil.FormattingEnabled = true;
            this.cboEstadoCivil.Location = new System.Drawing.Point(24, 310);
            this.cboEstadoCivil.Name = "cboEstadoCivil";
            this.cboEstadoCivil.Size = new System.Drawing.Size(139, 23);
            this.cboEstadoCivil.TabIndex = 12;
            // 
            // cboBarrio
            // 
            this.cboBarrio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBarrio.FormattingEnabled = true;
            this.cboBarrio.Location = new System.Drawing.Point(578, 310);
            this.cboBarrio.Name = "cboBarrio";
            this.cboBarrio.Size = new System.Drawing.Size(141, 23);
            this.cboBarrio.TabIndex = 15;
            // 
            // cboCiudad
            // 
            this.cboCiudad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCiudad.FormattingEnabled = true;
            this.cboCiudad.Location = new System.Drawing.Point(403, 310);
            this.cboCiudad.Name = "cboCiudad";
            this.cboCiudad.Size = new System.Drawing.Size(145, 23);
            this.cboCiudad.TabIndex = 14;
            // 
            // cboProvincia
            // 
            this.cboProvincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProvincia.FormattingEnabled = true;
            this.cboProvincia.Location = new System.Drawing.Point(201, 310);
            this.cboProvincia.Name = "cboProvincia";
            this.cboProvincia.Size = new System.Drawing.Size(162, 23);
            this.cboProvincia.TabIndex = 13;
            // 
            // lblBarrio
            // 
            this.lblBarrio.AutoSize = true;
            this.lblBarrio.Depth = 0;
            this.lblBarrio.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBarrio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblBarrio.Location = new System.Drawing.Point(575, 288);
            this.lblBarrio.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblBarrio.Name = "lblBarrio";
            this.lblBarrio.Size = new System.Drawing.Size(49, 19);
            this.lblBarrio.TabIndex = 42;
            this.lblBarrio.Text = "Barrio";
            // 
            // lblCiudad
            // 
            this.lblCiudad.AutoSize = true;
            this.lblCiudad.Depth = 0;
            this.lblCiudad.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCiudad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCiudad.Location = new System.Drawing.Point(403, 288);
            this.lblCiudad.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCiudad.Name = "lblCiudad";
            this.lblCiudad.Size = new System.Drawing.Size(55, 19);
            this.lblCiudad.TabIndex = 41;
            this.lblCiudad.Text = "Ciudad";
            // 
            // lblProvincia
            // 
            this.lblProvincia.AutoSize = true;
            this.lblProvincia.Depth = 0;
            this.lblProvincia.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblProvincia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblProvincia.Location = new System.Drawing.Point(201, 288);
            this.lblProvincia.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblProvincia.Name = "lblProvincia";
            this.lblProvincia.Size = new System.Drawing.Size(71, 19);
            this.lblProvincia.TabIndex = 40;
            this.lblProvincia.Text = "Provincia";
            // 
            // lblEstadoCivil
            // 
            this.lblEstadoCivil.AutoSize = true;
            this.lblEstadoCivil.Depth = 0;
            this.lblEstadoCivil.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEstadoCivil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblEstadoCivil.Location = new System.Drawing.Point(24, 288);
            this.lblEstadoCivil.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblEstadoCivil.Name = "lblEstadoCivil";
            this.lblEstadoCivil.Size = new System.Drawing.Size(89, 19);
            this.lblEstadoCivil.TabIndex = 39;
            this.lblEstadoCivil.Text = "Estado Civil";
            // 
            // dgvAlumnos
            // 
            this.dgvAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlumnos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIDALU,
            this.colNombreAlu,
            this.colApellidoAlu,
            this.colFechaNacAlu,
            this.colDniAlu,
            this.colEmailAlu,
            this.colTelAlu,
            this.colSexoAlu,
            this.colCalleAlu,
            this.colAlturaAlu,
            this.colEstadoCivAlu,
            this.colProvAlu,
            this.colCiudadAlu,
            this.colBarrioAlu,
            this.colTecnicaturaAlu,
            this.colCursoAlu,
            this.colFechaInscAlu,
            this.colEliminar});
            this.dgvAlumnos.Location = new System.Drawing.Point(12, 432);
            this.dgvAlumnos.Name = "dgvAlumnos";
            this.dgvAlumnos.RowTemplate.Height = 25;
            this.dgvAlumnos.Size = new System.Drawing.Size(800, 134);
            this.dgvAlumnos.TabIndex = 20;
            // 
            // colIDALU
            // 
            this.colIDALU.HeaderText = "ID";
            this.colIDALU.Name = "colIDALU";
            // 
            // colNombreAlu
            // 
            this.colNombreAlu.HeaderText = "Nombre";
            this.colNombreAlu.Name = "colNombreAlu";
            // 
            // colApellidoAlu
            // 
            this.colApellidoAlu.HeaderText = "Apellido";
            this.colApellidoAlu.Name = "colApellidoAlu";
            // 
            // colFechaNacAlu
            // 
            this.colFechaNacAlu.HeaderText = "Fecha Nacimiento";
            this.colFechaNacAlu.Name = "colFechaNacAlu";
            // 
            // colDniAlu
            // 
            this.colDniAlu.HeaderText = "DNI";
            this.colDniAlu.Name = "colDniAlu";
            // 
            // colEmailAlu
            // 
            this.colEmailAlu.HeaderText = "E-MAIL";
            this.colEmailAlu.Name = "colEmailAlu";
            // 
            // colTelAlu
            // 
            this.colTelAlu.HeaderText = "Teléfono";
            this.colTelAlu.Name = "colTelAlu";
            // 
            // colSexoAlu
            // 
            this.colSexoAlu.HeaderText = "Sexo";
            this.colSexoAlu.Name = "colSexoAlu";
            // 
            // colCalleAlu
            // 
            this.colCalleAlu.HeaderText = "Calle";
            this.colCalleAlu.Name = "colCalleAlu";
            // 
            // colAlturaAlu
            // 
            this.colAlturaAlu.HeaderText = "Altura";
            this.colAlturaAlu.Name = "colAlturaAlu";
            // 
            // colEstadoCivAlu
            // 
            this.colEstadoCivAlu.HeaderText = "Estado Civil";
            this.colEstadoCivAlu.Name = "colEstadoCivAlu";
            // 
            // colProvAlu
            // 
            this.colProvAlu.HeaderText = "Provincia";
            this.colProvAlu.Name = "colProvAlu";
            // 
            // colCiudadAlu
            // 
            this.colCiudadAlu.HeaderText = "Ciudad";
            this.colCiudadAlu.Name = "colCiudadAlu";
            // 
            // colBarrioAlu
            // 
            this.colBarrioAlu.HeaderText = "Barrio";
            this.colBarrioAlu.Name = "colBarrioAlu";
            // 
            // colTecnicaturaAlu
            // 
            this.colTecnicaturaAlu.HeaderText = "Tecnicatura";
            this.colTecnicaturaAlu.Name = "colTecnicaturaAlu";
            // 
            // colCursoAlu
            // 
            this.colCursoAlu.HeaderText = "Curso";
            this.colCursoAlu.Name = "colCursoAlu";
            // 
            // colFechaInscAlu
            // 
            this.colFechaInscAlu.HeaderText = "Fecha Inscripción";
            this.colFechaInscAlu.Name = "colFechaInscAlu";
            // 
            // colEliminar
            // 
            this.colEliminar.HeaderText = "Eliminar";
            this.colEliminar.Name = "colEliminar";
            this.colEliminar.Text = "ELIMINAR";
            // 
            // frmAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(821, 621);
            this.Controls.Add(this.dgvAlumnos);
            this.Controls.Add(this.cboEstadoCivil);
            this.Controls.Add(this.cboBarrio);
            this.Controls.Add(this.cboCiudad);
            this.Controls.Add(this.cboProvincia);
            this.Controls.Add(this.lblBarrio);
            this.Controls.Add(this.lblCiudad);
            this.Controls.Add(this.lblProvincia);
            this.Controls.Add(this.lblEstadoCivil);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btmAgregar);
            this.Controls.Add(this.dtpFechaInscripcion);
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
            this.Name = "frmAlumnos";
            this.Text = "frmAlumnos";
            this.Load += new System.EventHandler(this.frmAlumnos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField txtNombre;
        private MaterialSkin.Controls.MaterialLabel lblNombre;
        private MaterialSkin.Controls.MaterialLabel lblApellido;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtApellido;
        private DateTimePicker dtpFechaNacimiento;
        private MaterialSkin.Controls.MaterialLabel lblFechaNacimiento;
        private MaterialSkin.Controls.MaterialLabel lblDni;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField1;
        private MaterialSkin.Controls.MaterialLabel lblEmail;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtEmail;
        private ComboBox cboEmails;
        private MaterialSkin.Controls.MaterialLabel lblTelefono;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField2;
        private MaterialSkin.Controls.MaterialLabel lblAltura;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtAltura;
        private MaterialSkin.Controls.MaterialLabel lblCalle;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCalle;
        private MaterialSkin.Controls.MaterialLabel lblSexo;
        private MaterialSkin.Controls.MaterialRadioButton rbMasculino;
        private MaterialSkin.Controls.MaterialRadioButton rbFemenino;
        private MaterialSkin.Controls.MaterialRadioButton rbDesconocido;
        private MaterialSkin.Controls.MaterialLabel lblTecnicatura;
        private ComboBox cboTecnicatura;
        private MaterialSkin.Controls.MaterialLabel lblCurso;
        private ComboBox cboCurso;
        private MaterialSkin.Controls.MaterialLabel lblFechaIncripcion;
        private DateTimePicker dtpFechaInscripcion;
        private MaterialSkin.Controls.MaterialFlatButton btmAgregar;
        private MaterialSkin.Controls.MaterialRaisedButton btnGuardar;
        private ComboBox cboEstadoCivil;
        private ComboBox cboBarrio;
        private ComboBox cboCiudad;
        private ComboBox cboProvincia;
        private MaterialSkin.Controls.MaterialLabel lblBarrio;
        private MaterialSkin.Controls.MaterialLabel lblCiudad;
        private MaterialSkin.Controls.MaterialLabel lblProvincia;
        private MaterialSkin.Controls.MaterialLabel lblEstadoCivil;
        private DataGridView dgvAlumnos;
        private DataGridViewTextBoxColumn colIDALU;
        private DataGridViewTextBoxColumn colNombreAlu;
        private DataGridViewTextBoxColumn colApellidoAlu;
        private DataGridViewTextBoxColumn colFechaNacAlu;
        private DataGridViewTextBoxColumn colDniAlu;
        private DataGridViewTextBoxColumn colEmailAlu;
        private DataGridViewTextBoxColumn colTelAlu;
        private DataGridViewTextBoxColumn colSexoAlu;
        private DataGridViewTextBoxColumn colCalleAlu;
        private DataGridViewTextBoxColumn colAlturaAlu;
        private DataGridViewTextBoxColumn colEstadoCivAlu;
        private DataGridViewTextBoxColumn colProvAlu;
        private DataGridViewTextBoxColumn colCiudadAlu;
        private DataGridViewTextBoxColumn colBarrioAlu;
        private DataGridViewTextBoxColumn colTecnicaturaAlu;
        private DataGridViewTextBoxColumn colCursoAlu;
        private DataGridViewTextBoxColumn colFechaInscAlu;
        private DataGridViewButtonColumn colEliminar;
    }
}