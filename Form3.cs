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
        StreamReader Lector;
        FileStream Archivo;
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

        //Este metodo lista los clientes en el cuadro del form 3
        public void listarCuitClientes()
        {
            if (File.Exists("C:\\Users\\juanc\\source\\repos\\PracticaEnCasa\\WindowsForms\\AppParaCrearEnvios\\clientes.csv") != false)
            {
                Archivo = new FileStream("C:\\Users\\juanc\\source\\repos\\PracticaEnCasa\\WindowsForms\\AppParaCrearEnvios\\clientes.csv", FileMode.Open);
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
        private DataGridViewCell CeldaAvionSeleccionada;
        private void ListaAviones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0 && e.ColumnIndex >= 0) 
            {
                CeldaAvionSeleccionada = ListaAviones.Rows[e.RowIndex].Cells[e.ColumnIndex];
                this.ConfirmarAvion.Visible = true;
            }
            object valorCelda = CeldaAvionSeleccionada.Value;
            this.labelAvionSeleccionado.Text = valorCelda.ToString();
        }
        private DataGridViewCell CeldaClienteSeleccionada;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                CeldaClienteSeleccionada = ListaClientes.Rows[e.RowIndex].Cells[e.ColumnIndex];
                this.ConfirmarCliente.Visible = true;
            }
            object valorCelda = CeldaClienteSeleccionada.Value;
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

        //Confirma el avion seleccionado.
        private void ConfirmarAvion_Click(object sender, EventArgs e)
        {
            object valorCelda = CeldaAvionSeleccionada.Value;
            string valorCeldaString = valorCelda.ToString();
            if (valorCeldaString != string.Empty)
            {
                Envio.Avion = valorCeldaString;
                ListaAviones.Visible = false;
            }
        }

        //Confirma el cliente seleccionado.
        private void ConfirmarCliente_Click(object sender, EventArgs e)
        {
            object valorCelda = CeldaClienteSeleccionada.Value;
            string valorCeldaString = valorCelda.ToString();
            if (valorCeldaString != string.Empty)
            {
                Envio.Cliente = valorCeldaString;
                ListaClientes.Visible = false;
            }
        }

        //Confirma el codigo del Paquete
        private void buttonCodPaquete_Click(object sender, EventArgs e)
        {
            int numPaquete;
            string codPaquete = string.Empty;
            if (textBoxCodPaquete.Text != string.Empty)
            {    
                if(textBoxCodPaquete.Text.Length >= 0 && textBoxCodPaquete.Text.Length <= 3)
                {
                    if(int.TryParse(textBoxCodPaquete.Text, out numPaquete))
                    {
                        Archivo = new FileStream("C:\\Users\\juanc\\source\\repos\\PracticaEnCasa\\WindowsForms\\AppParaCrearEnvios\\Envios.csv", FileMode.Open);
                        Lector = new StreamReader(Archivo);
                        Lector.ReadLine();

                        bool codigoExistente = false;

                        while (Lector.EndOfStream == false)
                        {
                            string Valores = Lector.ReadLine();
                            string[] ValoresSplit = Valores.Split(',');
                            codPaquete = "PAQ" + numPaquete;
                            if (codPaquete == ValoresSplit[2])
                            {
                                codigoExistente = true;
                                errorProviderCodPaq.SetError(textBoxCodPaquete, "El codigo ingresado ya existe");
                                break;
                            }
                        }
                        Lector.Close();
                        Archivo.Close();
                        if (!codigoExistente)
                        {
                            Envio.CodPaquete = codPaquete;
                            errorProviderCodPaq.SetError(textBoxCodPaquete, string.Empty);
                            visibilizarConfirmacion();
                        }
                    }
                    else
                    {
                        errorProviderCodPaq.SetError(textBoxCodPaquete, "El codigo ingresado debe ser de 3 numeros");
                    }
                }
                else
                {
                    errorProviderCodPaq.SetError(textBoxCodPaquete, "El codigo ingresado debe ser de 3 numeros");
                }
            }
            else
            {
                errorProviderCodPaq.SetError(textBoxCodPaquete, "Rellene el campo");
            }
        }

        //Confirma el Monto del Paquete
        private void buttonMonto_Click(object sender, EventArgs e)
        {
            long monto = 0;
            if (long.TryParse(textBoxMonto.Text, out monto))
            {
                Envio.Monto = monto;
                errorProviderMonto.SetError(textBoxMonto, string.Empty);
                visibilizarConfirmacion();
            }
            else
            {
                errorProviderMonto.SetError(textBoxMonto, "Debes ingresar un numero(Sin Coma)");
            }
        }

        //Confirma el Origen del Paquete
        private void buttonOrigen_Click(object sender, EventArgs e)
        {
            int codigo;
            if (int.TryParse(textBoxOrigen.Text, out codigo))
            {
                errorProviderOrigen.SetError(textBoxOrigen, "El Codigo de Origen debe ser de 3 LETRAS");
            }
            else
            {

                if (textBoxOrigen.Text.Length == 3)
                {
                    Envio.Origen = textBoxOrigen.Text.ToUpper();
                    errorProviderOrigen.SetError(textBoxOrigen, string.Empty);
                    visibilizarConfirmacion();
                }
                else
                {
                    errorProviderOrigen.SetError(textBoxOrigen, "El Codigo de Origen ingresado no cumple con las caracteristica necesarias, el codigo debe ser de 3 Letras");
                }
            }
        }

        //Confirma el Destino del Paquete
        private void buttonDestino_Click(object sender, EventArgs e)
        {
            {
                int codigo;
                if (int.TryParse(textBoxDestino.Text, out codigo))
                {
                    errorProviderDestino.SetError(textBoxDestino, "El Codigo de Destino debe ser de 3 LETRAS");
                }
                else
                {

                    if (textBoxOrigen.Text.Length == 3)
                    {
                        Envio.Destino = textBoxDestino.Text.ToUpper();
                        errorProviderDestino.SetError(textBoxDestino, string.Empty);
                        visibilizarConfirmacion();
                    }
                    else
                    {
                        errorProviderDestino.SetError(textBoxDestino, "El Codigo de Destino ingresado no cumple con las caracteristica necesarias, el codigo debe ser de 3 Letras");
                    }
                }
            }
        }

        //Confirma la Descripcion del Paquete
        private void buttonDescripcion_Click(object sender, EventArgs e)
        {
            Envio.Contenido = textBoxDescripcion.Text;
            errorProviderDescripcion.SetError(textBoxDescripcion, string.Empty);
            visibilizarConfirmacion();
        }

        private void visibilizarConfirmacion()
        {
            // Verificar si todos los ErrorProviders están vacíos
            if (TodosErrorProvidersVacios())
            {
                // Mostrar el botón
                buttonConfirmarEnvio.Visible = true;
            }
            else
            {
                // Ocultar el botón si hay algún error
                buttonConfirmarEnvio.Visible = false;
            }
        }

        // Verificar si todos los ErrorProviders están vacíos
        private bool TodosErrorProvidersVacios()
        {
            return string.IsNullOrEmpty(errorProviderCodPaq.GetError(textBoxCodPaquete)) &&
                   string.IsNullOrEmpty(errorProviderMonto.GetError(textBoxMonto)) &&
                   string.IsNullOrEmpty(errorProviderOrigen.GetError(textBoxOrigen)) &&
                   string.IsNullOrEmpty(errorProviderDestino.GetError(textBoxDestino)) &&
                   string.IsNullOrEmpty(errorProviderDescripcion.GetError(textBoxDescripcion));
        }

        //Boton para confirmar el envio.
        private void buttonConfirmarEnvio_Click(object sender, EventArgs e)
        {
            StreamWriter Escritor;
            FileStream Archivo;
            Archivo = new FileStream("C:\\Users\\juanc\\source\\repos\\PracticaEnCasa\\WindowsForms\\AppParaCrearEnvios\\Envios.csv", FileMode.Append);
            Escritor = new StreamWriter(Archivo);
            Escritor.WriteLine($"{Envio.Avion},{Envio.Cliente},{Envio.CodPaquete},{Envio.Monto},{Envio.Origen},{Envio.Destino},{Envio.Contenido}");
            Escritor.Close();
            Archivo.Close();
            this.Close();
        }

    }
}
