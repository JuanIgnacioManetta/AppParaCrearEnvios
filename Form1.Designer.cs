namespace WindowsFormsApp2
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AgregarEnvio = new System.Windows.Forms.Button();
            this.ListarEnvios = new System.Windows.Forms.Button();
            this.Salir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(297, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(363, 223);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(264, 238);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(438, 55);
            this.label1.TabIndex = 1;
            this.label1.Text = "Aerolineas Manetta";
            // 
            // AgregarEnvio
            // 
            this.AgregarEnvio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AgregarEnvio.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgregarEnvio.Location = new System.Drawing.Point(263, 315);
            this.AgregarEnvio.Name = "AgregarEnvio";
            this.AgregarEnvio.Size = new System.Drawing.Size(191, 86);
            this.AgregarEnvio.TabIndex = 2;
            this.AgregarEnvio.Text = "Agregar Envio";
            this.AgregarEnvio.UseVisualStyleBackColor = true;
            this.AgregarEnvio.Click += new System.EventHandler(this.agregarButton_Click);
            // 
            // ListarEnvios
            // 
            this.ListarEnvios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ListarEnvios.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListarEnvios.Location = new System.Drawing.Point(511, 315);
            this.ListarEnvios.Name = "ListarEnvios";
            this.ListarEnvios.Size = new System.Drawing.Size(191, 86);
            this.ListarEnvios.TabIndex = 3;
            this.ListarEnvios.Text = "Listar Envios";
            this.ListarEnvios.UseVisualStyleBackColor = true;
            this.ListarEnvios.Click += new System.EventHandler(this.listarButton_Click);
            // 
            // Salir
            // 
            this.Salir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Salir.Location = new System.Drawing.Point(839, 506);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(133, 43);
            this.Salir.TabIndex = 4;
            this.Salir.Text = "Salir";
            this.Salir.UseVisualStyleBackColor = true;
            this.Salir.Click += new System.EventHandler(this.salirButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.Salir);
            this.Controls.Add(this.ListarEnvios);
            this.Controls.Add(this.AgregarEnvio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.MaximumSize = new System.Drawing.Size(1000, 600);
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AgregarEnvio;
        private System.Windows.Forms.Button ListarEnvios;
        private System.Windows.Forms.Button Salir;
    }
}