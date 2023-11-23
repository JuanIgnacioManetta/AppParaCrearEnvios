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

    public partial class Form5 : Form
    {
        Clientes Cliente = new Clientes();

        public Form5()
        {
            InitializeComponent();
        }

        //Esta parte del codigo verifica si el nombre de avion ingresado ya existe, sino lo guarda en el objeto.
        private void buttonCuit_Click(object sender, EventArgs e)
        {
            string cuitCliente = this.textBoxCuit.Text;
            long cuitConvertido;
            if (long.TryParse(cuitCliente, out cuitConvertido))
            {
                // Borra el error si no hay problema
                errorProviderCuit.SetError(this.textBoxCuit, string.Empty);
                visibilizarConfirmacion();
            }
            else
            {
                // Muestra un error con el ErrorProvider
                errorProviderCuit.SetError(this.textBoxCuit,
                    "La capacidad ingresada es inválida. Verifique que lo ingresado sea un número y no tenga coma.");
            }
            if (clienteExiste(cuitCliente))
            {
                // Muestra un error con el ErrorProvider
                errorProviderCuit.SetError(this.textBoxCuit, "El nombre del avión ya existe.");
            }
            else
            {
                // Borra el error si no hay problema
                errorProviderCuit.SetError(this.textBoxCuit, string.Empty);
                Cliente.CUIT = cuitCliente;
                visibilizarConfirmacion();
            }
        }
        private bool clienteExiste(string cuitCliente)
        {
            StreamReader Lector;
            FileStream Archivo;
            if (File.Exists("C:\\Users\\juanc\\source\\repos\\PracticaEnCasa\\WindowsForms\\AppParaCrearEnvios\\clientes.csv") != false)
            {
                Archivo = new FileStream("C:\\Users\\juanc\\source\\repos\\PracticaEnCasa\\WindowsForms\\AppParaCrearEnvios\\clientes.csv", FileMode.Open);
                Lector = new StreamReader(Archivo);
                string Header = Lector.ReadLine();
                string[] HeaderSplit = Header.Split(',');

                while (Lector.EndOfStream == false)
                {
                    string Valores = Lector.ReadLine();
                    string[] ValoresSplit = Valores.Split(',');

                    // Comparar ignorando mayúsculas y minúsculas
                    if (string.Equals(ValoresSplit[0], cuitCliente, StringComparison.OrdinalIgnoreCase))
                    {
                        Lector.Close();
                        Archivo.Close();
                        return true;
                    }
                }
                Lector.Close();
                Archivo.Close();
            }
            return false;
        }

        //Esta parte del codigo verifica lo ingresado en la capacidad maxima del avion.
        private void buttonRazonSocial_Click(object sender, EventArgs e)
        {
            Cliente.RazonSocial = this.textBoxRazonSocial.Text;
            errorProviderRazonSocial.SetError(this.textBoxRazonSocial, string.Empty);
            visibilizarConfirmacion();
        }

        //Esta parte del codigo verifica lo ingresado en el valor por milla del avion.
        private void buttonCiudad_Click(object sender, EventArgs e)
        {
            Cliente.Ciudad = this.textBoxCiudad.Text;
            errorProviderCiudad.SetError(this.textBoxCiudad, string.Empty);
            visibilizarConfirmacion();
        }

        private void visibilizarConfirmacion()
        {
            // Verificar si todos los ErrorProviders están vacíos
            if (TodosErrorProvidersVacios())
            {
                // Mostrar el botón
                buttonConfirmacionFinal.BackColor = Color.White;
            }
            else
            {
                // Ocultar el botón si hay algún error
                buttonConfirmacionFinal.BackColor = Color.Black;
            }
        }

        // Verificar si todos los ErrorProviders están vacíos
        private bool TodosErrorProvidersVacios()
        {
            return string.IsNullOrEmpty(errorProviderCuit.GetError(textBoxCuit)) &&
                   string.IsNullOrEmpty(errorProviderRazonSocial.GetError(textBoxRazonSocial)) &&
                   string.IsNullOrEmpty(errorProviderCiudad.GetError(textBoxCiudad));
        }

        //Guarda la informacion en el archivo CSV
        private void buttonConfirmacionFinal_Click_1(object sender, EventArgs e)
        {
            if (TodosErrorProvidersVacios())
            {
                StreamWriter Escritor;
                FileStream Archivo;
                Archivo = new FileStream("C:\\Users\\juanc\\source\\repos\\PracticaEnCasa\\WindowsForms\\AppParaCrearEnvios\\clientes.csv", FileMode.Append);
                Escritor = new StreamWriter(Archivo);
                Escritor.WriteLine($"{Cliente.CUIT},{Cliente.RazonSocial},{Cliente.Ciudad}");
                Escritor.Close();
                Archivo.Close();
                this.Close();
            }
        }

        //Este metodo cierra el form de agregar avion.
        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
