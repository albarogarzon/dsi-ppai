using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace implementacionPPAI.Entidades
{
    class HistorialIntervencion
    {
        private DateTime fechaHoraDesde;
        private Estado estado;

        public HistorialIntervencion(DateTime fechaHoraDesde)
        {
            this.FechaHoraDesde = fechaHoraDesde;
        }

        public DateTime FechaHoraDesde { get => fechaHoraDesde; set => fechaHoraDesde = value; }
        internal Estado Estado { get => estado; set => estado = value; }
    }
}
