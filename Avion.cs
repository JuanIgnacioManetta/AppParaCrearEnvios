using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class Avion
    {
        private string _Nombre;
        private int _CapacidadMax;
        private double _ValorXMilla;

        public Avion()
        {
            this._Nombre = string.Empty;
            this._CapacidadMax = 0;
            this._ValorXMilla = 0;
        }
        public Avion(string nombre, int capacidadMax, double valorXMilla)
        {
            _Nombre = nombre;
            _CapacidadMax = capacidadMax;
            _ValorXMilla = valorXMilla;
        }
        public string Nombre
        {
            get { return _Nombre; }
            set { this._Nombre = value; }
        }
        public int CapacidadMax
        {
            get { return _CapacidadMax; }
            set { this._CapacidadMax = value; }
        }
        public double ValorXMilla
        {
            get { return _ValorXMilla; }
            set { this._ValorXMilla = value; }
        }
    }
}
