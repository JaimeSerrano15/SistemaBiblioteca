using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using SistemaBiblioteca.Entidades;

namespace SistemaBiblioteca.Datos
{
    public class DPrestamo_Libro
    {

        public DataTable Listar_Libros()
        {
            SqlDataReader Result;
            DataTable Table = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstance().createConnection();
                SqlCommand Command = new SqlCommand("listar_libros_formato", SqlCon);
                Command.CommandType = CommandType.StoredProcedure;
                SqlCon.Open();
                Result = Command.ExecuteReader();
                Table.Load(Result);
                return Table;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
        }

        public DataTable Listar_Profesores()
        {
            SqlDataReader Result;
            DataTable Table = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstance().createConnection();
                SqlCommand Command = new SqlCommand("listar_profesor_formato", SqlCon);
                Command.CommandType = CommandType.StoredProcedure;
                SqlCon.Open();
                Result = Command.ExecuteReader();
                Table.Load(Result);
                return Table;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
        }
        public DataTable Buscar_Libro(String valor)
        {
            SqlDataReader Result;
            DataTable Table = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstance().createConnection();
                SqlCommand Command = new SqlCommand("buscar_libro_prestamo", SqlCon);
                Command.CommandType = CommandType.StoredProcedure;
                Command.Parameters.Add("@valor", SqlDbType.VarChar).Value = valor;
                SqlCon.Open();
                Result = Command.ExecuteReader();
                Table.Load(Result);
                return Table;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
        }

        public DataTable Buscar_Profesor(String valor)
        {
            SqlDataReader Result;
            DataTable Table = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstance().createConnection();
                SqlCommand Command = new SqlCommand("buscar_profesor", SqlCon);
                Command.CommandType = CommandType.StoredProcedure;
                Command.Parameters.Add("@valor", SqlDbType.VarChar).Value = valor;
                SqlCon.Open();
                Result = Command.ExecuteReader();
                Table.Load(Result);
                return Table;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
        }

        public DataTable Listar_Prestamos(string valor)
        {
            SqlDataReader Result;
            DataTable Table = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstance().createConnection();
                SqlCommand Command = new SqlCommand("listar_prestamos", SqlCon);
                Command.CommandType = CommandType.StoredProcedure;
                Command.Parameters.Add("@valor", SqlDbType.VarChar).Value = valor;
                SqlCon.Open();
                Result = Command.ExecuteReader();
                Table.Load(Result);
                return Table;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
        }

        public string Insertar_Prestamo(Prestamo_libro Obj)
        {
            string res = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstance().createConnection();
                SqlCommand Command = new SqlCommand("registrar_prestamo_libro", SqlCon);
                Command.CommandType = CommandType.StoredProcedure;
                Command.Parameters.Add("@profesor", SqlDbType.Int).Value = Obj.Id_usuario;
                Command.Parameters.Add("@libro", SqlDbType.Int).Value = Obj.Codigo_libro;
                Command.Parameters.Add("@fecha_prestamo", SqlDbType.DateTime).Value = Obj.Fecha_prestamo;
                Command.Parameters.Add("@fecha_devolucion", SqlDbType.DateTime).Value = Obj.Fecha_devolucion;

                SqlCon.Open();
                
                res = Command.ExecuteNonQuery() == 1 ? "Ok" : "No se pudo hacer el registro!";
            }
            catch (Exception ex)
            {
                res = ex.Message;
            }
            finally
            {
 
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return res;
        }
    }
}
