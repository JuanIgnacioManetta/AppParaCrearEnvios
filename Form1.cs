using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Este metodo te lleva al form para agregar un envio.
        private Form3 formAgregar;
        private void agregarButton_Click(object sender, EventArgs e)
        {
            if(formAgregar == null || formAgregar.IsDisposed)
            {
                formAgregar = new Form3();
            }
            formAgregar.ShowDialog();
        }

        //Este metodo te lleva al form para listar los envios.
        private Form2 formListar;
        private void listarButton_Click(object sender, EventArgs e)
        {
            if (formListar == null || formListar.IsDisposed)
            {
                formListar = new Form2();
            }
            formListar.ShowDialog();
        }

        //Este metodo cierra la aplicacion.
        private void salirButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
