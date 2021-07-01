using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaBiblioteca.Negocio;


namespace SistemaBiblioteca.Presentacion
{
    public partial class FrmPrestamoVideo : Form
    {
        public FrmPrestamoVideo()
        {
            InitializeComponent();
        }

        private void dgvVideos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvVideos.Columns["SeleccionarVideo"].Index)
            {
                foreach (DataGridViewRow row in dgvVideos.Rows)
                {
                    if (Convert.ToBoolean(row.Cells[0].Value))
                    {
                        row.Cells[0].Value = false;
                    }
                }

                DataGridViewCheckBoxCell Seleccionar = (DataGridViewCheckBoxCell)dgvVideos.Rows[e.RowIndex].Cells["SeleccionarVideo"];
                Seleccionar.Value = !Convert.ToBoolean(Seleccionar.Value);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Listar_Profesores()
        {
            try
            {
                dgvProfesores.DataSource = NPrestamo_video.Listar_Profesores();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void Buscar_Profesor(string valor)
        {
            try
            {
                dgvProfesores.DataSource = NPrestamo_video.Buscar_Profesor(valor);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        private void Listar_Videos()
        {
            try
            {
                dgvVideos.DataSource = NPrestamo_video.Listar_Videos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void Buscar_Video(string valor)
        {
            try
            {
                dgvVideos.DataSource = NPrestamo_video.Buscar_Video(valor);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }


        private void FrmPrestamoVideo_Load(object sender, EventArgs e)
        {
            Listar_Videos();
            Listar_Profesores();
        }

        private void btnBuscarVideo_Click(object sender, EventArgs e)
        {
            try
            {
                string valor = "";
                if (tbVideos.Text == string.Empty)
                {
                    Listar_Videos();
                }
                else
                {
                    valor = tbVideos.Text;
                    Buscar_Video(valor);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnBuscarProfesor_Click(object sender, EventArgs e)
        {
            try
            {
                string valor = "";
                if (txProfesor.Text == string.Empty)
                {
                    Listar_Profesores();
                }
                else
                {
                    valor = txProfesor.Text;
                    Buscar_Profesor(valor);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            int profesor = 0;
            string profesor_name = "";
            int codigo_video = 0;
            DateTime fecha_devolucion = datePick.Value;
            DateTime fecha_prestamo = DateTime.Today;
            foreach (DataGridViewRow row in dgvProfesores.Rows)
            {
                if (Convert.ToBoolean(row.Cells[0].Value))
                {
                    profesor = Convert.ToInt32(row.Cells[1].Value);
                    profesor_name = Convert.ToString(row.Cells[2].Value);
                }
            }

            foreach (DataGridViewRow row in dgvVideos.Rows)
            {
                if (Convert.ToBoolean(row.Cells[0].Value))
                {
                    codigo_video = Convert.ToInt32(row.Cells[1].Value);
                }
            }

            NPrestamo_video.Insertar_Prestamo(profesor, codigo_video,
            fecha_prestamo, fecha_devolucion);
            dgvPrestamosVideos.DataSource = NPrestamo_video.Listar_Prestamos(profesor_name);
        }

        private void dgvProfesores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvProfesores.Columns["SeleccionarProfesor"].Index)
            {
                if (e.ColumnIndex == dgvProfesores.Columns["SeleccionarProfesor"].Index)
                {
                    foreach (DataGridViewRow row in dgvProfesores.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            row.Cells[0].Value = false;
                        }
                    }

                    DataGridViewCheckBoxCell Seleccionar = (DataGridViewCheckBoxCell)dgvProfesores.Rows[e.RowIndex].Cells["SeleccionarProfesor"];
                    Seleccionar.Value = !Convert.ToBoolean(Seleccionar.Value);

                    string nombre;

                    foreach (DataGridViewRow row in dgvProfesores.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            nombre = Convert.ToString(row.Cells[2].Value);
                            dgvPrestamosVideos.DataSource = NPrestamo_video.Listar_Prestamos(nombre);
                        }
                    }
                }
            }
        }
    }
}
