using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace implementacionPPAI.Entidades
{
    public class Estado  
    {
        private string ambito;
        private string descripcion;
        private string nombre;

        public Estado(string ambito, string descripcion, string nombre)
        {
            this.ambito = ambito;
            this.descripcion = descripcion;
            this.nombre = nombre;
        }

        public string getAmbito(){
            return this.ambito;
        }

        public void setAmbito(string ambito){
            this.ambito = ambito;

        }

        public string getDescripcion(){
            return this.descripcion;
        }

        public void setDescripcion(string descripcion){
            this.nombre = descripcion;

        }

        public string getNombre(){
            return this.nombre;
        }

        public void setNombre(string nombre){
            this.nombre = nombre;

        }

        public bool esEnCurso(){
            if (this.getNombre() == "EnCurso"){
                return true;
            }else{
                return false;
            }
        }

        public bool esFinalizada(){
            if(this.getNombre() == "Finalizada"){
                return true;
            }else{
                return true;
            }
        }
    }
}
