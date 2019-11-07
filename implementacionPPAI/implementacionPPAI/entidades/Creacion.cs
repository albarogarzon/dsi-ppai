using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace implementacionPPAI.Entidades
{
    public class Creacion
    {
        // DEBE CREAR LOS DATOS TRUCHOS Y DEVOLVER UNA LISTA DE TODAS LAS INTERVENCIONES CREADAS

        public List<Intervencion> crear()
        {

            Bombero bomb1 = new Bombero(true,"Marquez","Valparaiso 180",40941425,"dario@gmail.com","Dario",4763012);
            Estado est = new Estado("Intervecion", "desc", "nombre");
            DateTime fechaHoraDesde = new DateTime(2018,10,10, 11,11,00);
            DateTime fechaHoraHasta = new DateTime(2018, 10, 10, 12, 15, 00);
            HistorialIntervencion historialIntervencion1 = new HistorialIntervencion(fechaHoraDesde, fechaHoraHasta,est);
            HistorialIntervencion historialIntervencion2 = new HistorialIntervencion(fechaHoraDesde, fechaHoraHasta, est);

            Dotacion dot1 = new Dotacion(fechaHoraHasta, fechaHoraDesde,1000,1030);
            Dotacion dot2 = new Dotacion(fechaHoraHasta, fechaHoraDesde, 2000, 2100);

            List<Dotacion> dotacions = new List<Dotacion>();
            dotacions.Add(dot1);
            dotacions.Add(dot2); 

            Gravedad grav = new Gravedad("Alta Desc","Alta");
            TipoSiniestro tipoSin = new TipoSiniestro("Accidente Desc","Accidente");

            List<HistorialIntervencion> historials = new List<HistorialIntervencion>();
            historials.Add(historialIntervencion1);
            historials.Add(historialIntervencion2);

            string domicilioReportado="Cayol 3900";
         string nombreApellidoInformante ="Albaro Garzon";
         string resumenSiniestroInformante="Resumen del siniestro";
         string resumenTrabajoEfectuado="Resumen trabajo";
         int telefonoConectado=4770000;

            Intervencion interv1 = new Intervencion(domicilioReportado,nombreApellidoInformante,resumenSiniestroInformante,resumenTrabajoEfectuado,telefonoConectado,est,historials,grav,tipoSin,bomb1,dotacions);

            //TODO
            return null;
        }
    }
}
