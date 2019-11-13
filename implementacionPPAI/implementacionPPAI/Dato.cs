using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace implementacionPPAI
{
    public class Dato
    {
        private string descripcion;
        private string nombre;
        private string apellido;
        private string cantidadDeDotaciones;


        public Dato(string descripcion, string nombre, string apellido, string cantDotaciones)
        {
            this.descripcion = descripcion;
            this.nombre = nombre;
            this.apellido = apellido;
            this.cantidadDeDotaciones = cantDotaciones;
        }

        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Cantidad_De_Dotaciones { get => cantidadDeDotaciones; set => cantidadDeDotaciones = value; }

       
    }
}
