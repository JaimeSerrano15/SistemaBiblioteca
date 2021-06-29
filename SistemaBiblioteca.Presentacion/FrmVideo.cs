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
    public partial class FrmVideo : Form
    {
        public FrmVideo()
        {
            InitializeComponent();
        }

        private void Listar()
        {
            try
            {
                DgvListadoVideos.DataSource = NVideo.Listar();
                this.Formato();
                this.Limpiar();
                LblTotalVideos.Text = "Total de Libros: " + Convert.ToString(DgvListadoVideos.Rows.Count);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void Buscar()
        {
            try
            {
                DgvListadoVideos.DataSource = NVideo.Buscar(TxtBuscarVideo.Text);
                this.Formato();
                LblTotalVideos.Text = "Total de Libros: " + Convert.ToString(DgvListadoVideos.Rows.Count);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void Formato()
        {
            DgvListadoVideos.Columns[0].Visible = false;
            DgvListadoVideos.Columns[1].Width = 50;
            DgvListadoVideos.Columns[2].Width = 200;
            DgvListadoVideos.Columns[3].Width = 200;
            DgvListadoVideos.Columns[4].Width = 200;
            DgvListadoVideos.Columns[5].Width = 100;
            DgvListadoVideos.Columns[6].Width = 100;
            DgvListadoVideos.Columns[7].Width = 100;
            DgvListadoVideos.Columns[8].Width = 50;
            DgvListadoVideos.Columns[9].Width = 100;
            DgvListadoVideos.Columns[10].Width = 100;
            DgvListadoVideos.Columns[11].Width = 100;
            DgvListadoVideos.Columns[12].Width = 100;
            DgvListadoVideos.Columns[13].Width = 400;
            DgvListadoVideos.Columns[14].Width = 50;
        }

        private void Limpiar()
        {
            txtTitulo.Clear();
            TxtDirector.Clear();
            txtProductora.Clear();
            TxtAnio.Clear();
            TxtDuracion.Clear();
            TxtPais.Clear();
            TxtIdioma.Clear();
            TxtSub.Clear();
            TxtClasificacion.Clear();
            TxtGenero.Clear();
            TxtUbicacion.Clear();
            TxtSinopsis.Clear();

            DgvListadoVideos.Columns[0].Visible = false;
            BtnEliminarVideo.Visible = false;
            ChkSeleccionarVideo.Checked = false;
        }

        private void MensajeError(string msg)
        {
            MessageBox.Show(msg, "Sistema de Biblioteca", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void MensajeOk(string msg)
        {
            MessageBox.Show(msg, "Sistema de Biblioteca", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FrmVideo_Load(object sender, EventArgs e)
        {
            this.Listar();
        }

        private void BtnBuscarVideo_Click(object sender, EventArgs e)
        {
            this.Buscar();
        }

        private void BtnInsertarVideo_Click(object sender, EventArgs e)
        {
            try
            {
                string ans = "";
                int tipoid = 0;
                if(txtTitulo.Text == string.Empty || TxtDirector.Text == string.Empty || txtProductora.Text == string.Empty || CmbTipo.Text == string.Empty || TxtAnio.Text == string.Empty || TxtDuracion.Text == string.Empty || TxtPais.Text == string.Empty || TxtIdioma.Text == string.Empty || TxtSub.Text == string.Empty || TxtClasificacion.Text == string.Empty || TxtGenero.Text == string.Empty || TxtUbicacion.Text == string.Empty || TxtSinopsis.Text == string.Empty)
                {
                    this.MensajeError("Falta ingresar algunos datos, serán remarcados.");
                    EpVideo.SetError(txtTitulo, "Ingrese un título");
                    EpVideo.SetError(TxtDirector, "Ingrese un director");
                    EpVideo.SetError(txtProductora, "Ingrese una productora");
                    EpVideo.SetError(CmbTipo, "Seleccione un tipo");
                    EpVideo.SetError(TxtAnio, "Ingrese un año");
                    EpVideo.SetError(TxtDuracion, "Ingrese una duración");
                    EpVideo.SetError(TxtPais, "Ingrese un país");
                    EpVideo.SetError(TxtIdioma, "Ingrese un idioma");
                    EpVideo.SetError(TxtSub, "Ingrese un título");
                    EpVideo.SetError(TxtClasificacion, "Ingrese la clasificación");
                    EpVideo.SetError(TxtGenero, "Ingrese el género");
                    EpVideo.SetError(TxtUbicacion, "Ingrese la ubicación");
                    EpVideo.SetError(TxtSinopsis, "Ingrese la sinopsis");
                }
                else
                {
                    tipoid = CmbTipo.SelectedIndex == 0 ? 1 : 2;
                    ans = NVideo.Insertar(txtTitulo.Text, TxtDirector.Text, txtProductora.Text, tipoid, Convert.ToInt32(TxtAnio.Text), Convert.ToInt32(TxtDuracion.Text), TxtPais.Text, TxtIdioma.Text, TxtSub.Text, TxtClasificacion.Text, TxtGenero.Text, TxtSinopsis.Text, TxtUbicacion.Text);
                    if(ans.Equals("Ok"))
                    {
                        this.MensajeOk("Se ha ingresado un nuevo video");
                        this.Listar();
                        this.Limpiar();
                    }
                    else
                    {
                        this.MensajeError(ans);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
            TabGeneralVideo.SelectedIndex = 0;
        }

        private void DgvListadoVideos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.Limpiar();
                BtnActualizarVideo.Visible = true;
                BtnInsertarVideo.Visible = false;
                TxtCodigoVideo.Text = Convert.ToString(DgvListadoVideos.CurrentRow.Cells["Codigo"].Value);
                txtTitulo.Text = Convert.ToString(DgvListadoVideos.CurrentRow.Cells["Titulo"].Value);
                TxtDirector.Text = Convert.ToString(DgvListadoVideos.CurrentRow.Cells["Director"].Value);
                txtProductora.Text = Convert.ToString(DgvListadoVideos.CurrentRow.Cells["Productora"].Value);
                int tipo = Convert.ToInt32(DgvListadoVideos.CurrentRow.Cells["Tipo"].Value);
                CmbTipo.SelectedIndex = tipo == 2 ? 1 : 0;
                TxtAnio.Text = Convert.ToString(DgvListadoVideos.CurrentRow.Cells["Anio"].Value);
                TxtDuracion.Text = Convert.ToString(DgvListadoVideos.CurrentRow.Cells["Duracion"].Value);
                TxtPais.Text = Convert.ToString(DgvListadoVideos.CurrentRow.Cells["Pais"].Value);
                TxtIdioma.Text = Convert.ToString(DgvListadoVideos.CurrentRow.Cells["Idioma"].Value);
                TxtSub.Text = Convert.ToString(DgvListadoVideos.CurrentRow.Cells["Subtitulo"].Value);
                TxtClasificacion.Text = Convert.ToString(DgvListadoVideos.CurrentRow.Cells["Clasificacion"].Value);
                TxtGenero.Text = Convert.ToString(DgvListadoVideos.CurrentRow.Cells["Genero"].Value);
                TxtSinopsis.Text = Convert.ToString(DgvListadoVideos.CurrentRow.Cells["Sinopsis"].Value);
                TxtUbicacion.Text = Convert.ToString(DgvListadoVideos.CurrentRow.Cells["Ubicacion"].Value);

                TabGeneralVideo.SelectedIndex = 1;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Seleccione desde la celda nombre" + "| Error: " + ex.Message);
            }
        }

        private void BtnActualizarVideo_Click(object sender, EventArgs e)
        {
            try
            {
                string ans = "";
                int tipoid = 0;
                if (txtTitulo.Text == string.Empty || TxtDirector.Text == string.Empty || txtProductora.Text == string.Empty || CmbTipo.Text == string.Empty || TxtAnio.Text == string.Empty || TxtDuracion.Text == string.Empty || TxtPais.Text == string.Empty || TxtIdioma.Text == string.Empty || TxtSub.Text == string.Empty || TxtClasificacion.Text == string.Empty || TxtGenero.Text == string.Empty || TxtUbicacion.Text == string.Empty || TxtSinopsis.Text == string.Empty)
                {
                    this.MensajeError("Falta ingresar algunos datos, serán remarcados.");
                    EpVideo.SetError(txtTitulo, "Ingrese un título");
                    EpVideo.SetError(TxtDirector, "Ingrese un director");
                    EpVideo.SetError(txtProductora, "Ingrese una productora");
                    EpVideo.SetError(CmbTipo, "Seleccione un tipo");
                    EpVideo.SetError(TxtAnio, "Ingrese un año");
                    EpVideo.SetError(TxtDuracion, "Ingrese una duración");
                    EpVideo.SetError(TxtPais, "Ingrese un país");
                    EpVideo.SetError(TxtIdioma, "Ingrese un idioma");
                    EpVideo.SetError(TxtSub, "Ingrese un título");
                    EpVideo.SetError(TxtClasificacion, "Ingrese la clasificación");
                    EpVideo.SetError(TxtGenero, "Ingrese el género");
                    EpVideo.SetError(TxtUbicacion, "Ingrese la ubicación");
                    EpVideo.SetError(TxtSinopsis, "Ingrese la sinopsis");
                }
                else
                {
                    tipoid = CmbTipo.SelectedIndex == 0 ? 1 : 2;
                    ans = NVideo.Actualizar(Convert.ToInt32(TxtCodigoVideo.Text),txtTitulo.Text, TxtDirector.Text, txtProductora.Text, tipoid, Convert.ToInt32(TxtAnio.Text), Convert.ToInt32(TxtDuracion.Text), TxtPais.Text, TxtIdioma.Text, TxtSub.Text, TxtClasificacion.Text, TxtGenero.Text, TxtSinopsis.Text, TxtUbicacion.Text);
                    if(ans.Equals("Ok"))
                    {
                        this.MensajeOk("Se actualizó de forma correcta la información del video");
                        this.Listar();
                        TabGeneralVideo.SelectedIndex = 0;
                    }
                    else
                    {
                        this.MensajeError(ans);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void ChkSeleccionarVideo_CheckedChanged(object sender, EventArgs e)
        {
            if(ChkSeleccionarVideo.Checked)
            {
                DgvListadoVideos.Columns[0].Visible = true;
                BtnEliminarVideo.Visible = true;
            }
            else
            {
                DgvListadoVideos.Columns[0].Visible = false;
                BtnEliminarVideo.Visible = false;
            }
        }

        private void DgvListadoVideos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == DgvListadoVideos.Columns["Seleccionar"].Index)
            {
                DataGridViewCheckBoxCell ChkEliminar = (DataGridViewCheckBoxCell)DgvListadoVideos.Rows[e.RowIndex].Cells["Seleccionar"];
                ChkEliminar.Value = !Convert.ToBoolean(ChkEliminar.Value);
            }
        }

        private void BtnEliminarVideo_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult option;
                option = MessageBox.Show("¿Desea eliminar el(los) video(s)?", "Sistema de Biblioteca", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if(option == DialogResult.OK)
                {
                    int codigo_video;
                    string ans = "";

                    foreach (DataGridViewRow row in DgvListadoVideos.Rows)
                    {
                        if(Convert.ToBoolean(row.Cells[0].Value))
                        {
                            codigo_video = Convert.ToInt32(row.Cells[1].Value);
                            ans = NVideo.Eliminar(codigo_video);

                            if(ans.Equals("Ok"))
                            {
                                this.MensajeOk("Se elimino el libro: " + Convert.ToString(row.Cells[2].Value));
                            }
                            else
                            {
                                this.MensajeError(ans);
                            }
                        }
                    }
                    this.Listar();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
    }
}
