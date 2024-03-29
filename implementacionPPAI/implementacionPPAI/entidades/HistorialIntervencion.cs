﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace implementacionPPAI.Entidades
{
    public class HistorialIntervencion
    {
        private DateTime fechaHoraDesde;
        private DateTime fechaHoraHasta;
        private Estado estado;

        public HistorialIntervencion(DateTime fechaHoraDesde, DateTime fechaHoraHasta, Estado estado)
        {
            this.fechaHoraDesde = fechaHoraDesde;
            this.fechaHoraHasta = fechaHoraHasta;
            this.estado = estado;
        }


        public DateTime getFechaHoraDesde(){
            return this.fechaHoraDesde;
        }

        public void setFechaHoraDesde(DateTime fechaHoraDesde){
            this.fechaHoraDesde = fechaHoraDesde;
        }

        
        public DateTime getFechaHoraHasta(){
            return this.fechaHoraHasta;
        }

        public void setFechaHoraHasta(DateTime fechaHoraHasta){
            this.fechaHoraHasta = fechaHoraHasta;
        }
        
        public bool esEnCurso(){
            return this.estado.esEnCurso();
        }

        public bool esFinalizada(){
            return this.estado.esFinalizada();
        }
    }

}
