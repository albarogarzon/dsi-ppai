using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using implementacionPPAI.Presentacion;

namespace implementacionPPAI
{
    class ConstructorInformeEnPantallaTI : IConstructorInformeTI
    {
        private FrmSalidaReporte reporte;
        public void construirDetalleIntervenciones(List<List<string>> datosIntervenciones)
        {
            
            List<Dato> datos = new List<Dato>();
            string descripcion;
            string nombre;
            string apellido;
            string cantDotaciones;
            foreach(List<string> datoIntervencion in datosIntervenciones)
            {
                descripcion = datoIntervencion[0];
                nombre = datoIntervencion[1];
                apellido = datoIntervencion[2];
                cantDotaciones = datoIntervencion[3];
                datos.Add(new Dato(descripcion, nombre, apellido, cantDotaciones));
            }

                
            reporte.setDetalleIntervenciones(datos);

            reporte.inicializarReporte();
        }

        public void construirEncabezado(TimeSpan tiempoPromedio, DateTime fechaHoraDesdePeriodo, DateTime fechaHoraHastaPeriodo, List<string> nombreTipoSiniestro, List<string> nombreTipoGravedad, string tiempoAnalizar)
        {
            reporte.setEncabezado(tiempoPromedio, fechaHoraDesdePeriodo, fechaHoraHastaPeriodo, nombreTipoSiniestro, nombreTipoGravedad, tiempoAnalizar);
            
        }

        public FrmSalidaReporte construirProducto()
        {
            this.reporte = new FrmSalidaReporte();
             
            return reporte;
        }

        public FrmSalidaReporte obtenerProducto()
        {
            return reporte;
        }

       
    }
}
