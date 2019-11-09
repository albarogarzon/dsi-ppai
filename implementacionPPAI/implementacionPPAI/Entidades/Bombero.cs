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
        private string dni;
        private string email;
        private string nombre;
        private string telefono;
        
        public Bombero(bool activo, string nombre, string apellido, string direccion, string dni, string email, string telefono){
            this.activo = activo;
            this.nombre = nombre;
            this.apellido = apellido;
            this.direccion = direccion;
            this.dni = dni;
            this.email = email;
            this.telefono = telefono;
        }
    
        public string getNombre(){
            return this.nombre;
        }

        public string getApellido(){
            return this.apellido;
        }
    }
}
