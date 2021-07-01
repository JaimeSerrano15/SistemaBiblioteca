using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaBiblioteca.Presentacion.Reportes
{
    public partial class FrmVideos : Form
    {
        public FrmVideos()
        {
            InitializeComponent();
        }

        private void FrmVideos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DsSistema.listarVideo' Puede moverla o quitarla según sea necesario.
            this.listarVideoTableAdapter.Fill(this.DsSistema.listarVideo);

            this.reportViewer1.RefreshReport();
        }
    }
}
