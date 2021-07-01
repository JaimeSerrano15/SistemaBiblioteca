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
    public partial class FrmListarLibros : Form
    {
        public FrmListarLibros()
        {
            InitializeComponent();
        }

        private void FrmListarLibros_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DsSistema.listar_libro' Puede moverla o quitarla según sea necesario.
            this.listar_libroTableAdapter.Fill(this.DsSistema.listar_libro);

            this.reportViewer1.RefreshReport();
        }
    }
}
