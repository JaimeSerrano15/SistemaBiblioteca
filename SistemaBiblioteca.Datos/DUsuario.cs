using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using SistemaBiblioteca.Entidades;
using System.Data;

namespace SistemaBiblioteca.Datos
{
    public class DUsuario
    {

        public DataTable Login(string email, string clave)
        {
            SqlDataReader result;
            DataTable table = new DataTable();
            SqlConnection sqlCon = new SqlConnection();

            try
            {
                sqlCon = Conexion.getInstance().createConnection();
                SqlCommand command = new SqlCommand("login_user", sqlCon);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@email", SqlDbType.VarChar).Value = email;
                command.Parameters.Add("@clave", SqlDbType.VarChar).Value = clave;
                sqlCon.Open();
                result = command.ExecuteReader();
                table.Load(result);
                return table;
            }
            catch (Exception ex)
            {
                return null;
                throw ex;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open) sqlCon.Close();
            }
        }
    }
}
