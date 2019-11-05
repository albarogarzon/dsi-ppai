using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace implementacionPPAI
{
    public partial class PantallaReporteTI : Form
    {
        public PantallaReporteTI()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            notifyIcon1.Text = "HAS SIDO HACKEADO";
            notifyIcon1.BalloonTipText = "has presionado el boton NO presionar." +
                "HAS SIDO RE HACKEADO";
            notifyIcon1.BalloonTipTitle = "notificacion";
            notifyIcon1.Icon = SystemIcons.Application;
            notifyIcon1.ShowBalloonTip(1000);
        }

        private void checkedListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
