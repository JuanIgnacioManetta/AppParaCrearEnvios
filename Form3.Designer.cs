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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button3 = new System.Windows.Forms.Button();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.ListaAviones = new System.Windows.Forms.DataGridView();
            this.LabelAvionTitulo = new System.Windows.Forms.Label();
            this.labelAvionSeleccionado = new System.Windows.Forms.Label();
            this.ListaClientes = new System.Windows.Forms.DataGridView();
            this.labelClienteSeleccionado = new System.Windows.Forms.Label();
            this.lableCliente = new System.Windows.Forms.Label();
            this.AgregarAvion = new System.Windows.Forms.Button();
            this.AgregarCliente = new System.Windows.Forms.Button();
            this.CuitClientes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Aviones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ListaAviones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListaClientes)).BeginInit();
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
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.ListaAviones.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ListaAviones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.ListaAviones.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.ListaAviones.BackgroundColor = System.Drawing.Color.Black;
            this.ListaAviones.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ListaAviones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ListaAviones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListaAviones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Aviones});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ListaAviones.DefaultCellStyle = dataGridViewCellStyle4;
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
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.ListaClientes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.ListaClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.ListaClientes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.ListaClientes.BackgroundColor = System.Drawing.Color.Black;
            this.ListaClientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ListaClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.ListaClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListaClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CuitClientes});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ListaClientes.DefaultCellStyle = dataGridViewCellStyle8;
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
            // CuitClientes
            // 
            this.CuitClientes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            this.CuitClientes.DefaultCellStyle = dataGridViewCellStyle7;
            this.CuitClientes.HeaderText = "Column1";
            this.CuitClientes.MinimumWidth = 10;
            this.CuitClientes.Name = "CuitClientes";
            this.CuitClientes.ReadOnly = true;
            this.CuitClientes.Width = 93;
            // 
            // Aviones
            // 
            this.Aviones.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.Aviones.DefaultCellStyle = dataGridViewCellStyle3;
            this.Aviones.HeaderText = "Column1";
            this.Aviones.MinimumWidth = 10;
            this.Aviones.Name = "Aviones";
            this.Aviones.ReadOnly = true;
            this.Aviones.Width = 93;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(984, 561);
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
    }
}