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

        public PantallaReporteTI()
        {
            InitializeComponent();
            gr = new GestorReporteTiempoIntervencion();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            logicaBotonConfirmar(); 
        }

        public void logicaBotonConfirmar() {

            if (validarPeriodo())
            {
                MessageBox.Show("ok", "Alerta");

                DateTime fechaHoraDesde =Convert.ToDateTime(dtpDesde);
                DateTime fechaHoraHasta = Convert.ToDateTime(dtpHasta);

                gr.tomarSeleccionPeriodo(fechaHoraDesde, fechaHoraHasta);

                List<string> listaTipoSiniestro = chkTiposSiniestros.CheckedItems.OfType<string>().ToList();
                
                gr.tomarSeleccionTipoSiniestro(listaTipoSiniestro);

                List<string> listaGravedad = chkNivelesGravedad.CheckedItems.OfType<string>().ToList();
                gr.tomarSeleccionGravedad(listaGravedad);

                string tiempoAnalizar = "";
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
