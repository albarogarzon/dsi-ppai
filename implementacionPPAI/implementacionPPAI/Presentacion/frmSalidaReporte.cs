using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace implementacionPPAI.Presentacion
{
    
    public partial class FrmSalidaReporte : Form
    {
        private List<List<string>> datosIntervenciones;
        private DateTime fechaDesde;
        private DateTime fechaFin;
        private string tiempoAAnalizar;
        private TimeSpan tiempoPromedio;
        private List<string> tipoGravedad;
        private List<string> tipoSiniestro;

        public FrmSalidaReporte()
        {
            this.tipoGravedad = new List<string>();
            this.tipoSiniestro = new List<string>();
            this.datosIntervenciones = new List<List<string>>();
            this.fechaDesde = new DateTime();
            this.fechaFin = new DateTime();
            this.tiempoPromedio = new TimeSpan();
            this.tiempoAAnalizar = "";
            InitializeComponent();
        }

        public void setEncabezado(TimeSpan tiempoPromedio, DateTime fechaHoraDesdePeriodo, DateTime fechaHoraHastaPeriodo, List<string> nombreTipoSiniestro, List<string> nombreTipoGravedad, string tiempoAnalizar)
        {
            this.setFechaDesde(fechaHoraDesdePeriodo);
            this.setFechaFin(fechaHoraHastaPeriodo);
            this.setTiempoPromedio(tiempoPromedio);
            this.setTipoGravedad(nombreTipoGravedad);
            this.setTipoSiniestro(nombreTipoGravedad);
            this.settiempoAAnalizar(tiempoAnalizar);
        }

        public void setDetalleIntervenciones(List<string> datosIntervenciones)
        {

            dataGridView1.Rows.Add(datosIntervenciones);


        }
        public void setFechaDesde(DateTime fechaDesde)
        {
            this.fechaDesde = fechaDesde;
        }
        public void setFechaFin(DateTime fechaHasta)
        {
            this.fechaFin = fechaHasta;
        }
        public void settiempoAAnalizar(string tiempoAAnalizar)
        {
            this.tiempoAAnalizar = tiempoAAnalizar;
        }

        public void setTiempoPromedio(TimeSpan tiempoPromedio)
        {
            this.tiempoPromedio = tiempoPromedio;

        }
        
        public void setTipoGravedad(List<string> tipoGravedad)
        {
            this.tipoGravedad = tipoGravedad;
        }

        public void setTipoSiniestro(List<string> tipoSiniestro)
        {
            this.tipoSiniestro = tipoSiniestro;
        }
        
        public void inicializarReporte()
        {
            string gravedades = "";
            string siniestros = "";
            textBoxFechaDesde.Text = fechaDesde.ToString("d");
            textBoxFechaHasta.Text = fechaFin.ToString("d");
            textBoxPromedioDuracion.Text = tiempoPromedio.ToString();
            foreach(string gravedad in tipoGravedad)
            {
                gravedades += gravedad + ", ";
            }
            foreach(string siniestro in tipoSiniestro)
            {
                siniestros += siniestro + ", ";
            }
            txtGravedad.Text = gravedades;
            txtSiniestro.Text = siniestros;
            txtTiempoAnalizar.Text = tiempoAAnalizar;
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
