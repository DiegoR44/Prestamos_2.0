namespace ProyectoPrestamo.Formularios
{
    partial class frmResumenGeneral
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmResumenGeneral));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.dgvdata = new System.Windows.Forms.DataGridView();
            this.NroOperacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Formapago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoMoneda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MontoPrestamo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Intereses = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NroCuotas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MontoCuota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalIntereses = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MontoTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NroDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ciudad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NTelefonoCelular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnborrarbusqueda = new FontAwesome.Sharp.IconButton();
            this.btnbusqueda = new FontAwesome.Sharp.IconButton();
            this.cbobuscar = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtfechainicio = new System.Windows.Forms.DateTimePicker();
            this.txtfechafin = new System.Windows.Forms.DateTimePicker();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.btnexportarexcel = new FontAwesome.Sharp.IconButton();
            this.btnborrarfiltro = new FontAwesome.Sharp.IconButton();
            this.bunifuPanel4 = new Bunifu.UI.WinForms.BunifuPanel();
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.btnclausulas = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txtbuscar = new Bunifu.UI.WinForms.BunifuTextBox();
            this.bunifuSeparator1 = new Bunifu.UI.WinForms.BunifuSeparator();
            this.bunifuPanel5 = new Bunifu.UI.WinForms.BunifuPanel();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).BeginInit();
            this.bunifuPanel4.SuspendLayout();
            this.bunifuPanel1.SuspendLayout();
            this.bunifuPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvdata
            // 
            this.dgvdata.AllowUserToAddRows = false;
            this.dgvdata.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvdata.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdata.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NroOperacion,
            this.Estado,
            this.FechaRegistro,
            this.Formapago,
            this.TipoMoneda,
            this.FechaInicio,
            this.MontoPrestamo,
            this.Intereses,
            this.NroCuotas,
            this.MontoCuota,
            this.TotalIntereses,
            this.MontoTotal,
            this.NombreCliente,
            this.TipoDocumento,
            this.NroDocumento,
            this.Direccion,
            this.Ciudad,
            this.Correo,
            this.NTelefonoCelular});
            this.dgvdata.Location = new System.Drawing.Point(50, 33);
            this.dgvdata.MultiSelect = false;
            this.dgvdata.Name = "dgvdata";
            this.dgvdata.ReadOnly = true;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvdata.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvdata.RowTemplate.Height = 24;
            this.dgvdata.Size = new System.Drawing.Size(937, 267);
            this.dgvdata.TabIndex = 98;
            // 
            // NroOperacion
            // 
            this.NroOperacion.HeaderText = "Nº Operación";
            this.NroOperacion.Name = "NroOperacion";
            this.NroOperacion.ReadOnly = true;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            // 
            // FechaRegistro
            // 
            this.FechaRegistro.HeaderText = "Fecha Registro";
            this.FechaRegistro.Name = "FechaRegistro";
            this.FechaRegistro.ReadOnly = true;
            // 
            // Formapago
            // 
            this.Formapago.HeaderText = "Forma de pago";
            this.Formapago.Name = "Formapago";
            this.Formapago.ReadOnly = true;
            // 
            // TipoMoneda
            // 
            this.TipoMoneda.HeaderText = "Tipo Moneda";
            this.TipoMoneda.Name = "TipoMoneda";
            this.TipoMoneda.ReadOnly = true;
            // 
            // FechaInicio
            // 
            this.FechaInicio.HeaderText = "Fecha Inicio";
            this.FechaInicio.Name = "FechaInicio";
            this.FechaInicio.ReadOnly = true;
            // 
            // MontoPrestamo
            // 
            this.MontoPrestamo.HeaderText = "Monto Prestamo";
            this.MontoPrestamo.Name = "MontoPrestamo";
            this.MontoPrestamo.ReadOnly = true;
            // 
            // Intereses
            // 
            this.Intereses.HeaderText = "Intereses %";
            this.Intereses.Name = "Intereses";
            this.Intereses.ReadOnly = true;
            // 
            // NroCuotas
            // 
            this.NroCuotas.HeaderText = "Nº Cuotas";
            this.NroCuotas.Name = "NroCuotas";
            this.NroCuotas.ReadOnly = true;
            // 
            // MontoCuota
            // 
            this.MontoCuota.HeaderText = "Monto por Cuota";
            this.MontoCuota.Name = "MontoCuota";
            this.MontoCuota.ReadOnly = true;
            // 
            // TotalIntereses
            // 
            this.TotalIntereses.HeaderText = "Total Intereses";
            this.TotalIntereses.Name = "TotalIntereses";
            this.TotalIntereses.ReadOnly = true;
            // 
            // MontoTotal
            // 
            this.MontoTotal.HeaderText = "Monto Total";
            this.MontoTotal.Name = "MontoTotal";
            this.MontoTotal.ReadOnly = true;
            // 
            // NombreCliente
            // 
            this.NombreCliente.HeaderText = "Nombre Cliente";
            this.NombreCliente.Name = "NombreCliente";
            this.NombreCliente.ReadOnly = true;
            this.NombreCliente.Width = 110;
            // 
            // TipoDocumento
            // 
            this.TipoDocumento.HeaderText = "Tipo Documento";
            this.TipoDocumento.Name = "TipoDocumento";
            this.TipoDocumento.ReadOnly = true;
            // 
            // NroDocumento
            // 
            this.NroDocumento.HeaderText = "Nº Documento";
            this.NroDocumento.Name = "NroDocumento";
            this.NroDocumento.ReadOnly = true;
            this.NroDocumento.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.NroDocumento.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Direccion
            // 
            this.Direccion.HeaderText = "Dirección";
            this.Direccion.Name = "Direccion";
            this.Direccion.ReadOnly = true;
            // 
            // Ciudad
            // 
            this.Ciudad.HeaderText = "Ciudad";
            this.Ciudad.Name = "Ciudad";
            this.Ciudad.ReadOnly = true;
            // 
            // Correo
            // 
            this.Correo.HeaderText = "Correo";
            this.Correo.Name = "Correo";
            this.Correo.ReadOnly = true;
            // 
            // NTelefonoCelular
            // 
            this.NTelefonoCelular.HeaderText = "N° Telefono / Celular";
            this.NTelefonoCelular.Name = "NTelefonoCelular";
            this.NTelefonoCelular.ReadOnly = true;
            // 
            // btnborrarbusqueda
            // 
            this.btnborrarbusqueda.BackColor = System.Drawing.Color.Transparent;
            this.btnborrarbusqueda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnborrarbusqueda.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            this.btnborrarbusqueda.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnborrarbusqueda.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnborrarbusqueda.IconSize = 17;
            this.btnborrarbusqueda.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnborrarbusqueda.Location = new System.Drawing.Point(774, 81);
            this.btnborrarbusqueda.Name = "btnborrarbusqueda";
            this.btnborrarbusqueda.Size = new System.Drawing.Size(37, 21);
            this.btnborrarbusqueda.TabIndex = 104;
            this.btnborrarbusqueda.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnborrarbusqueda.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnborrarbusqueda.UseVisualStyleBackColor = false;
            this.btnborrarbusqueda.Click += new System.EventHandler(this.btnborrarbusqueda_Click);
            // 
            // btnbusqueda
            // 
            this.btnbusqueda.BackColor = System.Drawing.Color.Transparent;
            this.btnbusqueda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnbusqueda.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnbusqueda.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnbusqueda.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnbusqueda.IconSize = 17;
            this.btnbusqueda.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnbusqueda.Location = new System.Drawing.Point(733, 81);
            this.btnbusqueda.Name = "btnbusqueda";
            this.btnbusqueda.Size = new System.Drawing.Size(37, 21);
            this.btnbusqueda.TabIndex = 103;
            this.btnbusqueda.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnbusqueda.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnbusqueda.UseVisualStyleBackColor = false;
            this.btnbusqueda.Click += new System.EventHandler(this.btnbusqueda_Click);
            // 
            // cbobuscar
            // 
            this.cbobuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbobuscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbobuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbobuscar.FormattingEnabled = true;
            this.cbobuscar.Location = new System.Drawing.Point(474, 81);
            this.cbobuscar.Name = "cbobuscar";
            this.cbobuscar.Size = new System.Drawing.Size(145, 21);
            this.cbobuscar.TabIndex = 101;
            this.cbobuscar.SelectedIndexChanged += new System.EventHandler(this.cbobuscar_SelectedIndexChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(97, 62);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(769, 13);
            this.groupBox4.TabIndex = 105;
            this.groupBox4.TabStop = false;
            // 
            // txtfechainicio
            // 
            this.txtfechainicio.CustomFormat = "dd/MM/yyyy";
            this.txtfechainicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtfechainicio.Location = new System.Drawing.Point(266, 9);
            this.txtfechainicio.Name = "txtfechainicio";
            this.txtfechainicio.Size = new System.Drawing.Size(310, 20);
            this.txtfechainicio.TabIndex = 108;
            // 
            // txtfechafin
            // 
            this.txtfechafin.CustomFormat = "dd/MM/yyyy";
            this.txtfechafin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtfechafin.Location = new System.Drawing.Point(266, 44);
            this.txtfechafin.Name = "txtfechafin";
            this.txtfechafin.Size = new System.Drawing.Size(310, 20);
            this.txtfechafin.TabIndex = 110;
            // 
            // iconButton3
            // 
            this.iconButton3.BackColor = System.Drawing.Color.Transparent;
            this.iconButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.iconButton3.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.IconSize = 17;
            this.iconButton3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.iconButton3.Location = new System.Drawing.Point(680, 35);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Size = new System.Drawing.Size(37, 20);
            this.iconButton3.TabIndex = 111;
            this.iconButton3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton3.UseVisualStyleBackColor = false;
            this.iconButton3.Click += new System.EventHandler(this.iconButton3_Click);
            // 
            // btnexportarexcel
            // 
            this.btnexportarexcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnexportarexcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnexportarexcel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnexportarexcel.IconChar = FontAwesome.Sharp.IconChar.FileExcel;
            this.btnexportarexcel.IconColor = System.Drawing.Color.Red;
            this.btnexportarexcel.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnexportarexcel.IconSize = 17;
            this.btnexportarexcel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnexportarexcel.Location = new System.Drawing.Point(817, 82);
            this.btnexportarexcel.Name = "btnexportarexcel";
            this.btnexportarexcel.Size = new System.Drawing.Size(37, 21);
            this.btnexportarexcel.TabIndex = 112;
            this.btnexportarexcel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnexportarexcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnexportarexcel.UseVisualStyleBackColor = false;
            this.btnexportarexcel.Click += new System.EventHandler(this.btnexportarexcel_Click);
            // 
            // btnborrarfiltro
            // 
            this.btnborrarfiltro.BackColor = System.Drawing.Color.Transparent;
            this.btnborrarfiltro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnborrarfiltro.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            this.btnborrarfiltro.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnborrarfiltro.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnborrarfiltro.IconSize = 17;
            this.btnborrarfiltro.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnborrarfiltro.Location = new System.Drawing.Point(723, 35);
            this.btnborrarfiltro.Name = "btnborrarfiltro";
            this.btnborrarfiltro.Size = new System.Drawing.Size(37, 21);
            this.btnborrarfiltro.TabIndex = 113;
            this.btnborrarfiltro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnborrarfiltro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnborrarfiltro.UseVisualStyleBackColor = false;
            this.btnborrarfiltro.Click += new System.EventHandler(this.btnborrarfiltro_Click);
            // 
            // bunifuPanel4
            // 
            this.bunifuPanel4.BackgroundColor = System.Drawing.Color.White;
            this.bunifuPanel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel4.BackgroundImage")));
            this.bunifuPanel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel4.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel4.BorderRadius = 30;
            this.bunifuPanel4.BorderThickness = 1;
            this.bunifuPanel4.Controls.Add(this.dgvdata);
            this.bunifuPanel4.Location = new System.Drawing.Point(15, 199);
            this.bunifuPanel4.Name = "bunifuPanel4";
            this.bunifuPanel4.ShowBorders = true;
            this.bunifuPanel4.Size = new System.Drawing.Size(1036, 351);
            this.bunifuPanel4.TabIndex = 114;
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.White;
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BorderRadius = 30;
            this.bunifuPanel1.BorderThickness = 1;
            this.bunifuPanel1.Controls.Add(this.btnclausulas);
            this.bunifuPanel1.Controls.Add(this.label2);
            this.bunifuPanel1.Controls.Add(this.label1);
            this.bunifuPanel1.Controls.Add(this.label19);
            this.bunifuPanel1.Controls.Add(this.txtbuscar);
            this.bunifuPanel1.Controls.Add(this.txtfechafin);
            this.bunifuPanel1.Controls.Add(this.btnborrarfiltro);
            this.bunifuPanel1.Controls.Add(this.btnexportarexcel);
            this.bunifuPanel1.Controls.Add(this.iconButton3);
            this.bunifuPanel1.Controls.Add(this.cbobuscar);
            this.bunifuPanel1.Controls.Add(this.btnbusqueda);
            this.bunifuPanel1.Controls.Add(this.txtfechainicio);
            this.bunifuPanel1.Controls.Add(this.btnborrarbusqueda);
            this.bunifuPanel1.Controls.Add(this.groupBox4);
            this.bunifuPanel1.Location = new System.Drawing.Point(26, 70);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(1022, 114);
            this.bunifuPanel1.TabIndex = 115;
            // 
            // btnclausulas
            // 
            this.btnclausulas.AllowAnimations = true;
            this.btnclausulas.AllowMouseEffects = true;
            this.btnclausulas.AllowToggling = false;
            this.btnclausulas.AnimationSpeed = 200;
            this.btnclausulas.AutoGenerateColors = false;
            this.btnclausulas.AutoRoundBorders = false;
            this.btnclausulas.AutoSizeLeftIcon = true;
            this.btnclausulas.AutoSizeRightIcon = true;
            this.btnclausulas.BackColor = System.Drawing.Color.Transparent;
            this.btnclausulas.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(116)))), ((int)(((byte)(109)))));
            this.btnclausulas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnclausulas.BackgroundImage")));
            this.btnclausulas.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnclausulas.ButtonText = "Regresar";
            this.btnclausulas.ButtonTextMarginLeft = 0;
            this.btnclausulas.ColorContrastOnClick = 45;
            this.btnclausulas.ColorContrastOnHover = 45;
            this.btnclausulas.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnclausulas.CustomizableEdges = borderEdges2;
            this.btnclausulas.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnclausulas.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(116)))), ((int)(((byte)(109)))));
            this.btnclausulas.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(116)))), ((int)(((byte)(109)))));
            this.btnclausulas.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnclausulas.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.btnclausulas.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclausulas.ForeColor = System.Drawing.Color.White;
            this.btnclausulas.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnclausulas.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnclausulas.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnclausulas.IconMarginLeft = 11;
            this.btnclausulas.IconPadding = 10;
            this.btnclausulas.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnclausulas.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnclausulas.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnclausulas.IconSize = 25;
            this.btnclausulas.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(116)))), ((int)(((byte)(109)))));
            this.btnclausulas.IdleBorderRadius = 30;
            this.btnclausulas.IdleBorderThickness = 4;
            this.btnclausulas.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(116)))), ((int)(((byte)(109)))));
            this.btnclausulas.IdleIconLeftImage = null;
            this.btnclausulas.IdleIconRightImage = null;
            this.btnclausulas.IndicateFocus = false;
            this.btnclausulas.Location = new System.Drawing.Point(774, 20);
            this.btnclausulas.Name = "btnclausulas";
            this.btnclausulas.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(116)))), ((int)(((byte)(109)))));
            this.btnclausulas.OnDisabledState.BorderRadius = 30;
            this.btnclausulas.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnclausulas.OnDisabledState.BorderThickness = 4;
            this.btnclausulas.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(116)))), ((int)(((byte)(109)))));
            this.btnclausulas.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnclausulas.OnDisabledState.IconLeftImage = null;
            this.btnclausulas.OnDisabledState.IconRightImage = null;
            this.btnclausulas.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(116)))), ((int)(((byte)(109)))));
            this.btnclausulas.onHoverState.BorderRadius = 30;
            this.btnclausulas.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnclausulas.onHoverState.BorderThickness = 4;
            this.btnclausulas.onHoverState.FillColor = System.Drawing.Color.Transparent;
            this.btnclausulas.onHoverState.ForeColor = System.Drawing.Color.Black;
            this.btnclausulas.onHoverState.IconLeftImage = null;
            this.btnclausulas.onHoverState.IconRightImage = null;
            this.btnclausulas.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(116)))), ((int)(((byte)(109)))));
            this.btnclausulas.OnIdleState.BorderRadius = 30;
            this.btnclausulas.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnclausulas.OnIdleState.BorderThickness = 4;
            this.btnclausulas.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(116)))), ((int)(((byte)(109)))));
            this.btnclausulas.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnclausulas.OnIdleState.IconLeftImage = null;
            this.btnclausulas.OnIdleState.IconRightImage = null;
            this.btnclausulas.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(116)))), ((int)(((byte)(109)))));
            this.btnclausulas.OnPressedState.BorderRadius = 30;
            this.btnclausulas.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnclausulas.OnPressedState.BorderThickness = 4;
            this.btnclausulas.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(116)))), ((int)(((byte)(109)))));
            this.btnclausulas.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnclausulas.OnPressedState.IconLeftImage = null;
            this.btnclausulas.OnPressedState.IconRightImage = null;
            this.btnclausulas.Size = new System.Drawing.Size(81, 40);
            this.btnclausulas.TabIndex = 131;
            this.btnclausulas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnclausulas.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnclausulas.TextMarginLeft = 0;
            this.btnclausulas.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnclausulas.UseDefaultRadiusAndThickness = true;
            this.btnclausulas.Click += new System.EventHandler(this.btnclausulas_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(403, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 118;
            this.label2.Text = "Buscar Por:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(188, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 116;
            this.label1.Text = "Fecha de Fin";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.White;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label19.Location = new System.Drawing.Point(176, 15);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(84, 13);
            this.label19.TabIndex = 115;
            this.label19.Text = "Fecha de Inicio";
            // 
            // txtbuscar
            // 
            this.txtbuscar.AcceptsReturn = false;
            this.txtbuscar.AcceptsTab = false;
            this.txtbuscar.AnimationSpeed = 200;
            this.txtbuscar.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtbuscar.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtbuscar.AutoSizeHeight = true;
            this.txtbuscar.BackColor = System.Drawing.Color.Transparent;
            this.txtbuscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtbuscar.BackgroundImage")));
            this.txtbuscar.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtbuscar.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtbuscar.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtbuscar.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtbuscar.BorderRadius = 1;
            this.txtbuscar.BorderThickness = 1;
            this.txtbuscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtbuscar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbuscar.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txtbuscar.DefaultText = "";
            this.txtbuscar.FillColor = System.Drawing.Color.White;
            this.txtbuscar.HideSelection = true;
            this.txtbuscar.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtbuscar.IconLeft")));
            this.txtbuscar.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbuscar.IconPadding = 10;
            this.txtbuscar.IconRight = null;
            this.txtbuscar.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbuscar.Lines = new string[0];
            this.txtbuscar.Location = new System.Drawing.Point(625, 78);
            this.txtbuscar.MaxLength = 32767;
            this.txtbuscar.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtbuscar.Modified = false;
            this.txtbuscar.Multiline = false;
            this.txtbuscar.Name = "txtbuscar";
            stateProperties5.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtbuscar.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtbuscar.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtbuscar.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.Silver;
            stateProperties8.FillColor = System.Drawing.Color.White;
            stateProperties8.ForeColor = System.Drawing.Color.Empty;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtbuscar.OnIdleState = stateProperties8;
            this.txtbuscar.Padding = new System.Windows.Forms.Padding(3);
            this.txtbuscar.PasswordChar = '\0';
            this.txtbuscar.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtbuscar.PlaceholderText = "Busqueda";
            this.txtbuscar.ReadOnly = false;
            this.txtbuscar.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtbuscar.SelectedText = "";
            this.txtbuscar.SelectionLength = 0;
            this.txtbuscar.SelectionStart = 0;
            this.txtbuscar.ShortcutsEnabled = true;
            this.txtbuscar.Size = new System.Drawing.Size(103, 27);
            this.txtbuscar.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtbuscar.TabIndex = 114;
            this.txtbuscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtbuscar.TextMarginBottom = 0;
            this.txtbuscar.TextMarginLeft = 3;
            this.txtbuscar.TextMarginTop = 1;
            this.txtbuscar.TextPlaceholder = "Busqueda";
            this.txtbuscar.UseSystemPasswordChar = false;
            this.txtbuscar.WordWrap = true;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuSeparator1.BackgroundImage")));
            this.bunifuSeparator1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuSeparator1.DashCap = Bunifu.UI.WinForms.BunifuSeparator.CapStyles.Flat;
            this.bunifuSeparator1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(116)))), ((int)(((byte)(109)))));
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(116)))), ((int)(((byte)(109)))));
            this.bunifuSeparator1.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.LeftEdgeFaded;
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(26, 182);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal;
            this.bunifuSeparator1.Size = new System.Drawing.Size(1025, 11);
            this.bunifuSeparator1.TabIndex = 99;
            // 
            // bunifuPanel5
            // 
            this.bunifuPanel5.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.bunifuPanel5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel5.BackgroundImage")));
            this.bunifuPanel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel5.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel5.BorderRadius = 30;
            this.bunifuPanel5.BorderThickness = 1;
            this.bunifuPanel5.Controls.Add(this.bunifuLabel1);
            this.bunifuPanel5.Controls.Add(this.pictureBox1);
            this.bunifuPanel5.Location = new System.Drawing.Point(30, -3);
            this.bunifuPanel5.Name = "bunifuPanel5";
            this.bunifuPanel5.ShowBorders = true;
            this.bunifuPanel5.Size = new System.Drawing.Size(1018, 67);
            this.bunifuPanel5.TabIndex = 133;
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.AutoSize = false;
            this.bunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuLabel1.Location = new System.Drawing.Point(360, 13);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(432, 39);
            this.bunifuLabel1.TabIndex = 65;
            this.bunifuLabel1.Text = "Resumenes Generales";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-65, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(196, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // frmResumenGeneral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 566);
            this.Controls.Add(this.bunifuPanel5);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.bunifuPanel1);
            this.Controls.Add(this.bunifuPanel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmResumenGeneral";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmResumenGeneral_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).EndInit();
            this.bunifuPanel4.ResumeLayout(false);
            this.bunifuPanel1.ResumeLayout(false);
            this.bunifuPanel1.PerformLayout();
            this.bunifuPanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvdata;
        private FontAwesome.Sharp.IconButton btnborrarbusqueda;
        private FontAwesome.Sharp.IconButton btnbusqueda;
        private System.Windows.Forms.ComboBox cbobuscar;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DateTimePicker txtfechainicio;
        private System.Windows.Forms.DateTimePicker txtfechafin;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton btnexportarexcel;
        private FontAwesome.Sharp.IconButton btnborrarfiltro;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroOperacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Formapago;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoMoneda;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn MontoPrestamo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Intereses;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroCuotas;
        private System.Windows.Forms.DataGridViewTextBoxColumn MontoCuota;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalIntereses;
        private System.Windows.Forms.DataGridViewTextBoxColumn MontoTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ciudad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn NTelefonoCelular;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel4;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private Bunifu.UI.WinForms.BunifuSeparator bunifuSeparator1;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel5;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.UI.WinForms.BunifuTextBox txtbuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label19;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 btnclausulas;
    }
}