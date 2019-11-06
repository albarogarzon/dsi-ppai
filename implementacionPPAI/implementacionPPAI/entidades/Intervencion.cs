using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace implementacionPPAI.entidades
{
    public class Intervencion
    {
        private string domicilioReportado;
        private string nombreApellidoInformante;
        private string resumenSiniestroInformante;
        private string resumenTrabajoEfectuado;
        private int telefonoConectado;
        private Estado estadoActual;
        List<HistorialIntervencion> historiales;
        private Gravedad gravedad;
        private TipoSiniestro tipoSiniestro;
        private Bombero encargado;
        private List<Dotacion> dotaciones;

        public Intervencion(string domicilioReportado, string nombreApellidoInformante, string resumenSiniestroInformante, string resumenTrabajoEfectuado, int telefonoConectado, Estado estadoActual, List<HistorialIntervencion> historial, Gravedad gravedad, TipoSiniestro tipoSiniestro, Bombero encargado)
        {
            this.domicilioReportado = domicilioReportado;
            this.nombreApellidoInformante = nombreApellidoInformante;
            this.resumenSiniestroInformante = resumenSiniestroInformante;
            this.resumenTrabajoEfectuado = resumenTrabajoEfectuado;
            this.telefonoConectado = telefonoConectado;
            this.estadoActual = estadoActual;
            this.historiales = historial;
            this.gravedad = gravedad;
            this.tipoSiniestro = tipoSiniestro;
            this.encargado = encargado;
           
        }

        public string DomicilioReportado { get => domicilioReportado; set => domicilioReportado = value; }
        public string NombreApellidoInformante { get => nombreApellidoInformante; set => nombreApellidoInformante = value; }
        public string ResumenSiniestroInformante { get => resumenSiniestroInformante; set => resumenSiniestroInformante = value; }
        public string ResumenTrabajoEfectuado { get => resumenTrabajoEfectuado; set => resumenTrabajoEfectuado = value; }
        public int TelefonoConectado { get => telefonoConectado; set => telefonoConectado = value; }
        public Bombero Encargado { get => encargado; set => encargado = value; }
        internal Estado EstadoActual { get => estadoActual; set => estadoActual = value; }
        internal List<HistorialIntervencion> Historial { get => historial; set => historial = value; }
        internal Gravedad Gravedad { get => gravedad; set => gravedad = value; }
        internal TipoSiniestro TipoSiniestro { get => tipoSiniestro; set => tipoSiniestro = value; }
        
        public TimeSpan calcularDuracion(){
            TimeSpan duracion;
            for(int i = 0; i< historial.Count(); i++){
                if(historiales[i].esEnCurso()){
                    DateTime fechaHoraDesde = historiales[i].getFechaHoraDesde();
                    DateTime fechaHoraHasta = historiales[i].getFechaHoraHasta();
                    duracion = fechaHoraHasta.Subtract(fechaHoraDesde);
                }
            }
            return duracion;
        }

        public bool esFinalizada(){
            if(this.estadoActual.esFinalizada()){
                return true;
            }else{
                return false;
            }
        }

        public bool esDelPeriodo(DateTime fechaInicioPeriodo, DateTime fechaFinPeriodo)
        {
            DateTime fechaFinIntervencion = historiales.Last().getFechaHoraHasta();
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
