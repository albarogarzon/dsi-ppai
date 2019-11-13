using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace implementacionPPAI.Entidades
{
    public class Intervencion
    {
        private string domicilioReportado;
        private string nombreApellidoInformante;
        private string resumenSiniestroInformante;
        private string resumenTrabajoEfectuado;
        private string telefonoContacto;
        private Estado estadoActual;
        List<HistorialIntervencion> historiales;
        private Gravedad gravedad;
        private TipoSiniestro tipoSiniestro;
        private Bombero encargado;
        private List<Dotacion> dotaciones;

        public Intervencion(string domicilioReportado, string nombreApellidoInformante, string resumenSiniestroInformante, string resumenTrabajoEfectuado, string telefonoContacto, Estado estadoActual, List<HistorialIntervencion> historial, Gravedad gravedad, TipoSiniestro tipoSiniestro, Bombero encargado, List<Dotacion> dotaciones)
        {
            this.domicilioReportado = domicilioReportado;
            this.nombreApellidoInformante = nombreApellidoInformante;
            this.resumenSiniestroInformante = resumenSiniestroInformante;
            this.resumenTrabajoEfectuado = resumenTrabajoEfectuado;
            this.telefonoContacto = telefonoContacto;
            this.estadoActual = estadoActual;
            this.historiales = historial;
            this.gravedad = gravedad;
            this.tipoSiniestro = tipoSiniestro;
            this.encargado = encargado;
            this.dotaciones = dotaciones;
           
        }

       
        public TimeSpan calcularDuracion(){
            TimeSpan duracion = new TimeSpan();
            DateTime fechaHoraDesde = new DateTime();
            DateTime fechaHoraHasta = new DateTime();
            for(int i = 0; i< historiales.Count(); i++){
                if(historiales[i].esEnCurso()){
                    fechaHoraDesde = historiales[i].getFechaHoraDesde();
                    fechaHoraHasta = historiales[i].getFechaHoraHasta();
                }
            }
                    
            duracion = fechaHoraHasta.Subtract(fechaHoraDesde);
            MessageBox.Show(Convert.ToString(duracion));

            return duracion;
        }

        public bool esFinalizada(){
            if(this.estadoActual.esFinalizada()){
                return true;
            }else{
                return false;
            }
        }

        public bool finalizo()
        {
           
            foreach(HistorialIntervencion historial in historiales)
            {
                if (historial.esFinalizada())
                {
                    return true;
                }
            }
            return false;
        }

        public bool finalizoEnElPeriodo(DateTime fechaInicioPeriodo, DateTime fechaFinPeriodo)
        {
            DateTime fechaFinIntervencion = new DateTime();
            foreach(HistorialIntervencion historial in this.historiales){
                if(historial.esFinalizada()){
                    fechaFinIntervencion = historial.getFechaHoraDesde();
                    break;
                }
            }
            
            if((fechaFinIntervencion >= fechaInicioPeriodo) && (fechaFinIntervencion <= fechaFinPeriodo)){
                return true;
            }else{
                return false;
            }
            
        }

        
        public List<string> obtenerDatos(){
            List<string> datos = new List<string>();
            string resumenTrabajo = this.getResumenTrabajoEfectuado();
            string nombreEncargado = this.encargado.getNombre();
            string apellidoEncargado = this.encargado.getApellido();
            string cantidadDeDotaciones = this.contarDotaciones().ToString();

            //Orden de los datos por fila
            datos.Add(resumenTrabajo);
            datos.Add(nombreEncargado);
            datos.Add(apellidoEncargado);
            datos.Add(cantidadDeDotaciones);

            return datos;
        }

        public string getNombreTipoSiniestro(){
            return tipoSiniestro.getNombre();
        }

        public string getNombreGravedad(){
            return this.gravedad.getNombre();
        }

        public string getResumenTrabajoEfectuado(){
            return this.resumenTrabajoEfectuado;
        }

        public int contarDotaciones(){
            return dotaciones.Count();
        }
            
    }
}
