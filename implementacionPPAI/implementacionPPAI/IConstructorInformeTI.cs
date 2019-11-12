using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using implementacionPPAI.Presentacion;


namespace implementacionPPAI
{
    public interface IConstructorInformeTI
    {
        FrmSalidaReporte construirProducto();
        void construirDetalleIntervenciones(List<List<string>> datosIntervenciones);
        void construirEncabezado(TimeSpan tiempoPromedio, DateTime fechaHoraDesdePeriodo, DateTime fechaHoraHastaPeriodo, List<string> nombreTipoSiniestro, List<string> nombreTipoGravedad, string tiempoAnalizar);
        FrmSalidaReporte obtenerProducto();
    }
}
