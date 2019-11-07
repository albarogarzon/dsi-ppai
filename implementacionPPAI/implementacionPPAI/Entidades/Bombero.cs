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

        public Bombero(bool activo, string apellido, string direccion, int dni, string email, string nombre, int telefono)
        {
            this.activo = activo;
            this.apellido = apellido;
            this.direccion = direccion;
            this.dni = dni;
            this.email = email;
            this.nombre = nombre;
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
