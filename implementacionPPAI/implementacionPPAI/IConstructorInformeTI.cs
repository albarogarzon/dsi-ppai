using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace implementacionPPAI
{
    interface IConstructorInformeTI
    {
        InformeTiemposIntervencion construirProducto();
        void construirDetalleIntervenciones(List<List<string>> datosIntervenciones);
        void construirEncabezado(TimeSpan tiempoPromedio, DateTime fechaHoraDesdePeriodo, DateTime fechaHoraHastaPeriodo, string nombreTipoSiniestro, string nombreTipoGravedad, string tiempoAnalizar);
        InformeTiemposIntervencion obtenerProducto();
    }
}
