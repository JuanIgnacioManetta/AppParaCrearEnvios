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
    public partial class Form3 : Form
    {
        Envios Envio = new Envios();
        public Form3()
        {
            InitializeComponent();
            listarModeloAvion();
            listarCuitClientes();

        }

        //Este metodo lista los modelos de aviones en el cuadro del form 3
        public void listarModeloAvion()
        {

            StreamReader Lector;
            FileStream Archivo;
            Envios envios = new Envios();

            if (File.Exists("C:\\Users\\juanc\\source\\repos\\PracticaEnCasa\\WindowsForms\\WindowsFormsApp2\\aviones.csv") != false)
            {
                Archivo = new FileStream("C:\\Users\\juanc\\source\\repos\\PracticaEnCasa\\WindowsForms\\WindowsFormsApp2\\aviones.csv", FileMode.Open);
                Lector = new StreamReader(Archivo);
                string Header = Lector.ReadLine();
                string[] HeaderSplit = Header.Split(',');
                this.Aviones.HeaderText = HeaderSplit[0];

                while (Lector.EndOfStream == false)
                {
                    string Valores = Lector.ReadLine();
                    string[] ValoresSplit = Valores.Split(',');

                    // Agregar una nueva fila al DataGridView
                    int indiceFila = this.ListaAviones.Rows.Add();

                    // Asignar los valores a las celdas de la nueva fila
                    this.ListaAviones.Rows[indiceFila].Cells[0].Value = ValoresSplit[0];
                }
                Lector.Close();
                Archivo.Close();
            }
            else
            {

            }
        }

        //Este metodo lista los clientes en el cuadro del form 3
        public void listarCuitClientes()
        {

            StreamReader Lector;
            FileStream Archivo;

            if (File.Exists("C:\\Users\\juanc\\source\\repos\\PracticaEnCasa\\WindowsForms\\WindowsFormsApp2\\clientes.csv") != false)
            {
                Archivo = new FileStream("C:\\Users\\juanc\\source\\repos\\PracticaEnCasa\\WindowsForms\\WindowsFormsApp2\\clientes.csv", FileMode.Open);
                Lector = new StreamReader(Archivo);
                string Header = Lector.ReadLine();
                string[] HeaderSplit = Header.Split(',');
                this.CuitClientes.HeaderText = HeaderSplit[0];

                while (Lector.EndOfStream == false)
                {
                    string Valores = Lector.ReadLine();
                    string[] ValoresSplit = Valores.Split(',');

                    // Agregar una nueva fila al DataGridView
                    int indiceFila = this.ListaClientes.Rows.Add();

                    // Asignar los valores a las celdas de la nueva fila
                    this.ListaClientes.Rows[indiceFila].Cells[0].Value = ValoresSplit[0];
                }
                Lector.Close();
                Archivo.Close();
            }
            else
            {

            }
        }

        //Este boton cierra el form 3
        private void salirButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Este metodo sirve para seleccionar a traves del de la lista
        private DataGridViewCell CeldaSeleccionada;
        private void ListaAviones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0 && e.ColumnIndex >= 0) 
            {
                CeldaSeleccionada = ListaAviones.Rows[e.RowIndex].Cells[e.ColumnIndex];
            }
            object valorCelda = CeldaSeleccionada.Value;
            this.labelAvionSeleccionado.Text = valorCelda.ToString();
            Envio.Avion = valorCelda.ToString();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                CeldaSeleccionada = ListaClientes.Rows[e.RowIndex].Cells[e.ColumnIndex];
            }
            object valorCelda = CeldaSeleccionada.Value;
            this.labelClienteSeleccionado.Text = valorCelda.ToString();
            Envio.Cliente = valorCelda.ToString();
        }

        //Este metodo te lleva a agregar un modelo de avion al archivo CSV.
        private Form4 formAgregarAvion;
        private void AgregarAvion_Click(object sender, EventArgs e)
        {
            if (formAgregarAvion == null || formAgregarAvion.IsDisposed)
            {
                formAgregarAvion = new Form4();
            }
            formAgregarAvion.ShowDialog();
        }

        //Este metodo te lleva a agregar un cliente al archivo CSV.
        private Form5 formAgregarCliente;
        private void AgregarCliente_Click(object sender, EventArgs e)
        {
            if(formAgregarCliente == null || formAgregarCliente.IsDisposed)
            {
                formAgregarCliente = new Form5();
            }
            formAgregarCliente.ShowDialog();
        }
    }
}
