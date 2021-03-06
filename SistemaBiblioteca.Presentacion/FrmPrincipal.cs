using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaBiblioteca.Presentacion
{
    public partial class FrmPrincipal : Form
    {
        private int childFormNumber = 0;
        public int idUser;
        public int idRol;
        public string name;
        public string rol;
        public bool estado;

        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void librosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void libroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLibro frm = new FrmLibro();
            frm.MdiParent = this;
            frm.Show();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            StBarraInferior.Text = "Sistema de Mantenimiento de Biblioteca, Usuario: " + this.name;
            MessageBox.Show("Bienvenido: " + this.name, "Sistema de Biblioteca", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void videosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmVideo frm = new FrmVideo();
            frm.MdiParent = this;
            frm.Show();
        }

        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void libroToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmPrestamoLibro frm = new FrmPrestamoLibro();
            frm.MdiParent = this;
            frm.Show();
        }

        private void videoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPrestamoVideo frm = new FrmPrestamoVideo();
            frm.MdiParent = this;
            frm.Show();
        }

        private void librosRegistradosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reportes.FrmListarLibros reporteLibros = new Reportes.FrmListarLibros();
            reporteLibros.ShowDialog();
        }

        private void prestamosActivosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reportes.FrmPrestamosActivos prestamosActivos = new Reportes.FrmPrestamosActivos();
            prestamosActivos.ShowDialog();
        }

        private void videosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Reportes.FrmVideos videos = new Reportes.FrmVideos();
            videos.ShowDialog();
        }
    }
}
