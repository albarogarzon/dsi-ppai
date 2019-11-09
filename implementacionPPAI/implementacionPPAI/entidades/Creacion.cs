using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace implementacionPPAI.Entidades
{
    public class Creacion
    {
        private List<Intervencion> intervenciones;

        public Creacion()
        {
            this.intervenciones = new List<Intervencion>();
        }
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
            //Estados
            Estado programada = new Estado("Intervención", "Estado al registrar una intervención", "Programada");
            Estado convocada  = new Estado("Intervención", "Estado al convocar una intervención", "Convocada");
            Estado cancelada = new Estado("Intervención", "Estado al cancelar a una intervención", "Cancelada");
            Estado enCurso = new Estado("Intervención", "Estado al iniciar una intervención", "EnCurso");
            Estado abortada = new Estado("Intervención", "Estado al abortar un intervención en curso", "Abortada");
            Estado finalizada = new Estado("Intervención", "Estado al finalizar una intervención que estaba en curso", "Finalizada");
            Estado firmada = new Estado("Intervención", "Estado al firmar una intervención finalizada", "Firmada");

            //Gravedades
            Gravedad baja = new Gravedad("Gravedad baja", "Baja");
            Gravedad media = new Gravedad("Gravedad media", "Media");
            Gravedad alta = new Gravedad("Gravedad Alta", "Alta");

            //Tipos siniestros
            TipoSiniestro incendio = new TipoSiniestro("siniestro de tipo incendio", "Incendio");
            TipoSiniestro rescate = new TipoSiniestro("siniestro de tipo rescate", "Rescate");
            TipoSiniestro accidenteVial = new TipoSiniestro("siniestro de tipo Accidente vial", "Accidente vial");
            TipoSiniestro evacuacion = new TipoSiniestro("siniestro de tipo Evacuación", "Evacuacion");

            //Bombero
            Bombero bombero1 = new Bombero(true, "Juan", "Perez", "Velez Sarsfield 4200", "30405598", "perezjuan@gmail.com", "15389453");

            //Historiales intervencion 1
            HistorialIntervencion h1 = new HistorialIntervencion(new DateTime(2019,9,26,13,30,0), new DateTime(2019,9,26,13,40,0), programada);
            HistorialIntervencion h2 = new HistorialIntervencion(new DateTime(2019,9,26,13,40,0), new DateTime(2019,9,26,13,55,0), convocada);
            HistorialIntervencion h3 = new HistorialIntervencion(new DateTime(2019,9,26,13,55,0), new DateTime(2019,9,26,15,40,0), enCurso);
            HistorialIntervencion h4 = new HistorialIntervencion(new DateTime(2019,9,26,15,40,0), new DateTime(2019,9,26,15,45,0), finalizada);
            HistorialIntervencion h5 = new HistorialIntervencion(new DateTime(2019,9,26,15,45,0), new DateTime(2019,9,26,15,47,0), firmada);

            List<HistorialIntervencion> historiales1 = new List<HistorialIntervencion>();
            historiales1.Add(h1);
            historiales1.Add(h2);
            historiales1.Add(h3);
            historiales1.Add(h4);
            historiales1.Add(h5);

            //Historiales intervencion 2
            HistorialIntervencion h6 = new HistorialIntervencion(new DateTime(2019,11,26,20,30,0), new DateTime(2019,9,26,20,40,0), programada);
            HistorialIntervencion h7 = new HistorialIntervencion(new DateTime(2019,9,26,20,40,0), new DateTime(2019,9,26,20,55,0), convocada);
            HistorialIntervencion h8 = new HistorialIntervencion(new DateTime(2019,9,26,20,55,0), new DateTime(2019,9,26,23,40,0), enCurso);
            HistorialIntervencion h9 = new HistorialIntervencion(new DateTime(2019,9,26,23,40,0), new DateTime(2019,9,26,23,45,0), finalizada);
            HistorialIntervencion h10 = new HistorialIntervencion(new DateTime(2019,9,26,23,45,0), new DateTime(2019,9,26,23,47,0), firmada);
            
            List<HistorialIntervencion> historiales2 = new List<HistorialIntervencion>();
            historiales2.Add(h6);
            historiales2.Add(h7);
            historiales2.Add(h8);
            historiales2.Add(h9);
            historiales2.Add(h10);

            //Historiales intervencion 3
            HistorialIntervencion h11 = new HistorialIntervencion(new DateTime(2019,7,26,10,30,0), new DateTime(2019,9,26,10,40,0), programada);
            HistorialIntervencion h12 = new HistorialIntervencion(new DateTime(2019,7,26,10,40,0), new DateTime(2019,9,26,10,55,0), convocada);
            HistorialIntervencion h13 = new HistorialIntervencion(new DateTime(2019,7,26,10,55,0), new DateTime(2019,9,26,15,40,0), enCurso);
            HistorialIntervencion h14 = new HistorialIntervencion(new DateTime(2019,7,26,15,40,0), new DateTime(2019,9,26,15,45,0), finalizada);
            HistorialIntervencion h15 = new HistorialIntervencion(new DateTime(2019,7,26,15,45,0), new DateTime(2019,9,26,15,47,0), firmada);

            List<HistorialIntervencion> historiales3 = new List<HistorialIntervencion>();
            historiales3.Add(h11);
            historiales3.Add(h12);
            historiales3.Add(h13);
            historiales3.Add(h14);
            historiales3.Add(h15);

            //Historiales intervencion 4 (fuera de periodo)
            HistorialIntervencion h16 = new HistorialIntervencion(new DateTime(2019,3,26,13,30,0), new DateTime(2019,3,26,13,40,0), programada);
            HistorialIntervencion h17 = new HistorialIntervencion(new DateTime(2019,3,26,13,40,0), new DateTime(2019,3,26,13,55,0), convocada);
            HistorialIntervencion h18 = new HistorialIntervencion(new DateTime(2019,3,26,13,55,0), new DateTime(2019,3,26,15,40,0), enCurso);
            HistorialIntervencion h19 = new HistorialIntervencion(new DateTime(2019,3,26,15,40,0), new DateTime(2019,3,26,15,45,0), finalizada);
            HistorialIntervencion h20 = new HistorialIntervencion(new DateTime(2019,3,26,13,45,0), new DateTime(2019,3,26,13,47,0), firmada);

            List<HistorialIntervencion> historiales4 = new List<HistorialIntervencion>();
            historiales4.Add(h16);
            historiales4.Add(h17);
            historiales4.Add(h18);
            historiales4.Add(h19);
            historiales4.Add(h20);



            //Historiales intervencion 5 (abortada)
            HistorialIntervencion h21 = new HistorialIntervencion(new DateTime(2019,2,26,13,30,0), new DateTime(2019,2,26,13,40,0), programada);
            HistorialIntervencion h22 = new HistorialIntervencion(new DateTime(2019,2,26,13,40,0), new DateTime(2019,2,26,13,55,0), convocada);
            HistorialIntervencion h23 = new HistorialIntervencion(new DateTime(2019,2,26,13,55,0), new DateTime(2019,2,26,15,40,0), enCurso);
            HistorialIntervencion h24 = new HistorialIntervencion(new DateTime(2019,2,26,15,40,0), new DateTime(2019,2,26,15,45,0), abortada);
            
            List<HistorialIntervencion> historiales5 = new List<HistorialIntervencion>();
            historiales5.Add(h21);
            historiales5.Add(h22);
            historiales5.Add(h23);
            historiales5.Add(h24);

            //Dotaciones
            Dotacion dotacion1 = new Dotacion(new DateTime(2019, 3, 3, 1, 1, 1), new DateTime(2019, 3, 3, 1, 1, 1), 1500, 1522);
            Dotacion dotacion2 = new Dotacion(new DateTime(2019, 3, 3, 1, 1, 1), new DateTime(2019, 3, 3, 1, 1, 1), 1500, 1522);
            Dotacion dotacion3 = new Dotacion(new DateTime(2019, 3, 3, 1, 1, 1), new DateTime(2019, 3, 3, 1, 1, 1), 1500, 1522);

            List<Dotacion> dotaciones1 = new List<Dotacion>();
            dotaciones1.Add(dotacion1);
            dotaciones1.Add(dotacion2);

            List<Dotacion> dotaciones2 = new List<Dotacion>();
            dotaciones2.Add(dotacion3);

            List<Dotacion> dotaciones3 = new List<Dotacion>();
            dotaciones3.Add(dotacion2);
            dotaciones3.Add(dotacion1);

            List<Dotacion> dotaciones4 = new List<Dotacion>();
            dotaciones4.Add(dotacion2);
            dotaciones4.Add(dotacion1);

            List<Dotacion> dotaciones5 = new List<Dotacion>();

            //Intervenciones
            Intervencion intervencion1 = new Intervencion("Calle falsa 123", "Juan Gonazalez", "Choque frontal entre dos vehiculos", "Choque frontal entre dos vehiculos, ambos choferes quedaron atrapados, se efectuaron tareas de rescate.", "15168466", firmada, historiales1, alta, accidenteVial, bombero1, dotaciones1);
            Intervencion intervencion2 = new Intervencion("Calle falsa 123", "Juan Gonazalez", "Vuelco de vehiculo", "Vuelco de vehiculo particular, el conductor quedó atrapado, por lo que se realizaron tareas de rescate.", "15168466", firmada, historiales2, alta, accidenteVial, bombero1, dotaciones2);
            Intervencion intervencion3 = new Intervencion("Calle falsa 123", "Juan Gonazalez", "Incendio en una fabrica de colchones", "Incendio en fabrica de colchones, se realizaron tareas de evacuación del personal de la fabrica y se apagó el incendio.", "15168466", firmada, historiales3, alta, incendio, bombero1, dotaciones3);
            Intervencion intervencion4 = new Intervencion("Calle falsa 123", "Juan Gonazalez", "Individuos atrapados en un ascensor", "Individuos atrapados en un ascensot, se efectuaron tareas de rescate de los individuos.", "15168466", firmada, historiales4, baja, rescate, bombero1, dotaciones4);
            Intervencion intervencion5 = new Intervencion("Calle falsa 123", "Juan Gonazalez", "Se dió aviso de incendio en una casa, pero resultó en una falsa alarma", "No se efectuaron tareas debido a que fue una falsa alarma", "15168466", abortada, historiales5, baja, incendio, bombero1, dotaciones5);

            this.intervenciones.Add(intervencion1);
            this.intervenciones.Add(intervencion2);
            this.intervenciones.Add(intervencion3);
            this.intervenciones.Add(intervencion4);
            this.intervenciones.Add(intervencion5);


            return this.intervenciones;




        }
    }
}
