using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using implementacionPPAI.Presentacion;

namespace implementacionPPAI.Entidades
{
    public class GestorReporteTiempoIntervencion
    {
        private DateTime fechaHoraDesdePeriodo, fechaHoraHastaPeriodo;
        private List<string> seleccionTipoSiniestro, seleccionGravedad;
        private string seleccionTiempoAnalizar;
        private List<TimeSpan> duracionIntervenciones;
        private List<Intervencion> intervenciones, intervencionesFinalizadas, intervencionesFiltradasPorGravedadYSiniestro, intervencionesFiltradas;
        private List<List<string>> datosIntervenciones;
        private TimeSpan promedioDuracion;
        
        
       
        public GestorReporteTiempoIntervencion()
        {
          
            this.duracionIntervenciones = new List<TimeSpan>();
            this.intervencionesFinalizadas = new List<Intervencion>();
            this.intervencionesFiltradasPorGravedadYSiniestro = new List<Intervencion>();
            this.datosIntervenciones = new List<List<string>>();
            this.intervencionesFiltradas = new List<Intervencion>();
            this.seleccionGravedad = new List<string>();
            this.seleccionTipoSiniestro = new List<string>();
        }

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
       

        public void tomarSeleccionTiempoAnalizar(string seleccionTiempoAnalizar)
        {
            this.setSeleccionTiempoAnalizar(seleccionTiempoAnalizar);
        }

     


        public void tomarConfirmacionFiltros()
        {
            bool flag1;
            bool flag2;
            Creacion creador = new Creacion();
            intervenciones = creador.crear();
                
            this.buscarIntervencionesFinalizadas();
            
            flag1 = this.filtrarIntervencionesPorGravedadYSiniestro(); // Lanzar mensaje si no econtro
            if (!flag1)
            {
                MessageBox.Show("No se encontro intervencion con esa gravedad y siniestro", "Alerta");
            }
            else
            {
                MessageBox.Show("si se encontro intervencion con esa gravedad y siniestro", "Alerta");
            }
            flag2 = this.filtrarIntervencionesPorPeriodoSeleccionado();// Lanzar mensaje si no encontro
            if (!flag2)
            {
                MessageBox.Show("No se encontro intervencion en ese periodo", "Alerta");
            }
            else
            {
                MessageBox.Show("si se encontro intervencion en ese periodo", "Alerta");
            }
            this.obtenerDuracionIntervenciones();
            this.obtenerDatosIntervenciones();
            this.calcularPromedioDuracionIntervenciones();
            this.generarReporte();
        }


        public void buscarIntervencionesFinalizadas(){
            foreach(Intervencion intervencion in this.intervenciones){
                if (intervencion.esFinalizada() || intervencion.finalizo()){
                    this.intervencionesFinalizadas.Add(intervencion);
                }
            } 
        }

        public bool filtrarIntervencionesPorGravedadYSiniestro(){
            bool existen = false;
            foreach(Intervencion intervencion in this.intervencionesFinalizadas){
               if(seleccionTipoSiniestro.Contains(intervencion.getNombreTipoSiniestro()) && seleccionGravedad.Contains(intervencion.getNombreGravedad())){
                   this.intervencionesFiltradasPorGravedadYSiniestro.Add(intervencion);
                    existen = true;
               }
            }
            return existen;
        }
            
                    
                    

        public bool filtrarIntervencionesPorPeriodoSeleccionado()
        {
            bool existen = false;
            foreach (Intervencion intervencion in this.intervencionesFiltradasPorGravedadYSiniestro)
            {
                if (intervencion.finalizoEnElPeriodo(this.fechaHoraDesdePeriodo, this.fechaHoraHastaPeriodo))
                {
                    this.intervencionesFiltradas.Add(intervencion);
                    existen = true;
                }
            }
            return existen;
           
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

        public void generarReporte()
        {
            ConstructorInformeEnPantallaTI constructorInformePantalla = new ConstructorInformeEnPantallaTI();
            DirectorConstruccionInformeTiemposInterveciones directorConstruccionInforme = new DirectorConstruccionInformeTiemposInterveciones(constructorInformePantalla);
            directorConstruccionInforme.construir(this.promedioDuracion, this.datosIntervenciones, this.fechaHoraDesdePeriodo, this.fechaHoraHastaPeriodo, this.seleccionTipoSiniestro, this.seleccionGravedad, this.seleccionTiempoAnalizar);
            FrmSalidaReporte pantallaReporte = constructorInformePantalla.obtenerProducto();
            
            pantallaReporte.ShowDialog();
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
