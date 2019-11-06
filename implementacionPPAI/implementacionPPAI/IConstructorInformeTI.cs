using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace implementacionPPAI
{
    interface IConstructorInformeTI
    {
        public InformeTiemposIntervencion construirProducto();
        public void construirDetalleIntervenciones(List<List<string>> datosIntervenciones);
        public void construirEncabezado(TimeSpan tiempoPromedio, DateTime fechaHoraDesdePeriodo, DateTime fechaHoraHastaPeriodo, string nombreTipoSiniestro, string nombreTipoGravedad, string tiempoAnalizar);
        public InformeTiempoIntervencion obtenerProducto();
    }
}
