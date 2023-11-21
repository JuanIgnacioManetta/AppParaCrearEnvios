using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class Clientes
    {
        private string _CUIT;
        private string _Razon_Social;
        private string _Ciudad;

        public Clientes()
        {
            this._CUIT = string.Empty;
            this._Razon_Social = string.Empty;
            this._Ciudad = string.Empty;
        }
        public Clientes(string cUIT, string razon_Social, string ciudad)
        {
            _CUIT = cUIT;
            _Razon_Social = razon_Social;
            _Ciudad = ciudad;
        }
        public string CUIT
        {
            get { return _CUIT; }
            set { this._CUIT = value; }
        }
        public string RazonSocial
        {
            get { return _Razon_Social; }
            set { this._Razon_Social = value; }
        }
        public string Ciudad
        {
            get { return _Ciudad; }
            set { this._Ciudad = value; }
        }
    }
}
