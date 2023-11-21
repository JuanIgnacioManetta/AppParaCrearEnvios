using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            AgregarDatosTablero();
        }
        public void AgregarDatosTablero()
        {
            StreamReader Lector;
            FileStream Archivo;
            Envios envios = new Envios();

            if(File.Exists("C:\\Users\\juanc\\source\\repos\\PracticaEnCasa\\WindowsForms\\WindowsFormsApp2\\Envios.csv") != false)
            {
                Archivo = new FileStream("C:\\Users\\juanc\\source\\repos\\PracticaEnCasa\\WindowsForms\\WindowsFormsApp2\\Envios.csv", FileMode.Open);
                Lector = new StreamReader(Archivo);
                string Header = Lector.ReadLine();
                string[] HeaderSplit = Header.Split(',');
                this.Column1.HeaderText = HeaderSplit[0];
                this.Column2.HeaderText = HeaderSplit[1];
                this.Column3.HeaderText = HeaderSplit[2];
                this.Column4.HeaderText = HeaderSplit[3];
                this.Column5.HeaderText = HeaderSplit[4];
                this.Column6.HeaderText = HeaderSplit[5];
                this.Column7.HeaderText = HeaderSplit[6];

                while (Lector.EndOfStream == false)
                {
                    string Valores = Lector.ReadLine();
                    string[] ValoresSplit = Valores.Split(',');

                    // Agregar una nueva fila al DataGridView
                    int indiceFila = this.dataGridView1.Rows.Add();

                    // Asignar los valores a las celdas de la nueva fila
                    for (int i = 0; i < ValoresSplit.Length; i++)
                    {
                        this.dataGridView1.Rows[indiceFila].Cells[i].Value = ValoresSplit[i];
                    }
                }
                Lector.Close();
                Archivo.Close();
            }
            else
            {

            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
