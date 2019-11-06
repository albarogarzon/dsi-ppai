using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace implementacionPPAI.Entidades
{
    public class Bombero
    {
        private bool activo;
        private string apellido;
        private string direccion;
        private int dni;
        private string email;
        private string nombre;
        private int telefono;

    
        public string getNombre(){
            return this.nombre;
        }

        public string getApellido(){
            return this.apellido;
        }
    }
}
