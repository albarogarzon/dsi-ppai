using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace implementacionPPAI
{
    public class DirectorConstruccionInformeTiemposInterveciones
    {
        private IConstructorInformeTI constructor;

        public DirectorConstruccionInformeTiemposInterveciones(IConstructorInformeTI constructor){
           this.constructor = constructor;
        }

        public void construir(TimeSpan tiempoPromedio, List<List<string>> datosIntervenciones, DateTime fechaHoraDesdePeriodo, DateTime fechaHoraHastaPeriodo, string nombreTipoSiniestro, string nombreTipoGravedad, string tiempoAnalizar){
            //TODO
        }

    }
}
