namespace WindowsFormsApp2
{
    partial class Form4
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
            this.buttonSalir = new System.Windows.Forms.Button();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.buttonNombre = new System.Windows.Forms.Button();
            this.buttonCapacidadMax = new System.Windows.Forms.Button();
            this.labelCapacidadMax = new System.Windows.Forms.Label();
            this.textBoxCapacidad = new System.Windows.Forms.TextBox();
            this.buttonValorXMilla = new System.Windows.Forms.Button();
            this.labelValorMilla = new System.Windows.Forms.Label();
            this.textBoxValorXMilla = new System.Windows.Forms.TextBox();
            this.errorProviderNombre = new System.Windows.Forms.ErrorProvider(this.components);
            this.buttonConfirmacionFinal = new System.Windows.Forms.Button();
            this.errorProviderCapacidad = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderValor = new System.Windows.Forms.ErrorProvider(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.errorProviderNombre.SetError(this.textBoxNombre, "Rellene el campo");
            this.errorProviderCapacidad.SetError(this.textBoxCapacidad, "Rellene el campo");
            this.errorProviderValor.SetError(this.textBoxValorXMilla, "Rellene el campo");
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNombre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCapacidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderValor)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSalir
            // 
            this.buttonSalir.BackColor = System.Drawing.SystemColors.Control;
            this.buttonSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalir.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonSalir.Location = new System.Drawing.Point(839, 506);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(133, 43);
            this.buttonSalir.TabIndex = 7;
            this.buttonSalir.Text = "Salir";
            this.buttonSalir.UseVisualStyleBackColor = false;
            this.buttonSalir.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(17, 154);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(400, 29);
            this.textBoxNombre.TabIndex = 8;
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.Location = new System.Drawing.Point(12, 6);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(329, 55);
            this.labelTitulo.TabIndex = 9;
            this.labelTitulo.Text = "Agregar Avion";
            this.labelTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.Location = new System.Drawing.Point(17, 114);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(87, 25);
            this.labelNombre.TabIndex = 10;
            this.labelNombre.Text = "Nombre";
            // 
            // buttonNombre
            // 
            this.buttonNombre.AutoSize = true;
            this.buttonNombre.BackColor = System.Drawing.SystemColors.Control;
            this.buttonNombre.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonNombre.Location = new System.Drawing.Point(423, 152);
            this.buttonNombre.Name = "buttonNombre";
            this.buttonNombre.Size = new System.Drawing.Size(111, 34);
            this.buttonNombre.TabIndex = 11;
            this.buttonNombre.Text = "Aceptar";
            this.buttonNombre.UseVisualStyleBackColor = false;
            this.buttonNombre.Click += new System.EventHandler(this.buttonNombre_Click);
            // 
            // buttonCapacidadMax
            // 
            this.buttonCapacidadMax.AutoSize = true;
            this.buttonCapacidadMax.BackColor = System.Drawing.SystemColors.Control;
            this.buttonCapacidadMax.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonCapacidadMax.Location = new System.Drawing.Point(423, 270);
            this.buttonCapacidadMax.Name = "buttonCapacidadMax";
            this.buttonCapacidadMax.Size = new System.Drawing.Size(111, 34);
            this.buttonCapacidadMax.TabIndex = 14;
            this.buttonCapacidadMax.Text = "Aceptar";
            this.buttonCapacidadMax.UseVisualStyleBackColor = false;
            this.buttonCapacidadMax.Click += new System.EventHandler(this.buttonCapacidadMax_Click);
            // 
            // labelCapacidadMax
            // 
            this.labelCapacidadMax.AutoSize = true;
            this.labelCapacidadMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCapacidadMax.Location = new System.Drawing.Point(17, 232);
            this.labelCapacidadMax.Name = "labelCapacidadMax";
            this.labelCapacidadMax.Size = new System.Drawing.Size(196, 25);
            this.labelCapacidadMax.TabIndex = 13;
            this.labelCapacidadMax.Text = "Capacidad Maxima";
            // 
            // textBoxCapacidad
            // 
            this.textBoxCapacidad.Location = new System.Drawing.Point(17, 272);
            this.textBoxCapacidad.Name = "textBoxCapacidad";
            this.textBoxCapacidad.Size = new System.Drawing.Size(400, 29);
            this.textBoxCapacidad.TabIndex = 12;
            // 
            // buttonValorXMilla
            // 
            this.buttonValorXMilla.AutoSize = true;
            this.buttonValorXMilla.BackColor = System.Drawing.SystemColors.Control;
            this.buttonValorXMilla.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonValorXMilla.Location = new System.Drawing.Point(423, 394);
            this.buttonValorXMilla.Name = "buttonValorXMilla";
            this.buttonValorXMilla.Size = new System.Drawing.Size(111, 34);
            this.buttonValorXMilla.TabIndex = 17;
            this.buttonValorXMilla.Text = "Aceptar";
            this.buttonValorXMilla.UseVisualStyleBackColor = false;
            this.buttonValorXMilla.Click += new System.EventHandler(this.buttonValorXMilla_Click);
            // 
            // labelValorMilla
            // 
            this.labelValorMilla.AutoSize = true;
            this.labelValorMilla.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValorMilla.Location = new System.Drawing.Point(17, 356);
            this.labelValorMilla.Name = "labelValorMilla";
            this.labelValorMilla.Size = new System.Drawing.Size(152, 25);
            this.labelValorMilla.TabIndex = 16;
            this.labelValorMilla.Text = "Valor Por Milla";
            // 
            // textBoxValorXMilla
            // 
            this.textBoxValorXMilla.Location = new System.Drawing.Point(17, 396);
            this.textBoxValorXMilla.Name = "textBoxValorXMilla";
            this.textBoxValorXMilla.Size = new System.Drawing.Size(400, 29);
            this.textBoxValorXMilla.TabIndex = 15;
            // 
            // errorProviderNombre
            // 
            this.errorProviderNombre.ContainerControl = this;
            // 
            // buttonConfirmacionFinal
            // 
            this.buttonConfirmacionFinal.BackColor = System.Drawing.SystemColors.ControlText;
            this.buttonConfirmacionFinal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonConfirmacionFinal.FlatAppearance.BorderSize = 0;
            this.buttonConfirmacionFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConfirmacionFinal.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonConfirmacionFinal.Location = new System.Drawing.Point(597, 219);
            this.buttonConfirmacionFinal.Name = "buttonConfirmacionFinal";
            this.buttonConfirmacionFinal.Size = new System.Drawing.Size(285, 136);
            this.buttonConfirmacionFinal.TabIndex = 18;
            this.buttonConfirmacionFinal.Text = "Agregar Avion";
            this.buttonConfirmacionFinal.UseVisualStyleBackColor = false;
            this.buttonConfirmacionFinal.Click += new System.EventHandler(this.buttonConfirmacionFinal_Click);
            // 
            // errorProviderCapacidad
            // 
            this.errorProviderCapacidad.ContainerControl = this;
            // 
            // errorProviderValor
            // 
            this.errorProviderValor.ContainerControl = this;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.buttonConfirmacionFinal);
            this.Controls.Add(this.buttonValorXMilla);
            this.Controls.Add(this.labelValorMilla);
            this.Controls.Add(this.textBoxValorXMilla);
            this.Controls.Add(this.buttonCapacidadMax);
            this.Controls.Add(this.labelCapacidadMax);
            this.Controls.Add(this.textBoxCapacidad);
            this.Controls.Add(this.buttonNombre);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.labelTitulo);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.buttonSalir);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximumSize = new System.Drawing.Size(1000, 600);
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "Form4";
            this.Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNombre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCapacidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderValor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSalir;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Button buttonNombre;
        private System.Windows.Forms.Button buttonCapacidadMax;
        private System.Windows.Forms.Label labelCapacidadMax;
        private System.Windows.Forms.TextBox textBoxCapacidad;
        private System.Windows.Forms.Button buttonValorXMilla;
        private System.Windows.Forms.Label labelValorMilla;
        private System.Windows.Forms.TextBox textBoxValorXMilla;
        private System.Windows.Forms.ErrorProvider errorProviderNombre;
        private System.Windows.Forms.Button buttonConfirmacionFinal;
        private System.Windows.Forms.ErrorProvider errorProviderCapacidad;
        private System.Windows.Forms.ErrorProvider errorProviderValor;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}