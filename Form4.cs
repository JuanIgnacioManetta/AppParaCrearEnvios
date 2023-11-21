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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp2
{
    public partial class Form4 : Form
    {
        Avion Avion = new Avion();

        public Form4()
        {
            InitializeComponent();
        }

        //Esta parte del codigo verifica si el nombre de avion ingresado ya existe, sino lo guarda en el objeto.
        private void buttonNombre_Click(object sender, EventArgs e)
        {
            string nombreAvion = this.textBoxNombre.Text;

            if (NombreAvionExiste(nombreAvion))
            {
                // Muestra un error con el ErrorProvider
                errorProviderNombre.SetError(this.textBoxNombre, "El nombre del avión ya existe.");
            }
            else
            {
                // Borra el error si no hay problema
                errorProviderNombre.SetError(this.textBoxNombre, string.Empty);
                Avion.Nombre = nombreAvion;
                visibilizarConfirmacion();
            }
        }
        private bool NombreAvionExiste(string nombreAvion)
        {
            StreamReader Lector;
            FileStream Archivo;
            if (File.Exists("C:\\Users\\juanc\\source\\repos\\PracticaEnCasa\\WindowsForms\\WindowsFormsApp2\\aviones.csv") != false)
            {
                Archivo = new FileStream("C:\\Users\\juanc\\source\\repos\\PracticaEnCasa\\WindowsForms\\WindowsFormsApp2\\aviones.csv", FileMode.Open);
                Lector = new StreamReader(Archivo);
                string Header = Lector.ReadLine();
                string[] HeaderSplit = Header.Split(',');

                while (Lector.EndOfStream == false)
                {
                    string Valores = Lector.ReadLine();
                    string[] ValoresSplit = Valores.Split(',');

                    // Comparar ignorando mayúsculas y minúsculas
                    if (string.Equals(ValoresSplit[0], nombreAvion, StringComparison.OrdinalIgnoreCase))
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
        private void buttonCapacidadMax_Click(object sender, EventArgs e)
        {
            string capacidadMax = this.textBoxCapacidad.Text;
            int capacidadConvertida;

            if (int.TryParse(capacidadMax, out capacidadConvertida))
            {
                // Borra el error si no hay problema
                errorProviderCapacidad.SetError(this.textBoxCapacidad, string.Empty);
                Avion.CapacidadMax = capacidadConvertida;
                visibilizarConfirmacion();
            }
            else
            {
                // Muestra un error con el ErrorProvider
                errorProviderCapacidad.SetError(this.textBoxCapacidad,
                    "La capacidad ingresada es inválida. Verifique que lo ingresado sea un número y no tenga coma.");
            }
            /* Esta parte del codigo funciona pero es mejor la de arriba
            try
            {
                int.Parse(capacidadMax);
                // Borra el error si no hay problema
                errorProvider1.SetError(this.textBoxCapacidad, string.Empty);
                Avion.CapacidadMax = int.Parse(capacidadMax);
            }
            catch
            {
                // Muestra un error con el ErrorProvider
                errorProvider1.SetError(this.textBoxCapacidad, 
                    "La capacidad ingresada es invalida. Verifique que lo ingresado sea un numero o que no tenga coma.");
            }*/
        }

        //Esta parte del codigo verifica lo ingresado en el valor por milla del avion.
        private void buttonValorXMilla_Click(object sender, EventArgs e)
        {
            string valorXMilla = this.textBoxValorXMilla.Text;
            double valorConvertido;
            if(double.TryParse(valorXMilla,out valorConvertido))
            {
                // Borra el error si no hay problema
                errorProviderValor.SetError(this.textBoxValorXMilla, string.Empty);
                Avion.ValorXMilla = valorConvertido;
                visibilizarConfirmacion();
            }
            else
            {
                // Muestra un error con el ErrorProvider
                errorProviderValor.SetError(this.textBoxValorXMilla, "La capacidad ingresada es inválida. Verifique que lo ingresado sea un número.");
            }
            /* Esta parte del codigo funciona pero es mejor la de arriba
            try
            {
                double valorXMillaParseado = double.TryParse(valorXMilla);
                // Borra el error si no hay problema
                errorProvider1.SetError(this.textBoxValorXMilla, string.Empty);
                Avion.ValorXMilla = valorXMillaParseado;
            }
            catch
            {
                // Muestra un error con el ErrorProvider
                errorProvider1.SetError(this.textBoxValorXMilla, "La capacidad ingresada es invalida. Verifique que lo ingresado sea un numero.");
            }*/
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
            return string.IsNullOrEmpty(errorProviderNombre.GetError(textBoxNombre)) &&
                   string.IsNullOrEmpty(errorProviderCapacidad.GetError(textBoxCapacidad)) &&
                   string.IsNullOrEmpty(errorProviderValor.GetError(textBoxValorXMilla));
        }
        //Este metodo cierra el form de agregar avion.
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonConfirmacionFinal_Click(object sender, EventArgs e)
        {
            if (TodosErrorProvidersVacios())
            {
                StreamWriter Escritor;
                FileStream Archivo;
                Archivo = new FileStream("C:\\Users\\juanc\\source\\repos\\PracticaEnCasa\\WindowsForms\\WindowsFormsApp2\\aviones.csv", FileMode.Append);
                Escritor = new StreamWriter(Archivo);
                Escritor.WriteLine($"{Avion.Nombre},{Avion.CapacidadMax},{Avion.ValorXMilla}");
                Escritor.Close();
                Archivo.Close();
                this.Close();
            }
        }
    }
}
