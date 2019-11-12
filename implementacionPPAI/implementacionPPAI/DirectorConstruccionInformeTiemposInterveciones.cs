using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using implementacionPPAI.Presentacion;

namespace implementacionPPAI
{
    public class DirectorConstruccionInformeTiemposInterveciones
    {
        private IConstructorInformeTI constructor;

        public DirectorConstruccionInformeTiemposInterveciones(IConstructorInformeTI constructor){
           this.constructor = constructor;
        }

        public void construir(TimeSpan tiempoPromedio, List<List<string>> datosIntervenciones, DateTime fechaHoraDesdePeriodo, DateTime fechaHoraHastaPeriodo, List<string> nombresTipoSiniestro, List<string> nombresTipoGravedad, string tiempoAnalizar){
          
            constructor.construirProducto();
            constructor.construirEncabezado(tiempoPromedio,fechaHoraDesdePeriodo,fechaHoraHastaPeriodo,nombresTipoSiniestro,nombresTipoGravedad,tiempoAnalizar);
            constructor.construirDetalleIntervenciones(datosIntervenciones);
            
            constructor.obtenerProducto();
        }

    }
}
