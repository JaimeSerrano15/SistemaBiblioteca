using System;
using System.Data;
using SistemaBiblioteca.Entidades;
using System.Data.SqlClient;

namespace SistemaBiblioteca.Datos
{
    public class DLibro
    {

        public DataTable Listar()
        {
            SqlDataReader Result;
            DataTable Table = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstance().createConnection();
                SqlCommand Command = new SqlCommand("listar_libro", SqlCon);
                Command.CommandType = CommandType.StoredProcedure;
                SqlCon.Open();
                Result = Command.ExecuteReader();
                Table.Load(Result);
                return Table;
            } catch(Exception ex)
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
                SqlCommand Command = new SqlCommand("libro_buscar", SqlCon);
                Command.CommandType = CommandType.StoredProcedure;
                Command.Parameters.Add("@valor", SqlDbType.VarChar).Value = Valor;
                SqlCon.Open();
                Result = Command.ExecuteReader();
                Table.Load(Result);
                return Table;
            } catch(Exception ex)
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
                SqlCommand Command = new SqlCommand("libro_existe", SqlCon);
                Command.CommandType = CommandType.StoredProcedure;
                Command.Parameters.Add("@valor", SqlDbType.VarChar).Value = Valor;
                SqlParameter Exists = new SqlParameter();
                Exists.ParameterName = "@existe";
                Exists.SqlDbType = SqlDbType.Int;
                Exists.Direction = ParameterDirection.Output;
                Command.Parameters.Add(Exists);
                SqlCon.Open();
                Res = Convert.ToString(Exists.Value);
            } catch(Exception ex)
            {
                Res = ex.Message;
            } finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return Res;
        }

        public string Insertar(Libro Obj)
        {
            string Res = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstance().createConnection();
                SqlCommand Command = new SqlCommand("libro_insertar", SqlCon);
                Command.CommandType = CommandType.StoredProcedure;
                Command.Parameters.Add("@ejemplares", SqlDbType.Int).Value = Obj.No_ejemplares;
                Command.Parameters.Add("@isbn", SqlDbType.VarChar).Value = Obj.Isbn;
                Command.Parameters.Add("@titulo", SqlDbType.VarChar).Value = Obj.Titulo;
                Command.Parameters.Add("@autor", SqlDbType.VarChar).Value = Obj.Autor;
                Command.Parameters.Add("@editorial", SqlDbType.VarChar).Value = Obj.Editorial;
                Command.Parameters.Add("@aedicion", SqlDbType.VarChar).Value = Obj.A_edicion;
                Command.Parameters.Add("@edicion", SqlDbType.VarChar).Value = Obj.No_edicion;
                Command.Parameters.Add("@pais", SqlDbType.VarChar).Value = Obj.Pais;
                Command.Parameters.Add("@idioma", SqlDbType.VarChar).Value = Obj.Idioma;
                Command.Parameters.Add("@materia", SqlDbType.VarChar).Value = Obj.Materia;
                Command.Parameters.Add("@pagina", SqlDbType.VarChar).Value = Obj.No_paginas;
                Command.Parameters.Add("@ubicacion", SqlDbType.VarChar).Value = Obj.Ubicacion;
                Command.Parameters.Add("@desr", SqlDbType.VarChar).Value = Obj.Descripcion;
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

        public string Actualizar(Libro Obj)
        {
            string Res = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstance().createConnection();
                SqlCommand Command = new SqlCommand("libro_actualizar", SqlCon);
                Command.CommandType = CommandType.StoredProcedure;
                Command.Parameters.Add("@ejemplares", SqlDbType.Int).Value = Obj.No_ejemplares;
                Command.Parameters.Add("@isbn", SqlDbType.VarChar).Value = Obj.Isbn;
                Command.Parameters.Add("@titulo", SqlDbType.VarChar).Value = Obj.Titulo;
                Command.Parameters.Add("@autor", SqlDbType.VarChar).Value = Obj.Autor;
                Command.Parameters.Add("@editorial", SqlDbType.VarChar).Value = Obj.Editorial;
                Command.Parameters.Add("@aedicion", SqlDbType.VarChar).Value = Obj.A_edicion;
                Command.Parameters.Add("@edicion", SqlDbType.VarChar).Value = Obj.No_edicion;
                Command.Parameters.Add("@pais", SqlDbType.VarChar).Value = Obj.Pais;
                Command.Parameters.Add("@idioma", SqlDbType.VarChar).Value = Obj.Idioma;
                Command.Parameters.Add("@materia", SqlDbType.VarChar).Value = Obj.Materia;
                Command.Parameters.Add("@pagina", SqlDbType.VarChar).Value = Obj.No_paginas;
                Command.Parameters.Add("@ubicacion", SqlDbType.VarChar).Value = Obj.Ubicacion;
                Command.Parameters.Add("@desr", SqlDbType.VarChar).Value = Obj.Descripcion;
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
                SqlCommand Command = new SqlCommand("libro_eliminar", SqlCon);
                Command.CommandType = CommandType.StoredProcedure;
                Command.Parameters.Add("@codigolibro", SqlDbType.Int).Value = id;
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
