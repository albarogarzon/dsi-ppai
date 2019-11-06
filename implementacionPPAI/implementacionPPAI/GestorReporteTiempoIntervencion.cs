using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace implementacionPPAI
{
    class GestorReporteTiempoIntervencion
    {
        private DateTime fechaHoraDesdePeriodo, fechaHoraHastaPeriodo, promedioDuracion;
        private string seleccionTipoSiniestro, seleccionGravedad, seleccionTiempoAnalizar;
        private List<TimeSpan> duracionIntervenciones;
        private List<entidades.Intervencion> intervencionesFiltradas;
        

        public void tomarSeleccionPeriodo(DateTime fechaHoraDesde, DateTime fechaHoraHasta){
            this.setFechaHoraDesdePeriodo(fechaHoraDesde);
            this.setFechaHoraHastaPeriodo(fechaHoraHasta);
        }

        public void tomarSeleccionTipoSiniestro(string tipoSiniestro){
            this.seleccionTipoSiniestro(tipoSiniestro);
        }
        
        public void tomarSeleccionGravedad(string gravedad){
            this.setSeleccionGravedad(gravedad);
        }

        public void tomarSeleccionTiempoAnalizar(string timepoAnalizar){
            this.setSeleccionTiempoAnalizar(tiempoAnalizar);
        }


        public void setFechaHoraDesdePeriodo(DateTime fechaHoraDesde){
            this.fechaHoraDesdePeriodo = fechaHoraDesde;
        }

        public void buscarIntervencionesFinalizadas(){
            //TODO
        }
        public void filtrarIntervenciones(){
            //TODO
        }
        
        public void calcularDuracionIntervencion(){
           foreach(entidades.Intervencion intervencion in intervencionesFiltradas){
                duracionIntervenciones.Add(intervencion.calcularDuracion());
            }
        }

        public void setFechaHoraHastaPeriodo(DateTime fechaHoraHasta){
            this.fechaHoraHastaPeriodo = fechaHoraHasta;
        }
        public void setSeleccionTipoSiniestro(string tipoSiniestro){
            this.seleccionTipoSiniestro = tipoSiniestro;
        }
        public void setSeleccionGravedad(string gravedad){
            this.seleccionGravedad = gravedad;
        }
        public void setSeleccionTiempoAnalizar(string tiempoAnalizar){
            this.seleccionTiempoAnalizar = tiempoAnalizar;
        }
    }
      
        


}
