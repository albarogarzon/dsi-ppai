using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace implementacionPPAI.entidades
{
    public class TipoSiniestro
    {
        private string descripcion;
        private string nombre;

        public TipoSiniestro(string descripcion, string nombre)
        {
            this.Descripcion = descripcion;
            this.Nombre = nombre;
        }

        public void setDescripcion(string descripcion){
            this.descripcion = descripcion;
        }

        public void setNombre(string nombre){
            this.nombre = nombre;
        }

        public string getDescripcion(){
            return this.descripcion;
        }

        public string getNombre(){
            return this.nombre;
        }
    }
}
