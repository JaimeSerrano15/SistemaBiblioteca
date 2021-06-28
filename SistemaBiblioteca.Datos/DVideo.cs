using System;
using System.Data;
using System.Data.SqlClient;
using SistemaBiblioteca.Entidades;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBiblioteca.Datos
{
    public class DVideo
    {

        public DataTable Listar()
        {
            SqlDataReader Result;
            DataTable Table = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstance().createConnection();
                SqlCommand Command = new SqlCommand("listar_video", SqlCon);
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

        public DataTable Buscar(String Valor)
        {
            SqlDataReader Result;
            DataTable Table = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstance().createConnection();
                SqlCommand Command = new SqlCommand("video_buscar", SqlCon);
                Command.CommandType = CommandType.StoredProcedure;
                Command.Parameters.Add("@valor", SqlDbType.VarChar).Value = Valor;
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

        public string Existe(string Valor)
        {
            string Res = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstance().createConnection();
                SqlCommand Command = new SqlCommand("video_existe", SqlCon);
                Command.CommandType = CommandType.StoredProcedure;
                Command.Parameters.Add("@valor", SqlDbType.VarChar).Value = Valor;
                SqlParameter Exists = new SqlParameter();
                Exists.ParameterName = "@existe";
                Exists.SqlDbType = SqlDbType.Int;
                Exists.Direction = ParameterDirection.Output;
                Command.Parameters.Add(Exists);
                SqlCon.Open();
                Res = Convert.ToString(Exists.Value);
            }
            catch (Exception ex)
            {
                Res = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return Res;
        }

        public string Insertar(Video Obj)
        {
            string Res = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstance().createConnection();
                SqlCommand Command = new SqlCommand("video_insertar", SqlCon);
                Command.CommandType = CommandType.StoredProcedure;
                Command.Parameters.Add("@titulo", SqlDbType.Int).Value = Obj.Titulo;
                Command.Parameters.Add("@director", SqlDbType.VarChar).Value = Obj.Director;
                Command.Parameters.Add("@productora", SqlDbType.VarChar).Value = Obj.Productora;
                Command.Parameters.Add("@id_tipo", SqlDbType.VarChar).Value = Obj.Id_tipo;
                Command.Parameters.Add("@Anio", SqlDbType.VarChar).Value = Obj.Anio;
                Command.Parameters.Add("@duracion", SqlDbType.VarChar).Value = Obj.Duracion;
                Command.Parameters.Add("@pais", SqlDbType.VarChar).Value = Obj.Pais;
                Command.Parameters.Add("@idioma", SqlDbType.VarChar).Value = Obj.Idioma;
                Command.Parameters.Add("@subtitulo", SqlDbType.VarChar).Value = Obj.Subtitlo;
                Command.Parameters.Add("@clasificacion", SqlDbType.VarChar).Value = Obj.Clasificacion;
                Command.Parameters.Add("@genero", SqlDbType.VarChar).Value = Obj.Genero;
                Command.Parameters.Add("@sinopsis", SqlDbType.VarChar).Value = Obj.Sinopsis;
                Command.Parameters.Add("@ubicacion", SqlDbType.VarChar).Value = Obj.Ubicacion;
                SqlCon.Open();
                Res = Command.ExecuteNonQuery() == 1 ? "Ok" : "No se pudo hacer el registro!";
            }
            catch (Exception ex)
            {
                Res = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return Res;
        }

        public string Actualizar(Video Obj)
        {
            string Res = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstance().createConnection();
                SqlCommand Command = new SqlCommand("video_actualizar", SqlCon);
                Command.CommandType = CommandType.StoredProcedure;
                Command.Parameters.Add("@titulo", SqlDbType.Int).Value = Obj.Titulo;
                Command.Parameters.Add("@director", SqlDbType.VarChar).Value = Obj.Director;
                Command.Parameters.Add("@productora", SqlDbType.VarChar).Value = Obj.Productora;
                Command.Parameters.Add("@id_tipo", SqlDbType.VarChar).Value = Obj.Id_tipo;
                Command.Parameters.Add("@Anio", SqlDbType.VarChar).Value = Obj.Anio;
                Command.Parameters.Add("@duracion", SqlDbType.VarChar).Value = Obj.Duracion;
                Command.Parameters.Add("@pais", SqlDbType.VarChar).Value = Obj.Pais;
                Command.Parameters.Add("@idioma", SqlDbType.VarChar).Value = Obj.Idioma;
                Command.Parameters.Add("@subtitulo", SqlDbType.VarChar).Value = Obj.Subtitlo;
                Command.Parameters.Add("@clasificacion", SqlDbType.VarChar).Value = Obj.Clasificacion;
                Command.Parameters.Add("@genero", SqlDbType.VarChar).Value = Obj.Genero;
                Command.Parameters.Add("@sinopsis", SqlDbType.VarChar).Value = Obj.Sinopsis;
                Command.Parameters.Add("@ubicacion", SqlDbType.VarChar).Value = Obj.Ubicacion;
                SqlCon.Open();
                Res = Command.ExecuteNonQuery() == 1 ? "Ok" : "No se pudo actualizar el registro!";
            }
            catch (Exception ex)
            {
                Res = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return Res;
        }

        public string Eliminar(int id)
        {
            string Res = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstance().createConnection();
                SqlCommand Command = new SqlCommand("video_eliminar", SqlCon);
                Command.CommandType = CommandType.StoredProcedure;
                Command.Parameters.Add("@codigo_video", SqlDbType.Int).Value = id;
                SqlCon.Open();
                Res = Command.ExecuteNonQuery() == 1 ? "Ok" : "No se pudo eliminar el registro!";
            }
            catch (Exception ex)
            {
                Res = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return Res;
        }
    }
}
