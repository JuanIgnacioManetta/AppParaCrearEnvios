namespace WindowsFormsApp2
{
    partial class Form3
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button3 = new System.Windows.Forms.Button();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.ListaAviones = new System.Windows.Forms.DataGridView();
            this.Aviones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LabelAvionTitulo = new System.Windows.Forms.Label();
            this.labelAvionSeleccionado = new System.Windows.Forms.Label();
            this.ListaClientes = new System.Windows.Forms.DataGridView();
            this.CuitClientes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelClienteSeleccionado = new System.Windows.Forms.Label();
            this.lableCliente = new System.Windows.Forms.Label();
            this.AgregarAvion = new System.Windows.Forms.Button();
            this.AgregarCliente = new System.Windows.Forms.Button();
            this.ConfirmarAvion = new System.Windows.Forms.Button();
            this.ConfirmarCliente = new System.Windows.Forms.Button();
            this.labelCodPaquete = new System.Windows.Forms.Label();
            this.textBoxCodPaquete = new System.Windows.Forms.TextBox();
            this.buttonCodPaquete = new System.Windows.Forms.Button();
            this.buttonMonto = new System.Windows.Forms.Button();
            this.textBoxMonto = new System.Windows.Forms.TextBox();
            this.labelMonto = new System.Windows.Forms.Label();
            this.buttonOrigen = new System.Windows.Forms.Button();
            this.textBoxOrigen = new System.Windows.Forms.TextBox();
            this.labelOrigen = new System.Windows.Forms.Label();
            this.buttonDestino = new System.Windows.Forms.Button();
            this.textBoxDestino = new System.Windows.Forms.TextBox();
            this.labelDestino = new System.Windows.Forms.Label();
            this.buttonDescripcion = new System.Windows.Forms.Button();
            this.textBoxDescripcion = new System.Windows.Forms.TextBox();
            this.labelDescripcion = new System.Windows.Forms.Label();
            this.buttonConfirmarEnvio = new System.Windows.Forms.Button();
            this.errorProviderCodPaq = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderMonto = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderOrigen = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderDestino = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderDescripcion = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ListaAviones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListaClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCodPaq)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderMonto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderOrigen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDestino)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDescripcion)).BeginInit();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Control;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.Location = new System.Drawing.Point(839, 506);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(133, 43);
            this.button3.TabIndex = 6;
            this.button3.Text = "Salir";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.salirButton_Click);
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.Location = new System.Drawing.Point(12, 6);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(329, 55);
            this.labelTitulo.TabIndex = 8;
            this.labelTitulo.Text = "Agregar Envio";
            this.labelTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ListaAviones
            // 
            this.ListaAviones.AllowUserToAddRows = false;
            this.ListaAviones.AllowUserToDeleteRows = false;
            this.ListaAviones.AllowUserToResizeRows = false;
            dataGridViewCellStyle25.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle25.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle25.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle25.SelectionForeColor = System.Drawing.Color.White;
            this.ListaAviones.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle25;
            this.ListaAviones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.ListaAviones.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.ListaAviones.BackgroundColor = System.Drawing.Color.Black;
            this.ListaAviones.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle26.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle26.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ListaAviones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle26;
            this.ListaAviones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListaAviones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Aviones});
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle28.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            dataGridViewCellStyle28.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle28.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle28.SelectionBackColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle28.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle28.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ListaAviones.DefaultCellStyle = dataGridViewCellStyle28;
            this.ListaAviones.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ListaAviones.Location = new System.Drawing.Point(12, 70);
            this.ListaAviones.Name = "ListaAviones";
            this.ListaAviones.ReadOnly = true;
            this.ListaAviones.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.ListaAviones.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.Black;
            this.ListaAviones.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListaAviones.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.ListaAviones.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Black;
            this.ListaAviones.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.ListaAviones.Size = new System.Drawing.Size(170, 150);
            this.ListaAviones.TabIndex = 10;
            this.ListaAviones.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListaAviones_CellContentClick);
            // 
            // Aviones
            // 
            this.Aviones.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle27.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle27.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.Color.White;
            this.Aviones.DefaultCellStyle = dataGridViewCellStyle27;
            this.Aviones.HeaderText = "Column1";
            this.Aviones.MinimumWidth = 10;
            this.Aviones.Name = "Aviones";
            this.Aviones.ReadOnly = true;
            this.Aviones.Width = 93;
            // 
            // LabelAvionTitulo
            // 
            this.LabelAvionTitulo.AutoSize = true;
            this.LabelAvionTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelAvionTitulo.Location = new System.Drawing.Point(185, 70);
            this.LabelAvionTitulo.Name = "LabelAvionTitulo";
            this.LabelAvionTitulo.Size = new System.Drawing.Size(230, 24);
            this.LabelAvionTitulo.TabIndex = 11;
            this.LabelAvionTitulo.Text = "El avion seleccionado es: ";
            // 
            // labelAvionSeleccionado
            // 
            this.labelAvionSeleccionado.AutoSize = true;
            this.labelAvionSeleccionado.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAvionSeleccionado.Location = new System.Drawing.Point(185, 135);
            this.labelAvionSeleccionado.Name = "labelAvionSeleccionado";
            this.labelAvionSeleccionado.Size = new System.Drawing.Size(157, 37);
            this.labelAvionSeleccionado.TabIndex = 12;
            this.labelAvionSeleccionado.Text = "Chargin...";
            // 
            // ListaClientes
            // 
            this.ListaClientes.AllowUserToAddRows = false;
            this.ListaClientes.AllowUserToDeleteRows = false;
            this.ListaClientes.AllowUserToResizeRows = false;
            dataGridViewCellStyle29.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle29.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle29.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle29.SelectionForeColor = System.Drawing.Color.White;
            this.ListaClientes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle29;
            this.ListaClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.ListaClientes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.ListaClientes.BackgroundColor = System.Drawing.Color.Black;
            this.ListaClientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle30.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle30.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle30.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle30.SelectionBackColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle30.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle30.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ListaClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle30;
            this.ListaClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListaClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CuitClientes});
            dataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle32.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            dataGridViewCellStyle32.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle32.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle32.SelectionBackColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle32.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle32.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ListaClientes.DefaultCellStyle = dataGridViewCellStyle32;
            this.ListaClientes.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ListaClientes.Location = new System.Drawing.Point(12, 270);
            this.ListaClientes.Name = "ListaClientes";
            this.ListaClientes.ReadOnly = true;
            this.ListaClientes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.ListaClientes.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.Black;
            this.ListaClientes.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListaClientes.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.ListaClientes.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Black;
            this.ListaClientes.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.ListaClientes.Size = new System.Drawing.Size(170, 150);
            this.ListaClientes.TabIndex = 13;
            this.ListaClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // CuitClientes
            // 
            this.CuitClientes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle31.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle31.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle31.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle31.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle31.SelectionForeColor = System.Drawing.Color.White;
            this.CuitClientes.DefaultCellStyle = dataGridViewCellStyle31;
            this.CuitClientes.HeaderText = "Column1";
            this.CuitClientes.MinimumWidth = 10;
            this.CuitClientes.Name = "CuitClientes";
            this.CuitClientes.ReadOnly = true;
            this.CuitClientes.Width = 93;
            // 
            // labelClienteSeleccionado
            // 
            this.labelClienteSeleccionado.AutoSize = true;
            this.labelClienteSeleccionado.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClienteSeleccionado.Location = new System.Drawing.Point(185, 335);
            this.labelClienteSeleccionado.Name = "labelClienteSeleccionado";
            this.labelClienteSeleccionado.Size = new System.Drawing.Size(157, 37);
            this.labelClienteSeleccionado.TabIndex = 15;
            this.labelClienteSeleccionado.Text = "Chargin...";
            // 
            // lableCliente
            // 
            this.lableCliente.AutoSize = true;
            this.lableCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lableCliente.Location = new System.Drawing.Point(185, 270);
            this.lableCliente.Name = "lableCliente";
            this.lableCliente.Size = new System.Drawing.Size(240, 24);
            this.lableCliente.TabIndex = 14;
            this.lableCliente.Text = "El cliente seleccionado es: ";
            // 
            // AgregarAvion
            // 
            this.AgregarAvion.AutoSize = true;
            this.AgregarAvion.BackColor = System.Drawing.SystemColors.Control;
            this.AgregarAvion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgregarAvion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AgregarAvion.Location = new System.Drawing.Point(12, 225);
            this.AgregarAvion.Name = "AgregarAvion";
            this.AgregarAvion.Size = new System.Drawing.Size(150, 39);
            this.AgregarAvion.TabIndex = 18;
            this.AgregarAvion.Text = "Agregar Avion";
            this.AgregarAvion.UseVisualStyleBackColor = false;
            this.AgregarAvion.Click += new System.EventHandler(this.AgregarAvion_Click);
            // 
            // AgregarCliente
            // 
            this.AgregarCliente.AutoSize = true;
            this.AgregarCliente.BackColor = System.Drawing.SystemColors.Control;
            this.AgregarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgregarCliente.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AgregarCliente.Location = new System.Drawing.Point(12, 425);
            this.AgregarCliente.Name = "AgregarCliente";
            this.AgregarCliente.Size = new System.Drawing.Size(151, 39);
            this.AgregarCliente.TabIndex = 19;
            this.AgregarCliente.Text = "Agregar Cliente";
            this.AgregarCliente.UseVisualStyleBackColor = false;
            this.AgregarCliente.Click += new System.EventHandler(this.AgregarCliente_Click);
            // 
            // ConfirmarAvion
            // 
            this.ConfirmarAvion.AutoSize = true;
            this.ConfirmarAvion.BackColor = System.Drawing.SystemColors.Control;
            this.ConfirmarAvion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmarAvion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ConfirmarAvion.Location = new System.Drawing.Point(192, 225);
            this.ConfirmarAvion.Name = "ConfirmarAvion";
            this.ConfirmarAvion.Size = new System.Drawing.Size(149, 39);
            this.ConfirmarAvion.TabIndex = 20;
            this.ConfirmarAvion.Text = "Confirmar";
            this.ConfirmarAvion.UseVisualStyleBackColor = false;
            this.ConfirmarAvion.Visible = false;
            this.ConfirmarAvion.Click += new System.EventHandler(this.ConfirmarAvion_Click);
            // 
            // ConfirmarCliente
            // 
            this.ConfirmarCliente.AutoSize = true;
            this.ConfirmarCliente.BackColor = System.Drawing.SystemColors.Control;
            this.ConfirmarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmarCliente.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ConfirmarCliente.Location = new System.Drawing.Point(192, 425);
            this.ConfirmarCliente.Name = "ConfirmarCliente";
            this.ConfirmarCliente.Size = new System.Drawing.Size(149, 39);
            this.ConfirmarCliente.TabIndex = 21;
            this.ConfirmarCliente.Text = "Confirmar";
            this.ConfirmarCliente.UseVisualStyleBackColor = false;
            this.ConfirmarCliente.Visible = false;
            this.ConfirmarCliente.Click += new System.EventHandler(this.ConfirmarCliente_Click);
            // 
            // labelCodPaquete
            // 
            this.labelCodPaquete.AutoSize = true;
            this.labelCodPaquete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCodPaquete.Location = new System.Drawing.Point(451, 70);
            this.labelCodPaquete.Name = "labelCodPaquete";
            this.labelCodPaquete.Size = new System.Drawing.Size(151, 24);
            this.labelCodPaquete.TabIndex = 22;
            this.labelCodPaquete.Text = "Codigo Paquete:";
            // 
            // textBoxCodPaquete
            // 
            this.errorProviderCodPaq.SetError(this.textBoxCodPaquete, "Rellene el campo");
            this.textBoxCodPaquete.Location = new System.Drawing.Point(605, 72);
            this.textBoxCodPaquete.Name = "textBoxCodPaquete";
            this.textBoxCodPaquete.Size = new System.Drawing.Size(231, 20);
            this.textBoxCodPaquete.TabIndex = 23;
            // 
            // buttonCodPaquete
            // 
            this.buttonCodPaquete.AutoSize = true;
            this.buttonCodPaquete.BackColor = System.Drawing.SystemColors.Control;
            this.buttonCodPaquete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCodPaquete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonCodPaquete.Location = new System.Drawing.Point(839, 65);
            this.buttonCodPaquete.Name = "buttonCodPaquete";
            this.buttonCodPaquete.Size = new System.Drawing.Size(133, 34);
            this.buttonCodPaquete.TabIndex = 24;
            this.buttonCodPaquete.Text = "Confirmar";
            this.buttonCodPaquete.UseVisualStyleBackColor = false;
            this.buttonCodPaquete.Click += new System.EventHandler(this.buttonCodPaquete_Click);
            // 
            // buttonMonto
            // 
            this.buttonMonto.AutoSize = true;
            this.buttonMonto.BackColor = System.Drawing.SystemColors.Control;
            this.buttonMonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMonto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonMonto.Location = new System.Drawing.Point(839, 143);
            this.buttonMonto.Name = "buttonMonto";
            this.buttonMonto.Size = new System.Drawing.Size(133, 34);
            this.buttonMonto.TabIndex = 27;
            this.buttonMonto.Text = "Confirmar";
            this.buttonMonto.UseVisualStyleBackColor = false;
            this.buttonMonto.Click += new System.EventHandler(this.buttonMonto_Click);
            // 
            // textBoxMonto
            // 
            this.errorProviderMonto.SetError(this.textBoxMonto, "Rellene el campo");
            this.textBoxMonto.Location = new System.Drawing.Point(605, 150);
            this.textBoxMonto.Name = "textBoxMonto";
            this.textBoxMonto.Size = new System.Drawing.Size(231, 20);
            this.textBoxMonto.TabIndex = 26;
            // 
            // labelMonto
            // 
            this.labelMonto.AutoSize = true;
            this.labelMonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMonto.Location = new System.Drawing.Point(534, 148);
            this.labelMonto.Name = "labelMonto";
            this.labelMonto.Size = new System.Drawing.Size(68, 24);
            this.labelMonto.TabIndex = 25;
            this.labelMonto.Text = "Monto:";
            // 
            // buttonOrigen
            // 
            this.buttonOrigen.AutoSize = true;
            this.buttonOrigen.BackColor = System.Drawing.SystemColors.Control;
            this.buttonOrigen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOrigen.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonOrigen.Location = new System.Drawing.Point(839, 230);
            this.buttonOrigen.Name = "buttonOrigen";
            this.buttonOrigen.Size = new System.Drawing.Size(133, 34);
            this.buttonOrigen.TabIndex = 30;
            this.buttonOrigen.Text = "Confirmar";
            this.buttonOrigen.UseVisualStyleBackColor = false;
            this.buttonOrigen.Click += new System.EventHandler(this.buttonOrigen_Click);
            // 
            // textBoxOrigen
            // 
            this.errorProviderOrigen.SetError(this.textBoxOrigen, "Rellene el campo");
            this.textBoxOrigen.Location = new System.Drawing.Point(605, 237);
            this.textBoxOrigen.Name = "textBoxOrigen";
            this.textBoxOrigen.Size = new System.Drawing.Size(231, 20);
            this.textBoxOrigen.TabIndex = 29;
            // 
            // labelOrigen
            // 
            this.labelOrigen.AutoSize = true;
            this.labelOrigen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOrigen.Location = new System.Drawing.Point(529, 235);
            this.labelOrigen.Name = "labelOrigen";
            this.labelOrigen.Size = new System.Drawing.Size(73, 24);
            this.labelOrigen.TabIndex = 28;
            this.labelOrigen.Text = "Origen:";
            // 
            // buttonDestino
            // 
            this.buttonDestino.AutoSize = true;
            this.buttonDestino.BackColor = System.Drawing.SystemColors.Control;
            this.buttonDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDestino.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonDestino.Location = new System.Drawing.Point(839, 335);
            this.buttonDestino.Name = "buttonDestino";
            this.buttonDestino.Size = new System.Drawing.Size(133, 34);
            this.buttonDestino.TabIndex = 33;
            this.buttonDestino.Text = "Confirmar";
            this.buttonDestino.UseVisualStyleBackColor = false;
            this.buttonDestino.Click += new System.EventHandler(this.buttonDestino_Click);
            // 
            // textBoxDestino
            // 
            this.errorProviderDestino.SetError(this.textBoxDestino, "Rellene el campo");
            this.textBoxDestino.Location = new System.Drawing.Point(605, 342);
            this.textBoxDestino.Name = "textBoxDestino";
            this.textBoxDestino.Size = new System.Drawing.Size(231, 20);
            this.textBoxDestino.TabIndex = 32;
            // 
            // labelDestino
            // 
            this.labelDestino.AutoSize = true;
            this.labelDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDestino.Location = new System.Drawing.Point(524, 340);
            this.labelDestino.Name = "labelDestino";
            this.labelDestino.Size = new System.Drawing.Size(78, 24);
            this.labelDestino.TabIndex = 31;
            this.labelDestino.Text = "Destino:";
            // 
            // buttonDescripcion
            // 
            this.buttonDescripcion.AutoSize = true;
            this.buttonDescripcion.BackColor = System.Drawing.SystemColors.Control;
            this.buttonDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDescripcion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonDescripcion.Location = new System.Drawing.Point(839, 430);
            this.buttonDescripcion.Name = "buttonDescripcion";
            this.buttonDescripcion.Size = new System.Drawing.Size(133, 34);
            this.buttonDescripcion.TabIndex = 36;
            this.buttonDescripcion.Text = "Confirmar";
            this.buttonDescripcion.UseVisualStyleBackColor = false;
            this.buttonDescripcion.Click += new System.EventHandler(this.buttonDescripcion_Click);
            // 
            // textBoxDescripcion
            // 
            this.errorProviderDescripcion.SetError(this.textBoxDescripcion, "Rellene el campo");
            this.textBoxDescripcion.Location = new System.Drawing.Point(605, 437);
            this.textBoxDescripcion.Name = "textBoxDescripcion";
            this.textBoxDescripcion.Size = new System.Drawing.Size(231, 20);
            this.textBoxDescripcion.TabIndex = 35;
            // 
            // labelDescripcion
            // 
            this.labelDescripcion.AutoSize = true;
            this.labelDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescripcion.Location = new System.Drawing.Point(487, 435);
            this.labelDescripcion.Name = "labelDescripcion";
            this.labelDescripcion.Size = new System.Drawing.Size(115, 24);
            this.labelDescripcion.TabIndex = 34;
            this.labelDescripcion.Text = "Descripción:";
            // 
            // buttonConfirmarEnvio
            // 
            this.buttonConfirmarEnvio.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConfirmarEnvio.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonConfirmarEnvio.Location = new System.Drawing.Point(250, 480);
            this.buttonConfirmarEnvio.Name = "buttonConfirmarEnvio";
            this.buttonConfirmarEnvio.Size = new System.Drawing.Size(420, 70);
            this.buttonConfirmarEnvio.TabIndex = 37;
            this.buttonConfirmarEnvio.Text = "Confirmar Envio";
            this.buttonConfirmarEnvio.UseVisualStyleBackColor = true;
            this.buttonConfirmarEnvio.Visible = false;
            this.buttonConfirmarEnvio.Click += new System.EventHandler(this.buttonConfirmarEnvio_Click);
            // 
            // errorProviderCodPaq
            // 
            this.errorProviderCodPaq.ContainerControl = this;
            // 
            // errorProviderMonto
            // 
            this.errorProviderMonto.ContainerControl = this;
            // 
            // errorProviderOrigen
            // 
            this.errorProviderOrigen.ContainerControl = this;
            // 
            // errorProviderDestino
            // 
            this.errorProviderDestino.ContainerControl = this;
            // 
            // errorProviderDescripcion
            // 
            this.errorProviderDescripcion.ContainerControl = this;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.buttonConfirmarEnvio);
            this.Controls.Add(this.buttonDescripcion);
            this.Controls.Add(this.textBoxDescripcion);
            this.Controls.Add(this.labelDescripcion);
            this.Controls.Add(this.buttonDestino);
            this.Controls.Add(this.textBoxDestino);
            this.Controls.Add(this.labelDestino);
            this.Controls.Add(this.buttonOrigen);
            this.Controls.Add(this.textBoxOrigen);
            this.Controls.Add(this.labelOrigen);
            this.Controls.Add(this.buttonMonto);
            this.Controls.Add(this.textBoxMonto);
            this.Controls.Add(this.labelMonto);
            this.Controls.Add(this.buttonCodPaquete);
            this.Controls.Add(this.textBoxCodPaquete);
            this.Controls.Add(this.labelCodPaquete);
            this.Controls.Add(this.ConfirmarCliente);
            this.Controls.Add(this.ConfirmarAvion);
            this.Controls.Add(this.AgregarCliente);
            this.Controls.Add(this.AgregarAvion);
            this.Controls.Add(this.labelClienteSeleccionado);
            this.Controls.Add(this.lableCliente);
            this.Controls.Add(this.ListaClientes);
            this.Controls.Add(this.labelAvionSeleccionado);
            this.Controls.Add(this.LabelAvionTitulo);
            this.Controls.Add(this.ListaAviones);
            this.Controls.Add(this.labelTitulo);
            this.Controls.Add(this.button3);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.MaximumSize = new System.Drawing.Size(1000, 600);
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "Form3";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.ListaAviones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListaClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCodPaq)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderMonto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderOrigen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDestino)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDescripcion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.DataGridView ListaAviones;
        private System.Windows.Forms.Label LabelAvionTitulo;
        private System.Windows.Forms.Label labelAvionSeleccionado;
        private System.Windows.Forms.DataGridView ListaClientes;
        private System.Windows.Forms.Label labelClienteSeleccionado;
        private System.Windows.Forms.Label lableCliente;
        private System.Windows.Forms.Button AgregarAvion;
        private System.Windows.Forms.Button AgregarCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Aviones;
        private System.Windows.Forms.DataGridViewTextBoxColumn CuitClientes;
        private System.Windows.Forms.Button ConfirmarAvion;
        private System.Windows.Forms.Button ConfirmarCliente;
        private System.Windows.Forms.Label labelCodPaquete;
        private System.Windows.Forms.TextBox textBoxCodPaquete;
        private System.Windows.Forms.Button buttonCodPaquete;
        private System.Windows.Forms.Button buttonMonto;
        private System.Windows.Forms.TextBox textBoxMonto;
        private System.Windows.Forms.Label labelMonto;
        private System.Windows.Forms.Button buttonOrigen;
        private System.Windows.Forms.TextBox textBoxOrigen;
        private System.Windows.Forms.Label labelOrigen;
        private System.Windows.Forms.Button buttonDestino;
        private System.Windows.Forms.TextBox textBoxDestino;
        private System.Windows.Forms.Label labelDestino;
        private System.Windows.Forms.Button buttonDescripcion;
        private System.Windows.Forms.TextBox textBoxDescripcion;
        private System.Windows.Forms.Label labelDescripcion;
        private System.Windows.Forms.Button buttonConfirmarEnvio;
        private System.Windows.Forms.ErrorProvider errorProviderCodPaq;
        private System.Windows.Forms.ErrorProvider errorProviderMonto;
        private System.Windows.Forms.ErrorProvider errorProviderOrigen;
        private System.Windows.Forms.ErrorProvider errorProviderDestino;
        private System.Windows.Forms.ErrorProvider errorProviderDescripcion;
    }
}