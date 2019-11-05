using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using implementacionPPAI;

namespace implementacionPPAI
{
    public partial class PantallaInicio : Form
    {
        public PantallaInicio()
        {
            InitializeComponent();
        }

        private void generarReporteDeTiemposDeIntervencionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PantallaReporteTI PI = new PantallaReporteTI();
            PI.ShowDialog();
        }
    }
}
