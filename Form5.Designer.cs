namespace WindowsFormsApp2
{
    partial class Form5
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
            this.buttonConfirmacionFinal = new System.Windows.Forms.Button();
            this.buttonCiudad = new System.Windows.Forms.Button();
            this.labelValorMilla = new System.Windows.Forms.Label();
            this.textBoxCiudad = new System.Windows.Forms.TextBox();
            this.buttonRazonSocial = new System.Windows.Forms.Button();
            this.labelCapacidadMax = new System.Windows.Forms.Label();
            this.textBoxRazonSocial = new System.Windows.Forms.TextBox();
            this.buttonCuit = new System.Windows.Forms.Button();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.textBoxCuit = new System.Windows.Forms.TextBox();
            this.buttonSalir = new System.Windows.Forms.Button();
            this.errorProviderCuit = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderRazonSocial = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderCiudad = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCuit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderRazonSocial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCiudad)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonConfirmacionFinal
            // 
            this.buttonConfirmacionFinal.BackColor = System.Drawing.SystemColors.ControlText;
            this.buttonConfirmacionFinal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonConfirmacionFinal.FlatAppearance.BorderSize = 0;
            this.buttonConfirmacionFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConfirmacionFinal.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonConfirmacionFinal.Location = new System.Drawing.Point(597, 222);
            this.buttonConfirmacionFinal.Name = "buttonConfirmacionFinal";
            this.buttonConfirmacionFinal.Size = new System.Drawing.Size(285, 136);
            this.buttonConfirmacionFinal.TabIndex = 30;
            this.buttonConfirmacionFinal.Text = "Agregar Cliente";
            this.buttonConfirmacionFinal.UseVisualStyleBackColor = false;
            this.buttonConfirmacionFinal.Click += new System.EventHandler(this.buttonConfirmacionFinal_Click_1);
            // 
            // buttonCiudad
            // 
            this.buttonCiudad.AutoSize = true;
            this.buttonCiudad.BackColor = System.Drawing.SystemColors.Control;
            this.buttonCiudad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCiudad.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonCiudad.Location = new System.Drawing.Point(423, 397);
            this.buttonCiudad.Name = "buttonCiudad";
            this.buttonCiudad.Size = new System.Drawing.Size(111, 34);
            this.buttonCiudad.TabIndex = 29;
            this.buttonCiudad.Text = "Aceptar";
            this.buttonCiudad.UseVisualStyleBackColor = false;
            this.buttonCiudad.Click += new System.EventHandler(this.buttonCiudad_Click);
            // 
            // labelValorMilla
            // 
            this.labelValorMilla.AutoSize = true;
            this.labelValorMilla.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValorMilla.Location = new System.Drawing.Point(17, 359);
            this.labelValorMilla.Name = "labelValorMilla";
            this.labelValorMilla.Size = new System.Drawing.Size(80, 25);
            this.labelValorMilla.TabIndex = 28;
            this.labelValorMilla.Text = "Ciudad";
            // 
            // textBoxCiudad
            // 
            this.errorProviderCiudad.SetError(this.textBoxCiudad, "Rellene el campo");
            this.textBoxCiudad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCiudad.Location = new System.Drawing.Point(17, 399);
            this.textBoxCiudad.Name = "textBoxCiudad";
            this.textBoxCiudad.Size = new System.Drawing.Size(400, 29);
            this.textBoxCiudad.TabIndex = 27;
            // 
            // buttonRazonSocial
            // 
            this.buttonRazonSocial.AutoSize = true;
            this.buttonRazonSocial.BackColor = System.Drawing.SystemColors.Control;
            this.buttonRazonSocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRazonSocial.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonRazonSocial.Location = new System.Drawing.Point(423, 273);
            this.buttonRazonSocial.Name = "buttonRazonSocial";
            this.buttonRazonSocial.Size = new System.Drawing.Size(111, 34);
            this.buttonRazonSocial.TabIndex = 26;
            this.buttonRazonSocial.Text = "Aceptar";
            this.buttonRazonSocial.UseVisualStyleBackColor = false;
            this.buttonRazonSocial.Click += new System.EventHandler(this.buttonRazonSocial_Click);
            // 
            // labelCapacidadMax
            // 
            this.labelCapacidadMax.AutoSize = true;
            this.labelCapacidadMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCapacidadMax.Location = new System.Drawing.Point(17, 235);
            this.labelCapacidadMax.Name = "labelCapacidadMax";
            this.labelCapacidadMax.Size = new System.Drawing.Size(139, 25);
            this.labelCapacidadMax.TabIndex = 25;
            this.labelCapacidadMax.Text = "Razon Social";
            // 
            // textBoxRazonSocial
            // 
            this.errorProviderRazonSocial.SetError(this.textBoxRazonSocial, "Rellene el campo");
            this.textBoxRazonSocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRazonSocial.Location = new System.Drawing.Point(17, 275);
            this.textBoxRazonSocial.Name = "textBoxRazonSocial";
            this.textBoxRazonSocial.Size = new System.Drawing.Size(400, 29);
            this.textBoxRazonSocial.TabIndex = 24;
            // 
            // buttonCuit
            // 
            this.buttonCuit.AutoSize = true;
            this.buttonCuit.BackColor = System.Drawing.SystemColors.Control;
            this.buttonCuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCuit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonCuit.Location = new System.Drawing.Point(423, 155);
            this.buttonCuit.Name = "buttonCuit";
            this.buttonCuit.Size = new System.Drawing.Size(111, 34);
            this.buttonCuit.TabIndex = 23;
            this.buttonCuit.Text = "Aceptar";
            this.buttonCuit.UseVisualStyleBackColor = false;
            this.buttonCuit.Click += new System.EventHandler(this.buttonCuit_Click);
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.Location = new System.Drawing.Point(17, 117);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(60, 25);
            this.labelNombre.TabIndex = 22;
            this.labelNombre.Text = "CUIT";
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.Location = new System.Drawing.Point(12, 9);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(358, 55);
            this.labelTitulo.TabIndex = 21;
            this.labelTitulo.Text = "Agregar Cliente";
            this.labelTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxCuit
            // 
            this.errorProviderCuit.SetError(this.textBoxCuit, "Rellene el campo");
            this.textBoxCuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCuit.Location = new System.Drawing.Point(17, 157);
            this.textBoxCuit.Name = "textBoxCuit";
            this.textBoxCuit.Size = new System.Drawing.Size(400, 29);
            this.textBoxCuit.TabIndex = 20;
            // 
            // buttonSalir
            // 
            this.buttonSalir.BackColor = System.Drawing.SystemColors.Control;
            this.buttonSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalir.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonSalir.Location = new System.Drawing.Point(839, 509);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(133, 43);
            this.buttonSalir.TabIndex = 19;
            this.buttonSalir.Text = "Salir";
            this.buttonSalir.UseVisualStyleBackColor = false;
            this.buttonSalir.Click += new System.EventHandler(this.buttonSalir_Click);
            // 
            // errorProviderCuit
            // 
            this.errorProviderCuit.ContainerControl = this;
            // 
            // errorProviderRazonSocial
            // 
            this.errorProviderRazonSocial.ContainerControl = this;
            // 
            // errorProviderCiudad
            // 
            this.errorProviderCiudad.ContainerControl = this;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.buttonConfirmacionFinal);
            this.Controls.Add(this.buttonCiudad);
            this.Controls.Add(this.labelValorMilla);
            this.Controls.Add(this.textBoxCiudad);
            this.Controls.Add(this.buttonRazonSocial);
            this.Controls.Add(this.labelCapacidadMax);
            this.Controls.Add(this.textBoxRazonSocial);
            this.Controls.Add(this.buttonCuit);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.labelTitulo);
            this.Controls.Add(this.textBoxCuit);
            this.Controls.Add(this.buttonSalir);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.MaximumSize = new System.Drawing.Size(1000, 600);
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "Form5";
            this.Text = "Form5";
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCuit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderRazonSocial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCiudad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonConfirmacionFinal;
        private System.Windows.Forms.Button buttonCiudad;
        private System.Windows.Forms.Label labelValorMilla;
        private System.Windows.Forms.TextBox textBoxCiudad;
        private System.Windows.Forms.Button buttonRazonSocial;
        private System.Windows.Forms.Label labelCapacidadMax;
        private System.Windows.Forms.TextBox textBoxRazonSocial;
        private System.Windows.Forms.Button buttonCuit;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.TextBox textBoxCuit;
        private System.Windows.Forms.Button buttonSalir;
        private System.Windows.Forms.ErrorProvider errorProviderCuit;
        private System.Windows.Forms.ErrorProvider errorProviderRazonSocial;
        private System.Windows.Forms.ErrorProvider errorProviderCiudad;
    }
}