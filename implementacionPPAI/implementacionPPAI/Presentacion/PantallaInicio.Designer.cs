﻿namespace implementacionPPAI
{
    partial class PantallaInicio
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.intervecionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generarReporteDeTiemposDeIntervencionToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.generarReporteDeCumplimientoDeGuardiasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.bomberosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem,
            this.intervecionToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.bomberosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.inicioToolStripMenuItem.Text = "Inicio";
            // 
            // intervecionToolStripMenuItem
            // 
            this.intervecionToolStripMenuItem.Name = "intervecionToolStripMenuItem";
            this.intervecionToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.intervecionToolStripMenuItem.Text = "Intervencion";
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generarReporteDeTiemposDeIntervencionToolStripMenuItem1,
            this.generarReporteDeCumplimientoDeGuardiasToolStripMenuItem1});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // generarReporteDeTiemposDeIntervencionToolStripMenuItem1
            // 
            this.generarReporteDeTiemposDeIntervencionToolStripMenuItem1.Name = "generarReporteDeTiemposDeIntervencionToolStripMenuItem1";
            this.generarReporteDeTiemposDeIntervencionToolStripMenuItem1.Size = new System.Drawing.Size(314, 22);
            this.generarReporteDeTiemposDeIntervencionToolStripMenuItem1.Text = "Generar reporte de tiempos de intervencion";
            this.generarReporteDeTiemposDeIntervencionToolStripMenuItem1.Click += new System.EventHandler(this.generarReporteDeTiemposDeIntervencionToolStripMenuItem1_Click);
            // 
            // generarReporteDeCumplimientoDeGuardiasToolStripMenuItem1
            // 
            this.generarReporteDeCumplimientoDeGuardiasToolStripMenuItem1.Name = "generarReporteDeCumplimientoDeGuardiasToolStripMenuItem1";
            this.generarReporteDeCumplimientoDeGuardiasToolStripMenuItem1.Size = new System.Drawing.Size(314, 22);
            this.generarReporteDeCumplimientoDeGuardiasToolStripMenuItem1.Text = "Generar reporte de cumplimiento de guardias";
            // 
            // bomberosToolStripMenuItem
            // 
            this.bomberosToolStripMenuItem.Name = "bomberosToolStripMenuItem";
            this.bomberosToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.bomberosToolStripMenuItem.Text = "Bomberos";
            // 
            // PantallaInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PantallaInicio";
            this.Text = "PantallaInicio";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem intervecionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bomberosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generarReporteDeTiemposDeIntervencionToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem generarReporteDeCumplimientoDeGuardiasToolStripMenuItem1;
    }
}