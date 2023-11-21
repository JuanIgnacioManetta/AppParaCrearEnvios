using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class Envios
    {
        private string _Avion;
        private string _Cliente;
        private string _CodPaquete;
        private float _Monto;
        private string _Origen;
        private string _Destino;
        private string _Contenido;

        public Envios()
        {
            this._Avion = string.Empty;
            this._Cliente = string.Empty;
            this._CodPaquete = string.Empty;
            this._Monto = 0;
            this._Origen = string.Empty;
            this._Destino = string.Empty;
            this._Contenido = string.Empty;
        }

        public Envios(string avion, string cliente, string codPaquete, float monto, string origen, string destino, string contenido)
        {
            _Avion = avion;
            _Cliente = cliente;
            _CodPaquete = codPaquete;
            _Monto = monto;
            _Origen = origen;
            _Destino = destino;
            _Contenido = contenido;
        }
        
        public string Avion
        {
            get { return this._Avion; }
            set { this._Avion = value; }
        }
        public string Cliente
        {
            get { return this._Cliente; }
            set { this._Cliente = value; }
        }
        public string CodPaquete
        {
            get { return this._CodPaquete; }
            set { this._CodPaquete = value; }
        }
        public float Monto
        {
            get { return this._Monto; }
            set { this._Monto = value; }
        }
        public string Origen
        {
            get { return this._Origen; }
            set { this._Origen = value; }
        }
        public string Destino
        {
            get { return this._Destino; }
            set { this._Destino = value; }
        }
        public string Contenido
        {
            get { return this._Contenido; }
            set { this._Contenido = value; }
        }
    }
}
