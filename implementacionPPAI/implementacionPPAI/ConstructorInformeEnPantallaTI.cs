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
            reporte.setDetalleIntervenciones(datosIntervenciones);
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
            throw new NotImplementedException();
        }
    }
}
