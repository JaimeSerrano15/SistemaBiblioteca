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
    public partial class FrmPrestamoLibro : Form
    {
        public FrmPrestamoLibro()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == Libros.Columns["Seleccionar"].Index)
            {
                foreach (DataGridViewRow row in Libros.Rows)
                {
                    if (Convert.ToBoolean(row.Cells[0].Value))
                    {
                        row.Cells[0].Value = false;
                    }
                }

                DataGridViewCheckBoxCell Seleccionar = (DataGridViewCheckBoxCell)Libros.Rows[e.RowIndex].Cells["Seleccionar"];
                Seleccionar.Value = !Convert.ToBoolean(Seleccionar.Value);
   

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int profesor = 0;
            string profesor_name = "";
            int codigo_libro = 0;
            DateTime fecha_devolucion = datePick.Value;
            DateTime fecha_prestamo = DateTime.Today;
            foreach (DataGridViewRow row in Profesores.Rows)
            {
                if (Convert.ToBoolean(row.Cells[0].Value))
                {
                    profesor = Convert.ToInt32(row.Cells[1].Value);
                    profesor_name = Convert.ToString(row.Cells[2].Value);
                }
            }

            foreach (DataGridViewRow row in Libros.Rows)
            {
                if (Convert.ToBoolean(row.Cells[0].Value))
                {
                    codigo_libro = Convert.ToInt32(row.Cells[1].Value);
                }
            }

            MessageBox.Show("id profesor" + profesor + " codigo del libro" +
                codigo_libro + " fecha de devolucion " + fecha_devolucion +
                " fecha de prestamo " + fecha_prestamo);

            NPrestamo_libro.Insertar_Prestamo(profesor, codigo_libro,
            fecha_prestamo, fecha_devolucion);
            Prestamos.DataSource = NPrestamo_libro.Listar_Prestamos(profesor_name);



        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Buscar_Libro(string valor)
        {
            try
            {
                Libros.DataSource = NPrestamo_libro.Buscar_Libro(valor);
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void Buscar_Profesor(string valor)
        {
            try
            {
                Profesores.DataSource = NPrestamo_libro.Buscar_Profesor(valor);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        private void Listar_Libros()
        {
            try
            {
                Libros.DataSource = NPrestamo_libro.Listar_Libros();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void Listar_Profesores()
        {
            try
            {
                Profesores.DataSource = NPrestamo_libro.Listar_Profesores();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        private void FrmPrestamoLibro_Load(object sender, EventArgs e)
        {
            Listar_Libros();
            Listar_Profesores();
        }

        private void BuscarLibro_Click(object sender, EventArgs e)
        {
            try
            {
                string valor = "";
                if(tblibro.Text == string.Empty)
                {
                    Listar_Libros();
                } else
                {
                    valor = tblibro.Text;
                    Buscar_Libro(valor);
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void Profesores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == Profesores.Columns["Select"].Index)
            {
                if (e.ColumnIndex == Profesores.Columns["Select"].Index)
                {
                    foreach (DataGridViewRow row in Profesores.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            row.Cells[0].Value = false;
                        }
                    }

                    DataGridViewCheckBoxCell Seleccionar = (DataGridViewCheckBoxCell)Profesores.Rows[e.RowIndex].Cells["Select"];
                    Seleccionar.Value = !Convert.ToBoolean(Seleccionar.Value);

                    string nombre;

                    foreach (DataGridViewRow row in Profesores.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            nombre = Convert.ToString(row.Cells[2].Value);
                            Prestamos.DataSource = NPrestamo_libro.Listar_Prestamos(nombre);
                        }
                    }
                }
            }
        }

        private void buscarprofesor_Click(object sender, EventArgs e)
        {
            try
            {
                string valor = "";
                if (tbprofesor.Text == string.Empty)
                {
                    Listar_Profesores();
                }
                else
                {
                    valor = tbprofesor.Text;
                    Buscar_Profesor(valor);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
    }
}
