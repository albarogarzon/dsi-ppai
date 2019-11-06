using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace implementacionPPAI
{
    public interface IConstructorInformeTI
    {
        InformeTiemposIntervencion construirProducto();
        void construirDetalleIntervenciones(List<List<string>> datosIntervenciones);
        void construirEncabezado(TimeSpan tiempoPromedio, DateTime fechaHoraDesdePeriodo, DateTime fechaHoraHastaPeriodo, List<string> nombreTipoSiniestro, List<string> nombreTipoGravedad, string tiempoAnalizar);
        InformeTiemposIntervencion obtenerProducto();
    }
}
