﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace implementacionPPAI.Entidades
{
    public class GestorReporteTiempoIntervencion
    {
        private DateTime fechaHoraDesdePeriodo, fechaHoraHastaPeriodo;
        private List<string> seleccionTipoSiniestro, seleccionGravedad;
        private string seleccionTiempoAnalizar;
        private List<TimeSpan> duracionIntervenciones;
        private List<Intervencion> intervenciones, intervencionesFinalizadas, intervencionesFiltradas;
        private List<List<string>> datosIntervenciones;
        private TimeSpan promedioDuracion;
       

        public void tomarSeleccionPeriodo(DateTime fechaHoraDesde, DateTime fechaHoraHasta){
            this.setFechaHoraDesdePeriodo(fechaHoraDesde);
            this.setFechaHoraHastaPeriodo(fechaHoraHasta);
        }

        public void tomarSeleccionTipoSiniestro(List<string> listaTiposSiniestro){
            foreach(string tipoSiniestro in listaTiposSiniestro){
                this.setSeleccionTipoSiniestro(tipoSiniestro);
            }
        }
        
        public void tomarSeleccionGravedad(List<string> listaGravedad){
            foreach(string gravedad in listaGravedad){
                this.setSeleccionGravedad(gravedad);
            }
        }
       

        public void tomarSeleccionTiempoAnalizar(string timepoAnalizar){
            this.setSeleccionTiempoAnalizar(seleccionTiempoAnalizar);
        }

        public void tomarConfirmacionFiltros()
        {
            Creacion creador = new Creacion();
            intervenciones = creador.crear();
                
            this.buscarIntervencionesFinalizadas();
            this.filtrarIntervenciones();
            this.obtenerDuracionIntervenciones();
            this.obtenerDatosIntervenciones();
            this.calcularPromedioDuracionIntervenciones();
        }


        public void buscarIntervencionesFinalizadas(){
            foreach(Intervencion intervencion in this.intervenciones){
                if (intervencion.esFinalizada()){
                    this.intervencionesFinalizadas.Add(intervencion);
                }
            } 
        }

        public void filtrarIntervenciones(){
            foreach(Intervencion intervencion in this.intervencionesFinalizadas){
               if(seleccionTipoSiniestro.Contains(intervencion.getNombreTipoSiniestro()) && seleccionGravedad.Contains(intervencion.getNombreGravedad())){
                    if(intervencion.esDelPeriodo(this.fechaHoraDesdePeriodo, this.fechaHoraHastaPeriodo)){
                        this.intervencionesFiltradas.Add(intervencion);
                    }
                }
            }
        }
                                    
        public void obtenerDuracionIntervenciones(){
           foreach(Intervencion intervencion in this.intervencionesFiltradas){
                duracionIntervenciones.Add(intervencion.calcularDuracion());
           }
        }

        public void obtenerDatosIntervenciones(){
            foreach(Intervencion intervencion in this.intervencionesFiltradas){
                datosIntervenciones.Add(intervencion.obtenerDatos());
            }
        }

        public void calcularPromedioDuracionIntervenciones(){
            this.promedioDuracion = new TimeSpan(Convert.ToInt64(this.duracionIntervenciones.Average(t => t.Ticks)));

        }

            


        public void setFechaHoraDesdePeriodo(DateTime fechaHoraDesde){
            this.fechaHoraDesdePeriodo = fechaHoraDesde;
        }

        public void setFechaHoraHastaPeriodo(DateTime fechaHoraHasta){
            this.fechaHoraHastaPeriodo = fechaHoraHasta;
        }
        public void setSeleccionTipoSiniestro(string tiposSiniestro){
            this.seleccionTipoSiniestro.Add(tiposSiniestro);
        }
            
        public void setSeleccionGravedad(string gravedad){
            this.seleccionGravedad.Add(gravedad);
        }
        public void setSeleccionTiempoAnalizar(string tiempoAnalizar){
            this.seleccionTiempoAnalizar = tiempoAnalizar;
        }
    }
      
        


}
