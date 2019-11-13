namespace implementacionPPAI.Presentacion
{
    partial class FrmSalidaReporte
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxFechaDesde = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxFechaHasta = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxPromedioDuracion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtGravedad = new System.Windows.Forms.TextBox();
            this.txtSiniestro = new System.Windows.Forms.TextBox();
            this.txtTiempoAnalizar = new System.Windows.Forms.TextBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(330, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reporte de tiempo promedio de duracion de intervenciones  entre el ";
            // 
            // textBoxFechaDesde
            // 
            this.textBoxFechaDesde.Location = new System.Drawing.Point(348, 6);
            this.textBoxFechaDesde.Name = "textBoxFechaDesde";
            this.textBoxFechaDesde.Size = new System.Drawing.Size(100, 20);
            this.textBoxFechaDesde.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(455, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "y el";
            // 
            // textBoxFechaHasta
            // 
            this.textBoxFechaHasta.Location = new System.Drawing.Point(484, 6);
            this.textBoxFechaHasta.Name = "textBoxFechaHasta";
            this.textBoxFechaHasta.Size = new System.Drawing.Size(100, 20);
            this.textBoxFechaHasta.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(353, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Promedio total de duracion de las intervanciones en el estado \"EnCurso\":";
            // 
            // textBoxPromedioDuracion
            // 
            this.textBoxPromedioDuracion.Location = new System.Drawing.Point(371, 60);
            this.textBoxPromedioDuracion.Name = "textBoxPromedioDuracion";
            this.textBoxPromedioDuracion.Size = new System.Drawing.Size(54, 20);
            this.textBoxPromedioDuracion.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Resumen de las intervenciones:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column4,
            this.Column2Apellido,
            this.Column5});
            this.dataGridView1.Location = new System.Drawing.Point(15, 233);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(620, 150);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Tipo Gravedad Seleccionada/s:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Tipo Siniestro Selecciondo/s:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 169);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Tiempo a analizar: ";
            // 
            // txtGravedad
            // 
            this.txtGravedad.Location = new System.Drawing.Point(194, 100);
            this.txtGravedad.Name = "txtGravedad";
            this.txtGravedad.Size = new System.Drawing.Size(100, 20);
            this.txtGravedad.TabIndex = 11;
            // 
            // txtSiniestro
            // 
            this.txtSiniestro.Location = new System.Drawing.Point(194, 130);
            this.txtSiniestro.Name = "txtSiniestro";
            this.txtSiniestro.Size = new System.Drawing.Size(100, 20);
            this.txtSiniestro.TabIndex = 12;
            // 
            // txtTiempoAnalizar
            // 
            this.txtTiempoAnalizar.Location = new System.Drawing.Point(194, 162);
            this.txtTiempoAnalizar.Name = "txtTiempoAnalizar";
            this.txtTiempoAnalizar.Size = new System.Drawing.Size(100, 20);
            this.txtTiempoAnalizar.TabIndex = 13;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Descripcion";
            this.Column1.Name = "Column1";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Nombre Encargado";
            this.Column4.Name = "Column4";
            // 
            // Column2Apellido
            // 
            this.Column2Apellido.HeaderText = "Apellido Encargado";
            this.Column2Apellido.Name = "Column2Apellido";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Cantidad de dotaciones";
            this.Column5.Name = "Column5";
            // 
            // FrmSalidaReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtTiempoAnalizar);
            this.Controls.Add(this.txtSiniestro);
            this.Controls.Add(this.txtGravedad);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxPromedioDuracion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxFechaHasta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxFechaDesde);
            this.Controls.Add(this.label1);
            this.Name = "FrmSalidaReporte";
            this.Text = "frmSalidaReporte";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxFechaDesde;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxFechaHasta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxPromedioDuracion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtGravedad;
        private System.Windows.Forms.TextBox txtSiniestro;
        private System.Windows.Forms.TextBox txtTiempoAnalizar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}