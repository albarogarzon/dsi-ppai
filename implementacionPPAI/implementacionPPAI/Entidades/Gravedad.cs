using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace implementacionPPAI.Entidades
{
    class Gravedad
    {
        private string descripcion;
        private string nombre;

        public Gravedad(string descripcion, string nombre)
        {
            this.Descripcion = descripcion;
            this.Nombre = nombre;
        }

        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string Nombre { get => nombre; set => nombre = value; }
    }
}
