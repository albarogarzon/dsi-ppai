namespace implementacionPPAI
{
    partial class PantallaReporteTI
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.chkTiposSiniestros = new System.Windows.Forms.CheckedListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.chkNivelesGravedad = new System.Windows.Forms.CheckedListBox();
            this.radioButtonDuracion = new System.Windows.Forms.RadioButton();
            this.groupBoxTipoTiempo = new System.Windows.Forms.GroupBox();
            this.radioButtonCierre = new System.Windows.Forms.RadioButton();
            this.radioButtonRespuesta = new System.Windows.Forms.RadioButton();
            this.groupBoxTipoVisualizacion = new System.Windows.Forms.GroupBox();
            this.radioButtonExcel = new System.Windows.Forms.RadioButton();
            this.radioButtonPDF = new System.Windows.Forms.RadioButton();
            this.radioButtonPantalla = new System.Windows.Forms.RadioButton();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.groupBoxTipoTiempo.SuspendLayout();
            this.groupBoxTipoVisualizacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(381, 624);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(132, 61);
            this.btnConfirmar.TabIndex = 0;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.button1_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "*Seleccione el periodo de tiempo a incluir en el reporte";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Desde:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Hasta:";
            // 
            // dtpDesde
            // 
            this.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDesde.Location = new System.Drawing.Point(60, 61);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(102, 20);
            this.dtpDesde.TabIndex = 4;
            // 
            // dtpHasta
            // 
            this.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHasta.Location = new System.Drawing.Point(60, 112);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(102, 20);
            this.dtpHasta.TabIndex = 6;
            // 
            // chkTiposSiniestros
            // 
            this.chkTiposSiniestros.BackColor = System.Drawing.SystemColors.Menu;
            this.chkTiposSiniestros.FormattingEnabled = true;
            this.chkTiposSiniestros.Items.AddRange(new object[] {
            "Incendio",
            "Accidente",
            "Rescate",
            "Evacuacion"});
            this.chkTiposSiniestros.Location = new System.Drawing.Point(15, 179);
            this.chkTiposSiniestros.Name = "chkTiposSiniestros";
            this.chkTiposSiniestros.Size = new System.Drawing.Size(120, 64);
            this.chkTiposSiniestros.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(267, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "*Seleccione los tipos de siniestros a incluir en el reporte";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(280, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "*Seleccione los niveles de gravedad a incluir en el reporte";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 352);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(264, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "*Seleccione el tipo de tiempo a calcular para el reporte";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 494);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(244, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "*Seleccione el tipo de visualizacion para el reporte";
            // 
            // chkNivelesGravedad
            // 
            this.chkNivelesGravedad.BackColor = System.Drawing.SystemColors.Menu;
            this.chkNivelesGravedad.FormattingEnabled = true;
            this.chkNivelesGravedad.Items.AddRange(new object[] {
            "Alto",
            "Medio",
            "Bajo"});
            this.chkNivelesGravedad.Location = new System.Drawing.Point(17, 271);
            this.chkNivelesGravedad.Name = "chkNivelesGravedad";
            this.chkNivelesGravedad.Size = new System.Drawing.Size(120, 64);
            this.chkNivelesGravedad.TabIndex = 13;
            // 
            // radioButtonDuracion
            // 
            this.radioButtonDuracion.AutoSize = true;
            this.radioButtonDuracion.Location = new System.Drawing.Point(26, 19);
            this.radioButtonDuracion.Name = "radioButtonDuracion";
            this.radioButtonDuracion.Size = new System.Drawing.Size(68, 17);
            this.radioButtonDuracion.TabIndex = 16;
            this.radioButtonDuracion.TabStop = true;
            this.radioButtonDuracion.Text = "Duracion";
            this.radioButtonDuracion.UseVisualStyleBackColor = true;
            // 
            // groupBoxTipoTiempo
            // 
            this.groupBoxTipoTiempo.Controls.Add(this.radioButtonCierre);
            this.groupBoxTipoTiempo.Controls.Add(this.radioButtonRespuesta);
            this.groupBoxTipoTiempo.Controls.Add(this.radioButtonDuracion);
            this.groupBoxTipoTiempo.Location = new System.Drawing.Point(17, 368);
            this.groupBoxTipoTiempo.Name = "groupBoxTipoTiempo";
            this.groupBoxTipoTiempo.Size = new System.Drawing.Size(200, 100);
            this.groupBoxTipoTiempo.TabIndex = 17;
            this.groupBoxTipoTiempo.TabStop = false;
            // 
            // radioButtonCierre
            // 
            this.radioButtonCierre.AutoSize = true;
            this.radioButtonCierre.Location = new System.Drawing.Point(26, 65);
            this.radioButtonCierre.Name = "radioButtonCierre";
            this.radioButtonCierre.Size = new System.Drawing.Size(52, 17);
            this.radioButtonCierre.TabIndex = 19;
            this.radioButtonCierre.TabStop = true;
            this.radioButtonCierre.Text = "Cierre";
            this.radioButtonCierre.UseVisualStyleBackColor = true;
            // 
            // radioButtonRespuesta
            // 
            this.radioButtonRespuesta.AutoSize = true;
            this.radioButtonRespuesta.Location = new System.Drawing.Point(26, 42);
            this.radioButtonRespuesta.Name = "radioButtonRespuesta";
            this.radioButtonRespuesta.Size = new System.Drawing.Size(76, 17);
            this.radioButtonRespuesta.TabIndex = 18;
            this.radioButtonRespuesta.TabStop = true;
            this.radioButtonRespuesta.Text = "Respuesta";
            this.radioButtonRespuesta.UseVisualStyleBackColor = true;
            // 
            // groupBoxTipoVisualizacion
            // 
            this.groupBoxTipoVisualizacion.Controls.Add(this.radioButtonExcel);
            this.groupBoxTipoVisualizacion.Controls.Add(this.radioButtonPDF);
            this.groupBoxTipoVisualizacion.Controls.Add(this.radioButtonPantalla);
            this.groupBoxTipoVisualizacion.Location = new System.Drawing.Point(17, 510);
            this.groupBoxTipoVisualizacion.Name = "groupBoxTipoVisualizacion";
            this.groupBoxTipoVisualizacion.Size = new System.Drawing.Size(200, 100);
            this.groupBoxTipoVisualizacion.TabIndex = 18;
            this.groupBoxTipoVisualizacion.TabStop = false;
            // 
            // radioButtonExcel
            // 
            this.radioButtonExcel.AutoSize = true;
            this.radioButtonExcel.Location = new System.Drawing.Point(26, 65);
            this.radioButtonExcel.Name = "radioButtonExcel";
            this.radioButtonExcel.Size = new System.Drawing.Size(51, 17);
            this.radioButtonExcel.TabIndex = 19;
            this.radioButtonExcel.TabStop = true;
            this.radioButtonExcel.Text = "Excel";
            this.radioButtonExcel.UseVisualStyleBackColor = true;
            // 
            // radioButtonPDF
            // 
            this.radioButtonPDF.AutoSize = true;
            this.radioButtonPDF.Location = new System.Drawing.Point(26, 42);
            this.radioButtonPDF.Name = "radioButtonPDF";
            this.radioButtonPDF.Size = new System.Drawing.Size(46, 17);
            this.radioButtonPDF.TabIndex = 18;
            this.radioButtonPDF.TabStop = true;
            this.radioButtonPDF.Text = "PDF";
            this.radioButtonPDF.UseVisualStyleBackColor = true;
            // 
            // radioButtonPantalla
            // 
            this.radioButtonPantalla.AutoSize = true;
            this.radioButtonPantalla.Location = new System.Drawing.Point(26, 19);
            this.radioButtonPantalla.Name = "radioButtonPantalla";
            this.radioButtonPantalla.Size = new System.Drawing.Size(63, 17);
            this.radioButtonPantalla.TabIndex = 16;
            this.radioButtonPantalla.TabStop = true;
            this.radioButtonPantalla.Text = "Pantalla";
            this.radioButtonPantalla.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(233, 624);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(132, 61);
            this.btnCancelar.TabIndex = 19;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // PantallaReporteTI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(525, 697);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.groupBoxTipoVisualizacion);
            this.Controls.Add(this.groupBoxTipoTiempo);
            this.Controls.Add(this.chkNivelesGravedad);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.chkTiposSiniestros);
            this.Controls.Add(this.dtpHasta);
            this.Controls.Add(this.dtpDesde);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnConfirmar);
            this.Name = "PantallaReporteTI";
            this.Text = "Reporte de tiempos de intervecion";
            this.Load += new System.EventHandler(this.PantallaReporteTI_Load);
            this.groupBoxTipoTiempo.ResumeLayout(false);
            this.groupBoxTipoTiempo.PerformLayout();
            this.groupBoxTipoVisualizacion.ResumeLayout(false);
            this.groupBoxTipoVisualizacion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.CheckedListBox chkTiposSiniestros;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckedListBox chkNivelesGravedad;
        private System.Windows.Forms.RadioButton radioButtonDuracion;
        private System.Windows.Forms.GroupBox groupBoxTipoTiempo;
        private System.Windows.Forms.RadioButton radioButtonCierre;
        private System.Windows.Forms.RadioButton radioButtonRespuesta;
        private System.Windows.Forms.GroupBox groupBoxTipoVisualizacion;
        private System.Windows.Forms.RadioButton radioButtonExcel;
        private System.Windows.Forms.RadioButton radioButtonPDF;
        private System.Windows.Forms.RadioButton radioButtonPantalla;
        private System.Windows.Forms.Button btnCancelar;
    }
}

