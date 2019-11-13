using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using implementacionPPAI.Entidades;

namespace implementacionPPAI
{
    public partial class PantallaReporteTI : Form
    {

        private GestorReporteTiempoIntervencion gr;
        private List<string> listaTipoSiniestro;
        private List<string> listaGravedad;
        private DateTime fechaHoraDesde;
        private DateTime fechaHoraHasta;
        private string tiempoAnalizar;
        public PantallaReporteTI()
        {
            this.listaTipoSiniestro = new List<string>();
            this.listaGravedad = new List<string>();
            this.fechaHoraDesde = new DateTime();
            this.fechaHoraHasta = new DateTime();
            this.tiempoAnalizar = "";
            gr = new GestorReporteTiempoIntervencion();
            InitializeComponent();
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            logicaBotonConfirmar(); 
        }

        public void logicaBotonConfirmar() {

            if (validarPeriodo())
            {
                

                fechaHoraDesde = dtpDesde.Value.Date;
                fechaHoraHasta = dtpHasta.Value.Date;

                gr.tomarSeleccionPeriodo(fechaHoraDesde, fechaHoraHasta);

                listaTipoSiniestro = chkTiposSiniestros.CheckedItems.OfType<string>().ToList();
                
                gr.tomarSeleccionTipoSiniestro(listaTipoSiniestro);

                listaGravedad = chkNivelesGravedad.CheckedItems.OfType<string>().ToList();
                gr.tomarSeleccionGravedad(listaGravedad);
                

                if (radioButtonDuracion.Checked)
                {
                    tiempoAnalizar = "Duracion";
                }
                else if (radioButtonRespuesta.Checked)
                {
                    tiempoAnalizar = "Respuesta";
                }
                else
                {
                    tiempoAnalizar = "Cierre";
                }
                gr.tomarSeleccionTiempoAnalizar(tiempoAnalizar);

                gr.tomarConfirmacionFiltros();
            }
            else
            {
                MessageBox.Show("Debe igresar un periodo valido", "Alerta");
            }
            

        }

        private bool validarPeriodo()
        {

            if (dtpHasta.Value > dtpDesde.Value)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
      
    
        private void PantallaReporteTI_Load(object sender, EventArgs e)
        {
          
        }
    }
}
