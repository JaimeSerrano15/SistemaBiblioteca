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
    public partial class FrmLibro : Form
    {
        private string tituloAnt;
        public FrmLibro()
        {
            InitializeComponent();
        }

        private void Listar()
        {
            try
            {
                DgvListadoLibro.DataSource = NLibro.Listar();
                this.Formato();
                this.Limpiar();
                lblTotalLibro.Text = "Total de Libros: " + Convert.ToString(DgvListadoLibro.Rows.Count);
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
                DgvListadoLibro.DataSource = NLibro.Buscar(txtBuscarLibro.Text);
                this.Formato();
                lblTotalLibro.Text = "Total de Libros: " + Convert.ToString(DgvListadoLibro.Rows.Count);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void Formato()
        {
            DgvListadoLibro.Columns[0].Visible = false;
            DgvListadoLibro.Columns[1].Width = 50;
            DgvListadoLibro.Columns[2].Width = 75;
            DgvListadoLibro.Columns[2].HeaderText = "Ejemplares";
            DgvListadoLibro.Columns[3].Width = 100;
            DgvListadoLibro.Columns[4].Width = 200;
            DgvListadoLibro.Columns[5].Width = 200;
            DgvListadoLibro.Columns[6].Width = 200;
            DgvListadoLibro.Columns[7].Width = 100;
            DgvListadoLibro.Columns[7].HeaderText = "Año-Edicion";
            DgvListadoLibro.Columns[8].Width = 50;
            DgvListadoLibro.Columns[8].HeaderText = "Edicion";
            DgvListadoLibro.Columns[9].Width = 50;
            DgvListadoLibro.Columns[10].Width = 100;
            DgvListadoLibro.Columns[11].Width = 100;
            DgvListadoLibro.Columns[12].Width = 50;
            DgvListadoLibro.Columns[13].Width = 50;
            DgvListadoLibro.Columns[14].Width = 400;    
        }

        private void Limpiar()
        {
            TxtEjemplares.Clear();
            TxtIsbn.Clear();
            TxtTitulo.Clear();
            TxtAutor.Clear();
            TxtEditorial.Clear();
            TxtAEdicion.Clear();
            TxtEdicion.Clear();
            TxtPais.Clear();
            TxtIdioma.Clear();
            TxtMateriaa.Clear();
            TxtPaginas.Clear();
            TxtUbicacion.Clear();
            TxtDescripcion.Clear();
            BtnInsertarLibro.Visible = true;
            BtnActualizar.Visible = false;
            EpLibro.Clear();

            DgvListadoLibro.Columns[0].Visible = false;
            BtnEliminarLibro.Visible = false;
            ChkSeleccionarLibro.Checked = false;
        }

        private void MensajeError(string msg)
        {
            MessageBox.Show(msg, "Sistema de Biblioteca", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void MensajeOk(string msg)
        {
            MessageBox.Show(msg, "Sistema de Biblioteca", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FrmLibro_Load(object sender, EventArgs e)
        {
            this.Listar();
        }

        private void BtnBuscarLibro_Click(object sender, EventArgs e)
        {
            this.Buscar();
        }

        private void BtnInsertarLibro_Click(object sender, EventArgs e)
        {
            try
            {
                string ans = "";
                if(TxtEjemplares.Text == string.Empty || TxtIsbn.Text == string.Empty || TxtTitulo.Text == string.Empty || TxtAutor.Text == string.Empty || TxtEditorial.Text == string.Empty || TxtAEdicion.Text == string.Empty || TxtEdicion.Text == string.Empty || TxtPais.Text == string.Empty || TxtIdioma.Text == string.Empty || TxtMateriaa.Text == string.Empty || TxtPaginas.Text == string.Empty || TxtUbicacion.Text == string.Empty)
                {
                    this.MensajeError("Falta ingresar algunos datos, serán remarcados.");
                    EpLibro.SetError(TxtEjemplares, "Ingrese el número de ejemplares.");
                    EpLibro.SetError(TxtIsbn, "Ingrese el ISBN");
                    EpLibro.SetError(TxtTitulo, "Ingrese un título");
                    EpLibro.SetError(TxtAutor, "Ingrese el autor");
                    EpLibro.SetError(TxtEditorial, "Ingrese la editorial");
                    EpLibro.SetError(TxtAEdicion, "Ingrese el año de edición");
                    EpLibro.SetError(TxtEdicion, "Ingrese el número de edición");
                    EpLibro.SetError(TxtIdioma, "Ingrese el idioma");
                    EpLibro.SetError(TxtMateriaa, "Ingrese la materia");
                    EpLibro.SetError(TxtPaginas, "Ingrese el número de páginas");
                    EpLibro.SetError(TxtUbicacion, "Ingrese la ubicación");
                }
                else
                {
                    ans = NLibro.Insertar(Convert.ToInt32(TxtEjemplares.Text), TxtIsbn.Text.Trim(), TxtTitulo.Text.Trim(), TxtAutor.Text.Trim(), TxtEditorial.Text.Trim(), Convert.ToInt32(TxtAEdicion.Text), Convert.ToInt32(TxtEdicion), TxtPais.Text.Trim(), TxtIdioma.Text.Trim(), TxtMateriaa.Text.Trim(), Convert.ToInt32(TxtPaginas.Text), TxtUbicacion.Text.Trim(), TxtDescripcion.Text.Trim());
                    if(ans.Equals("Ok"))
                    {
                        this.MensajeOk("Se ha insertado un nuevo libro");
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

        private void BtnLibroCancelar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
            tabGeneralLibro.SelectedIndex = 0;
        }

        private void DgvListadoLibro_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.Limpiar();
                BtnActualizar.Visible = true;
                BtnInsertarLibro.Visible = false;
                txtCodigoLibro.Text = Convert.ToString(DgvListadoLibro.CurrentRow.Cells["Codigo"].Value);
                TxtEjemplares.Text = Convert.ToString(DgvListadoLibro.CurrentRow.Cells["Num_Ejemplares"].Value);
                TxtIsbn.Text = Convert.ToString(DgvListadoLibro.CurrentRow.Cells["ISBN"].Value);
                this.tituloAnt = Convert.ToString(DgvListadoLibro.CurrentRow.Cells["Titulo"].Value);
                TxtTitulo.Text = Convert.ToString(DgvListadoLibro.CurrentRow.Cells["Titulo"].Value);
                TxtAutor.Text = Convert.ToString(DgvListadoLibro.CurrentRow.Cells["Autores"].Value);
                TxtEditorial.Text = Convert.ToString(DgvListadoLibro.CurrentRow.Cells["Editorial"].Value);
                TxtAEdicion.Text = Convert.ToString(DgvListadoLibro.CurrentRow.Cells["Edicion"].Value);
                TxtEdicion.Text = Convert.ToString(DgvListadoLibro.CurrentRow.Cells["Num_Edicion"].Value);
                TxtPais.Text = Convert.ToString(DgvListadoLibro.CurrentRow.Cells["Pais"].Value);
                TxtIdioma.Text = Convert.ToString(DgvListadoLibro.CurrentRow.Cells["Idioma"].Value);
                TxtMateriaa.Text = Convert.ToString(DgvListadoLibro.CurrentRow.Cells["Materia"].Value);
                TxtPaginas.Text = Convert.ToString(DgvListadoLibro.CurrentRow.Cells["Paginas"].Value);
                TxtUbicacion.Text = Convert.ToString(DgvListadoLibro.CurrentRow.Cells["Ubicacion"].Value);
                TxtDescripcion.Text = Convert.ToString(DgvListadoLibro.CurrentRow.Cells["Descripcion"].Value);

                tabGeneralLibro.SelectedIndex = 1;

            }
            catch(Exception ex)
            {
                MessageBox.Show("Seleccione desde la celda nombre" + "| Error: " + ex.Message);
            }
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                string ans = "";
                if (TxtEjemplares.Text == string.Empty || TxtIsbn.Text == string.Empty || TxtTitulo.Text == string.Empty || TxtAutor.Text == string.Empty || TxtEditorial.Text == string.Empty || TxtAEdicion.Text == string.Empty || TxtEdicion.Text == string.Empty || TxtPais.Text == string.Empty || TxtIdioma.Text == string.Empty || TxtMateriaa.Text == string.Empty || TxtPaginas.Text == string.Empty || TxtUbicacion.Text == string.Empty)
                {
                    this.MensajeError("Falta ingresar algunos datos, serán remarcados.");
                    EpLibro.SetError(TxtEjemplares, "Ingrese el número de ejemplares.");
                    EpLibro.SetError(TxtIsbn, "Ingrese el ISBN");
                    EpLibro.SetError(TxtTitulo, "Ingrese un título");
                    EpLibro.SetError(TxtAutor, "Ingrese el autor");
                    EpLibro.SetError(TxtEditorial, "Ingrese la editorial");
                    EpLibro.SetError(TxtAEdicion, "Ingrese el año de edición");
                    EpLibro.SetError(TxtEdicion, "Ingrese el número de edición");
                    EpLibro.SetError(TxtIdioma, "Ingrese el idioma");
                    EpLibro.SetError(TxtMateriaa, "Ingrese la materia");
                    EpLibro.SetError(TxtTitulo, "Ingrese un título");
                    EpLibro.SetError(TxtTitulo, "Ingrese un título");
                    EpLibro.SetError(TxtTitulo, "Ingrese un título");
                }
                else
                {
                    ans = NLibro.Actualizar(Convert.ToInt32(txtCodigoLibro.Text),Convert.ToInt32(TxtEjemplares.Text), TxtIsbn.Text.Trim(), TxtTitulo.Text, TxtAutor.Text.Trim(), TxtEditorial.Text.Trim(), Convert.ToInt32(TxtAEdicion.Text), Convert.ToInt32(TxtEdicion.Text), TxtPais.Text.Trim(), TxtIdioma.Text.Trim(), TxtMateriaa.Text.Trim(), Convert.ToInt32(TxtPaginas.Text), TxtUbicacion.Text.Trim(), TxtDescripcion.Text.Trim());
                    if(ans.Equals("Ok"))
                    {
                        this.MensajeOk("Se actualizó de forma correcta la información del libro");
                        this.Listar();
                        tabGeneralLibro.SelectedIndex = 0;
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

        private void ChkSeleccionarLibro_CheckedChanged(object sender, EventArgs e)
        {
            if(ChkSeleccionarLibro.Checked)
            {
                DgvListadoLibro.Columns[0].Visible = true;
                BtnEliminarLibro.Visible = true;
            }
            else
            {
                DgvListadoLibro.Columns[0].Visible = false;
                BtnEliminarLibro.Visible = false;
            }
        }

        private void DgvListadoLibro_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == DgvListadoLibro.Columns["Seleccionar"].Index)
            {
                DataGridViewCheckBoxCell ChkEliminar = (DataGridViewCheckBoxCell)DgvListadoLibro.Rows[e.RowIndex].Cells["Seleccionar"];
                ChkEliminar.Value = !Convert.ToBoolean(ChkEliminar.Value);
            }
        }

        private void BtnEliminarLibro_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult option;
                option = MessageBox.Show("¿Desea eliminar el(los) libro(s)?", "Sistema de Biblioteca", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if(option == DialogResult.OK)
                {
                    int codigo_libro;
                    string ans = "";

                    foreach (DataGridViewRow row in DgvListadoLibro.Rows)
                    {
                        if(Convert.ToBoolean(row.Cells[0].Value))
                        {
                            codigo_libro = Convert.ToInt32(row.Cells[1].Value);
                            ans = NLibro.Eliminar(codigo_libro);

                            if(ans.Equals("Ok"))
                            {
                                this.MensajeOk("Se eliminó el libro: " + Convert.ToString(row.Cells[4].Value));
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
    }
}
