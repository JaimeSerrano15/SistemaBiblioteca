﻿
namespace SistemaBiblioteca.Presentacion.Reportes
{
    partial class FrmVideos
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DsSistema = new SistemaBiblioteca.Presentacion.Reportes.DsSistema();
            this.listarVideoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listarVideoTableAdapter = new SistemaBiblioteca.Presentacion.Reportes.DsSistemaTableAdapters.listarVideoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DsSistema)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listarVideoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DsVideos";
            reportDataSource1.Value = this.listarVideoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SistemaBiblioteca.Presentacion.Reportes.RptVideos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // DsSistema
            // 
            this.DsSistema.DataSetName = "DsSistema";
            this.DsSistema.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // listarVideoBindingSource
            // 
            this.listarVideoBindingSource.DataMember = "listarVideo";
            this.listarVideoBindingSource.DataSource = this.DsSistema;
            // 
            // listarVideoTableAdapter
            // 
            this.listarVideoTableAdapter.ClearBeforeFill = true;
            // 
            // FrmVideos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmVideos";
            this.Text = "FrmVideos";
            this.Load += new System.EventHandler(this.FrmVideos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DsSistema)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listarVideoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource listarVideoBindingSource;
        private DsSistema DsSistema;
        private DsSistemaTableAdapters.listarVideoTableAdapter listarVideoTableAdapter;
    }
}