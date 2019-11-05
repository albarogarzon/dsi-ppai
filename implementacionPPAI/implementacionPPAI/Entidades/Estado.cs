using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace implementacionPPAI.Entidades
{
    class Estado
    {
        private string ambito;
        private string descripcion;
        private string nombre;

        public Estado(string ambito, string descripcion, string nombre)
        {
            this.Ambito = ambito;
            this.Descripcion = descripcion;
            this.Nombre = nombre;
        }

        public string Ambito { get => ambito; set => ambito = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string Nombre { get => nombre; set => nombre = value; }
    }
}
