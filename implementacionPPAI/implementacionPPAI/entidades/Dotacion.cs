using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace implementacionPPAI.Entidades
{
    
    public class Dotacion
    {
        private DateTime fechaHoraLlegada;
        private DateTime fechaHoraSalida;
        private int kmUnidadAlSalir;
        private int kmUnidadAlVolver;

        public Dotacion(DateTime fechaHoraLlegada, DateTime fechaHoraSalida, int kmUnidadAlSalir, int kmUnidadAlVolver)
        {
            this.fechaHoraLlegada = fechaHoraLlegada;
            this.fechaHoraSalida = fechaHoraSalida;
            this.kmUnidadAlSalir = kmUnidadAlSalir;
            this.kmUnidadAlVolver = kmUnidadAlVolver;
        }
    }
}
