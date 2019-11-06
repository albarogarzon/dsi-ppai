using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace implementacionPPAI
{
    class ConstructorInformeEnPantallaTI : IConstructorInformeTI
    {
        public void construirDetalleIntervenciones(List<List<string>> datosIntervenciones)
        {
            throw new NotImplementedException();
        }

        public void construirEncabezado(TimeSpan tiempoPromedio, DateTime fechaHoraDesdePeriodo, DateTime fechaHoraHastaPeriodo, List<string> nombreTipoSiniestro, List<string> nombreTipoGravedad, string tiempoAnalizar)
        {
            throw new NotImplementedException();
        }

        public InformeTiemposIntervencion construirProducto()
        {
            throw new NotImplementedException();
        }

        public InformeTiemposIntervencion obtenerProducto()
        {
            throw new NotImplementedException();
        }
    }
}
