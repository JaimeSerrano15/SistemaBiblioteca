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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable table = new DataTable();
                table = NUsuario.Login(TxtEmail.Text.Trim(),TxtClave.Text.Trim());
                if(table.Rows.Count <= 0)
                {
                    MessageBox.Show("El email o la clave es incorrecta", "Ingreso al Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if(Convert.ToBoolean(table.Rows[0][4]) == false)
                    {
                        MessageBox.Show("Este usuario no está activo", "Ingreso al Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        FrmPrincipal frm = new FrmPrincipal();
                        frm.idUser = Convert.ToInt32(table.Rows[0][0]);
                        frm.idRol = Convert.ToInt32(table.Rows[0][1]);
                        frm.rol = Convert.ToString(table.Rows[0][2]);
                        frm.name = Convert.ToString(table.Rows[0][3]);
                        frm.estado = Convert.ToBoolean(table.Rows[0][4]);
                        frm.Show();
                        this.Hide();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
